//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/InGame/Characters/MainCharacter/Components/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""e603a2c6-c136-4e1e-a466-beea265b82d9"",
            ""actions"": [
                {
                    ""name"": ""WalkRight"",
                    ""type"": ""Button"",
                    ""id"": ""b7b06c20-4d8d-4537-825d-3ae4e6ef341c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.6),Press(pressPoint=0.4,behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WalkLeft"",
                    ""type"": ""Button"",
                    ""id"": ""a3ebb04f-4589-4a05-99fa-24e3b02feeb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WalkUp"",
                    ""type"": ""Button"",
                    ""id"": ""b4624251-f4e5-46d9-b5a1-006ecd23695a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WalkDown"",
                    ""type"": ""Button"",
                    ""id"": ""7943a05c-2519-4c44-a3c1-de1a9997baf6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""65afef36-f97f-4122-aa39-ba5f5412dd6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Complete"",
                    ""type"": ""Button"",
                    ""id"": ""dca32f94-ba9d-402f-88b6-e74d8efae324"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""QuitGame"",
                    ""type"": ""Button"",
                    ""id"": ""9cdcb3b5-b8f6-4c25-918f-7908c7cd4a71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RandomizeNavigation"",
                    ""type"": ""Button"",
                    ""id"": ""6ac99951-3c1d-46b8-aede-8bb0562fc6ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""e72dad88-21bf-42c7-aee3-99ed3f18f0ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9f4d1827-447b-41ac-b993-56665be68c0a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""WalkRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db93c92e-e064-4ae4-8f31-a2dbc5ea9121"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""WalkLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fc547c4-8fe1-4ae4-ac55-a8491cdd8b31"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""WalkUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cca87010-dcf4-4aff-af5a-6430a8bc0711"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""WalkDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f84097a-0abf-4e13-816c-db01bf6d937d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5227780b-5bca-4067-9e75-eb926680a58e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Complete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""CtrlQ"",
                    ""id"": ""a86aefa8-075e-41b1-9626-8e7f7c9eca02"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuitGame"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""ab377428-de66-4025-859e-9bb98c55d86d"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""3bfd76bb-5a11-463b-9dbf-7d1d586306aa"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b243ffb8-c121-499e-9624-804b8de785b3"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RandomizeNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e95531f-e581-4345-acd6-a6cbeb4fec03"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_WalkRight = m_InGame.FindAction("WalkRight", throwIfNotFound: true);
        m_InGame_WalkLeft = m_InGame.FindAction("WalkLeft", throwIfNotFound: true);
        m_InGame_WalkUp = m_InGame.FindAction("WalkUp", throwIfNotFound: true);
        m_InGame_WalkDown = m_InGame.FindAction("WalkDown", throwIfNotFound: true);
        m_InGame_Interact = m_InGame.FindAction("Interact", throwIfNotFound: true);
        m_InGame_Complete = m_InGame.FindAction("Complete", throwIfNotFound: true);
        m_InGame_QuitGame = m_InGame.FindAction("QuitGame", throwIfNotFound: true);
        m_InGame_RandomizeNavigation = m_InGame.FindAction("RandomizeNavigation", throwIfNotFound: true);
        m_InGame_PickUp = m_InGame.FindAction("PickUp", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // InGame
    private readonly InputActionMap m_InGame;
    private List<IInGameActions> m_InGameActionsCallbackInterfaces = new List<IInGameActions>();
    private readonly InputAction m_InGame_WalkRight;
    private readonly InputAction m_InGame_WalkLeft;
    private readonly InputAction m_InGame_WalkUp;
    private readonly InputAction m_InGame_WalkDown;
    private readonly InputAction m_InGame_Interact;
    private readonly InputAction m_InGame_Complete;
    private readonly InputAction m_InGame_QuitGame;
    private readonly InputAction m_InGame_RandomizeNavigation;
    private readonly InputAction m_InGame_PickUp;
    public struct InGameActions
    {
        private @PlayerInput m_Wrapper;
        public InGameActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @WalkRight => m_Wrapper.m_InGame_WalkRight;
        public InputAction @WalkLeft => m_Wrapper.m_InGame_WalkLeft;
        public InputAction @WalkUp => m_Wrapper.m_InGame_WalkUp;
        public InputAction @WalkDown => m_Wrapper.m_InGame_WalkDown;
        public InputAction @Interact => m_Wrapper.m_InGame_Interact;
        public InputAction @Complete => m_Wrapper.m_InGame_Complete;
        public InputAction @QuitGame => m_Wrapper.m_InGame_QuitGame;
        public InputAction @RandomizeNavigation => m_Wrapper.m_InGame_RandomizeNavigation;
        public InputAction @PickUp => m_Wrapper.m_InGame_PickUp;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void AddCallbacks(IInGameActions instance)
        {
            if (instance == null || m_Wrapper.m_InGameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InGameActionsCallbackInterfaces.Add(instance);
            @WalkRight.started += instance.OnWalkRight;
            @WalkRight.performed += instance.OnWalkRight;
            @WalkRight.canceled += instance.OnWalkRight;
            @WalkLeft.started += instance.OnWalkLeft;
            @WalkLeft.performed += instance.OnWalkLeft;
            @WalkLeft.canceled += instance.OnWalkLeft;
            @WalkUp.started += instance.OnWalkUp;
            @WalkUp.performed += instance.OnWalkUp;
            @WalkUp.canceled += instance.OnWalkUp;
            @WalkDown.started += instance.OnWalkDown;
            @WalkDown.performed += instance.OnWalkDown;
            @WalkDown.canceled += instance.OnWalkDown;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Complete.started += instance.OnComplete;
            @Complete.performed += instance.OnComplete;
            @Complete.canceled += instance.OnComplete;
            @QuitGame.started += instance.OnQuitGame;
            @QuitGame.performed += instance.OnQuitGame;
            @QuitGame.canceled += instance.OnQuitGame;
            @RandomizeNavigation.started += instance.OnRandomizeNavigation;
            @RandomizeNavigation.performed += instance.OnRandomizeNavigation;
            @RandomizeNavigation.canceled += instance.OnRandomizeNavigation;
            @PickUp.started += instance.OnPickUp;
            @PickUp.performed += instance.OnPickUp;
            @PickUp.canceled += instance.OnPickUp;
        }

        private void UnregisterCallbacks(IInGameActions instance)
        {
            @WalkRight.started -= instance.OnWalkRight;
            @WalkRight.performed -= instance.OnWalkRight;
            @WalkRight.canceled -= instance.OnWalkRight;
            @WalkLeft.started -= instance.OnWalkLeft;
            @WalkLeft.performed -= instance.OnWalkLeft;
            @WalkLeft.canceled -= instance.OnWalkLeft;
            @WalkUp.started -= instance.OnWalkUp;
            @WalkUp.performed -= instance.OnWalkUp;
            @WalkUp.canceled -= instance.OnWalkUp;
            @WalkDown.started -= instance.OnWalkDown;
            @WalkDown.performed -= instance.OnWalkDown;
            @WalkDown.canceled -= instance.OnWalkDown;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Complete.started -= instance.OnComplete;
            @Complete.performed -= instance.OnComplete;
            @Complete.canceled -= instance.OnComplete;
            @QuitGame.started -= instance.OnQuitGame;
            @QuitGame.performed -= instance.OnQuitGame;
            @QuitGame.canceled -= instance.OnQuitGame;
            @RandomizeNavigation.started -= instance.OnRandomizeNavigation;
            @RandomizeNavigation.performed -= instance.OnRandomizeNavigation;
            @RandomizeNavigation.canceled -= instance.OnRandomizeNavigation;
            @PickUp.started -= instance.OnPickUp;
            @PickUp.performed -= instance.OnPickUp;
            @PickUp.canceled -= instance.OnPickUp;
        }

        public void RemoveCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInGameActions instance)
        {
            foreach (var item in m_Wrapper.m_InGameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InGameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IInGameActions
    {
        void OnWalkRight(InputAction.CallbackContext context);
        void OnWalkLeft(InputAction.CallbackContext context);
        void OnWalkUp(InputAction.CallbackContext context);
        void OnWalkDown(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnComplete(InputAction.CallbackContext context);
        void OnQuitGame(InputAction.CallbackContext context);
        void OnRandomizeNavigation(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
    }
}
