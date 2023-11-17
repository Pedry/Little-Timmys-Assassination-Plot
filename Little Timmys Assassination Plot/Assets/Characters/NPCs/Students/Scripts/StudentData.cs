using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StudentData : MonoBehaviour, ISavable
{

    [SerializeField]
    GameObject mainCharacter;

    [SerializeField]
    public Information information;

    GameObject outputField;

    Dictionary<GameObject, Relation> acquaintances;

    private void Awake()
    {

        acquaintances = new Dictionary<GameObject, Relation>();

    }

    void Start()
    {

        
    }

    public void SetOutputField(GameObject outputField)
    {

        this.outputField = outputField;

    }

    public void AskedAbout(string name)
    {

        bool hasNoInformation = true;

        foreach (KeyValuePair<GameObject, Relation> relation in acquaintances)
        {

            if (relation.Key.GetComponent<StudentData>().information.name.Equals(name))
            {

                hasNoInformation = false;

                string output;
                string ownerName = information.name;
                string targetName = relation.Key.GetComponent<StudentData>().information.name;
                string targetPronoun1 = "";
                string targetPronoun2 = "";

                switch (relation.Key.GetComponent<StudentData>().information.gender)
                {

                    case Information.Gender.Male:
                        targetPronoun1 = "him";
                        targetPronoun2 = "he";
                        break;
                    case Information.Gender.Female:
                        targetPronoun1 = "her";
                        targetPronoun2 = "she";
                        break;

                }

                string Message = "";

                switch (relation.Value.likes)
                {
                    case -3:
                        Message = "I HATE " + targetPronoun1;
                        break;
                    case -2:
                        Message = "I Despice " + targetPronoun1;
                        break;
                    case -1:
                        Message = "I don't like " + targetPronoun1;
                        break;
                    case 0:
                        Message = "I don't really know " + targetPronoun1;
                        break;
                    case 1:
                        Message = "I think " + targetPronoun2 + " nice?";
                        break;
                    case 2:
                        Message = "Yeah " + targetPronoun2 + " is my friend!";
                        break;
                    case 3:
                        Message = targetName + " is my best friend!";
                        break;
                }

                

                output = "\n" + ownerName + ": " + Message;
                outputField.GetComponent<TextMeshProUGUI>().SetText(output);

            }

        }

        if(hasNoInformation)
        {

            outputField.GetComponent<TextMeshProUGUI>().SetText(information.name + ": I don't know that person..");

        }

    }

    void Update()
    {
       

    }

}

[Serializable]
public class Information
{
    public enum Gender
    {
        Male,
        Female
    }

    public Gender gender;
    public string name;

}

struct Relation
{

    public string lastSeen;
    public string opinion;
    public int likes;

}
