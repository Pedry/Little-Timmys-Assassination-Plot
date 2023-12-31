using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class NavMeshScript : MonoBehaviour
{

    [SerializeField]
    public Transform target;

    public NavMeshAgent agent;

    StudentAnimation studentAnimation;

    Rigidbody2D rb;

    PlayerInput input;

    float stateTimer;

    float layerY;

    GameObject tileReference;


    public enum Movement
    {

        Vertical,
        Horizontal

    }

    int ppu;

    Movement state;

    // Start is called before the first frame update
    void Awake()
    {

        ppu = 96;

        

        input = new PlayerInput();

        layerY = transform.position.z;
        
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        state = Movement.Vertical;

        studentAnimation = GetComponent<StudentAnimation>();

        rb = GetComponent<Rigidbody2D>();

        foreach (GameObject gameObject in SceneManager.GetActiveScene().GetRootGameObjects())
        {

            if (gameObject.name == "FloorTileReference")
            {

                tileReference = gameObject;

            }

        }

    }

    private void OnEnable()
    {

        input.Enable();

        input.InGame.RandomizeNavigation.performed += RandomizeNavigation;

        agent.Warp(new Vector3(transform.position.x, transform.position.y, layerY));

        agent.SetDestination(target.position);

        UpdateState();

    }

    void GenerateNavigationPositions()
    {

        GameObject floor = GameObject.Find("Floor");

        Tilemap tilemap = floor.GetComponent<Tilemap>();

        BoundsInt boundsInt = tilemap.cellBounds;

        Vector3 position
            = boundsInt.position;
        Vector3 size
            = boundsInt.size * 96;
        Vector3 mapPositionOffset
            = new Vector3(boundsInt.position.x, boundsInt.position.y) * ppu;

        GameObject mapPositionsParent = GameObject.Find("NavigationTiles");

        tileReference.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0f);

        for (int i = 0; i < size.x; i += ppu)
        {

            for (int j = 0; j < size.y; j += ppu)
            {

                GameObject instance = Instantiate(tileReference, position
                    + new Vector3(i, j, 0)
                    + mapPositionOffset
                    + new Vector3(0.5f * ppu, 0.5f * ppu, 0), Quaternion.identity);

                instance.transform.localScale = (Vector3.one * ppu);

                instance.transform.SetParent(mapPositionsParent.transform, true);

                NavigationEngine.navigationTiles.Add(instance);

            }

        }

        Transform saveTransform = target.gameObject.transform;

        List<GameObject> refreshedTiles = new List<GameObject>();
        List<GameObject> wastedTiles = new List<GameObject>();

        foreach (GameObject instance in NavigationEngine.navigationTiles)
        {

            target.gameObject.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y, transform.position.z);


            if (agent.CalculatePath(target.position, agent.path))
            {

                refreshedTiles.Add(instance);

            }
            else
            {

                wastedTiles.Add(instance);

            }

        }

        foreach (var item in wastedTiles)
        {

            Destroy(item);
            
        }

        NavigationEngine.navigationTiles = refreshedTiles;
        target.gameObject.transform.position = saveTransform.position;


    }

    public void RandomizeNavigation(InputAction.CallbackContext context)
    {

        int minIndex = 0;
        int maxIndex = NavigationEngine.navigationTiles.Count-1;

        int randomIndex = Random.Range(minIndex, maxIndex);

        target.gameObject.transform.position = new Vector3(NavigationEngine.navigationTiles[randomIndex].transform.position.x, NavigationEngine.navigationTiles[randomIndex].transform.position.y, transform.position.z);

        GetComponent<StudentAnimation>().isMoving = true;

        /*
        if (!agent.CalculatePath(target.position, agent.path))
        {

            RandomizeNavigation(context);

        }
        */

    }

    public void RandomizeNavigationAwayFromTarget(Transform toAvoid)
    {

        int minIndex = 0;
        int maxIndex = NavigationEngine.navigationTiles.Count - 1;

        int randomIndex = Random.Range(minIndex, maxIndex);

        target.gameObject.transform.position = new Vector3(NavigationEngine.navigationTiles[randomIndex].transform.position.x, NavigationEngine.navigationTiles[randomIndex].transform.position.y, transform.position.z);


        if (!agent.CalculatePath(target.position, agent.path) && Mathf.Abs(toAvoid.transform.position.x - target.transform.position.x) < 500 && Mathf.Abs(toAvoid.transform.position.y - target.transform.position.y) < 500)
        {

            RandomizeNavigationAwayFromTarget(toAvoid);

        }

    }

    public void RandomizeNavigation()
    {

        int minIndex = 0;
        int maxIndex = NavigationEngine.navigationTiles.Count - 1;

        int randomIndex = Random.Range(minIndex, maxIndex);

        target.gameObject.transform.position = new Vector3(NavigationEngine.navigationTiles[randomIndex].transform.position.x, NavigationEngine.navigationTiles[randomIndex].transform.position.y, transform.position.z);


        if (!agent.CalculatePath(target.position, agent.path))
        {

            RandomizeNavigation();

        }

    }

    private void Start()
    {

        UpdateState();

        if (agent.isOnNavMesh)
        {

            GenerateNavigationPositions();

            target.position = new Vector3(
                GetComponent<StudentData>().information.saveNavPointPosition[0],
                GetComponent<StudentData>().information.saveNavPointPosition[1],
                GetComponent<StudentData>().information.saveNavPointPosition[2]);

            agent.SetDestination(target.position);

        }

    }

    public bool targetReached;

    // Update is called once per frame
    void FixedUpdate()
    {

        if(GetComponent<StudentAnimation>() != null)
        {

            if(GetComponent<StudentAnimation>().lifeState == StudentAnimation.LifeState.Dead)
            {

                rb.velocity = Vector3.zero;


                return;

            }

        }

        Timers();

        if (stateTimer > 0.4f)
        {

            agent.SetDestination(target.position);

            stateTimer = 0;

            if(!targetReached)
            {

                UpdateMovement();

            }
            else if(GetComponent<StudentStateRules>().state == StudentStateRules.State.Normal)
            {

                targetReached = false;
                RandomizeNavigation();

            }

        }

        UpdateState();

        if (Mathf.Abs(transform.position.x - target.transform.position.x) < 40 && Mathf.Abs(transform.position.y - target.transform.position.y) < 15)
        {

            if(!targetReached)
            {

                rb.velocity = new Vector3(0, 0, 0);

                studentAnimation.isMoving = false;

                targetReached = true;

            }

            return;

        }
        else
        {

            targetReached = false;

            studentAnimation.isMoving = true;

        }

    }

    void Timers()
    {

        stateTimer += Time.deltaTime;

    }

    void UpdateMovement()
    {

        if (state == Movement.Horizontal)
        {

            if (agent.desiredVelocity.x > 0)
            {

                rb.velocity = new Vector3(40, 0, 0);


            }
            else if (agent.desiredVelocity.x < 0)
            {

                rb.velocity = new Vector3(-40, 0, 0);

            }


        }
        else if (state == Movement.Vertical)
        {

            if (agent.desiredVelocity.y > 0)
            {

                rb.velocity = new Vector3(0, 40, 0);


            }
            else if (agent.desiredVelocity.y < 0)
            {

                rb.velocity = new Vector3(0, -40, 0);

            }

        }

        rb.velocity = rb.velocity * GetComponent<StudentStateRules>().stateModifiers.speedMultiplier;

    }

    void UpdateState()
    {


        if (Mathf.Abs(agent.desiredVelocity.normalized.x) > Mathf.Abs(agent.desiredVelocity.normalized.y))
        {

            state = Movement.Horizontal;

            if (rb.velocity.x > 0)
            {

                studentAnimation.state = StudentAnimation.AnimationState.Right;

            }
            else if (rb.velocity.x < 0)
            {

                studentAnimation.state = StudentAnimation.AnimationState.Left;

            }

        }
        else
        {

            state = Movement.Vertical;

            if (rb.velocity.y> 0)
            {

                studentAnimation.state = StudentAnimation.AnimationState.Up;

            }
            else if (rb.velocity.y < 0)
            {

                studentAnimation.state = StudentAnimation.AnimationState.Down;

            }

        }

    }

    [BurstCompile]
    private void Update()
    {

        if (agent != null)
        {

            agent.velocity = Vector3.zero;

        }

    }
}
