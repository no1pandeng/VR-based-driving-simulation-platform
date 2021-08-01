// GENERATED AUTOMATICALLY FROM 'Assets/PlayerAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAction"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""e1c38dfc-3429-47f2-a562-22b20c1bde76"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""57ab921f-c254-4a3d-a924-a0c8805a0992"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Button"",
                    ""id"": ""9bc6fd79-748b-4eb3-a466-56b5b5204955"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn_Left"",
                    ""type"": ""Button"",
                    ""id"": ""35a29417-20a3-4025-894a-d0c49d210432"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn_Right"",
                    ""type"": ""Button"",
                    ""id"": ""412407e1-cadb-4e13-ac51-faed90e1d1f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c35230ed-656d-46e9-adda-e7d62647216e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f6f2aa3-ef7b-4c8f-b0dc-be5f7b436790"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6153be8a-e002-4cbe-98f0-14831f8d3664"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4810208c-e169-4157-9546-6e0dea110378"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Manager"",
            ""id"": ""ddf928a6-d547-44d1-9087-409026596a0e"",
            ""actions"": [
                {
                    ""name"": ""GuideAgent"",
                    ""type"": ""Button"",
                    ""id"": ""b974513e-c632-4cda-a474-6a9093f6bef7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""70d7622e-c13d-457b-bbe9-1bd7ebd256a4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GuideAgent"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Horizontal = m_Driving.FindAction("Horizontal", throwIfNotFound: true);
        m_Driving_Break = m_Driving.FindAction("Break", throwIfNotFound: true);
        m_Driving_Turn_Left = m_Driving.FindAction("Turn_Left", throwIfNotFound: true);
        m_Driving_Turn_Right = m_Driving.FindAction("Turn_Right", throwIfNotFound: true);
        // Manager
        m_Manager = asset.FindActionMap("Manager", throwIfNotFound: true);
        m_Manager_GuideAgent = m_Manager.FindAction("GuideAgent", throwIfNotFound: true);
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

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Horizontal;
    private readonly InputAction m_Driving_Break;
    private readonly InputAction m_Driving_Turn_Left;
    private readonly InputAction m_Driving_Turn_Right;
    public struct DrivingActions
    {
        private @PlayerAction m_Wrapper;
        public DrivingActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Driving_Horizontal;
        public InputAction @Break => m_Wrapper.m_Driving_Break;
        public InputAction @Turn_Left => m_Wrapper.m_Driving_Turn_Left;
        public InputAction @Turn_Right => m_Wrapper.m_Driving_Turn_Right;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHorizontal;
                @Break.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBreak;
                @Turn_Left.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurn_Left;
                @Turn_Left.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurn_Left;
                @Turn_Left.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurn_Left;
                @Turn_Right.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurn_Right;
                @Turn_Right.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurn_Right;
                @Turn_Right.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurn_Right;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @Turn_Left.started += instance.OnTurn_Left;
                @Turn_Left.performed += instance.OnTurn_Left;
                @Turn_Left.canceled += instance.OnTurn_Left;
                @Turn_Right.started += instance.OnTurn_Right;
                @Turn_Right.performed += instance.OnTurn_Right;
                @Turn_Right.canceled += instance.OnTurn_Right;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);

    // Manager
    private readonly InputActionMap m_Manager;
    private IManagerActions m_ManagerActionsCallbackInterface;
    private readonly InputAction m_Manager_GuideAgent;
    public struct ManagerActions
    {
        private @PlayerAction m_Wrapper;
        public ManagerActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @GuideAgent => m_Wrapper.m_Manager_GuideAgent;
        public InputActionMap Get() { return m_Wrapper.m_Manager; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ManagerActions set) { return set.Get(); }
        public void SetCallbacks(IManagerActions instance)
        {
            if (m_Wrapper.m_ManagerActionsCallbackInterface != null)
            {
                @GuideAgent.started -= m_Wrapper.m_ManagerActionsCallbackInterface.OnGuideAgent;
                @GuideAgent.performed -= m_Wrapper.m_ManagerActionsCallbackInterface.OnGuideAgent;
                @GuideAgent.canceled -= m_Wrapper.m_ManagerActionsCallbackInterface.OnGuideAgent;
            }
            m_Wrapper.m_ManagerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GuideAgent.started += instance.OnGuideAgent;
                @GuideAgent.performed += instance.OnGuideAgent;
                @GuideAgent.canceled += instance.OnGuideAgent;
            }
        }
    }
    public ManagerActions @Manager => new ManagerActions(this);
    public interface IDrivingActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnTurn_Left(InputAction.CallbackContext context);
        void OnTurn_Right(InputAction.CallbackContext context);
    }
    public interface IManagerActions
    {
        void OnGuideAgent(InputAction.CallbackContext context);
    }
}
