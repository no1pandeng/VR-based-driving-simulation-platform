// GENERATED AUTOMATICALLY FROM 'Assets/PlayerRoll.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Rolling : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Rolling()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerRoll"",
    ""maps"": [
        {
            ""name"": ""Roll"",
            ""id"": ""434f9d68-f827-47cb-8d6f-824a4e12afd2"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""25846361-e49b-409f-9d4a-ae6bb8981cf4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""f6241dfb-dd79-47c5-993d-95670e04b2a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""ceaaf0d3-c534-450f-bbbb-28b2c2dd8df3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate_Left"",
                    ""type"": ""Button"",
                    ""id"": ""79084ba1-bb80-4012-93da-acccb3c69e0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate_Right"",
                    ""type"": ""Button"",
                    ""id"": ""4bc08572-90a1-4ace-8df0-3e2d4558f3f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8cfcb513-1665-4194-9a3b-3590478311fa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9aa4ff52-e33a-4606-902b-a697ad76a190"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2d1201a-1764-4b1b-8ebf-acdb7ee3d48a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f259b210-8211-4576-9709-471258c092a4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""551f073e-bdd6-457d-a855-c4b4be1c64d8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb0a10bb-aa27-43ee-b678-e1ecb2691039"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""723e4c6a-2817-4330-8b87-c472ce2d33b1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e126e21b-ad3c-46ca-848c-8b9c34228900"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1fc91aa-2cc5-4558-bf06-53ba6830083a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Roll
        m_Roll = asset.FindActionMap("Roll", throwIfNotFound: true);
        m_Roll_Jump = m_Roll.FindAction("Jump", throwIfNotFound: true);
        m_Roll_Forward = m_Roll.FindAction("Forward", throwIfNotFound: true);
        m_Roll_Brake = m_Roll.FindAction("Brake", throwIfNotFound: true);
        m_Roll_Rotate_Left = m_Roll.FindAction("Rotate_Left", throwIfNotFound: true);
        m_Roll_Rotate_Right = m_Roll.FindAction("Rotate_Right", throwIfNotFound: true);
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

    // Roll
    private readonly InputActionMap m_Roll;
    private IRollActions m_RollActionsCallbackInterface;
    private readonly InputAction m_Roll_Jump;
    private readonly InputAction m_Roll_Forward;
    private readonly InputAction m_Roll_Brake;
    private readonly InputAction m_Roll_Rotate_Left;
    private readonly InputAction m_Roll_Rotate_Right;
    public struct RollActions
    {
        private @Rolling m_Wrapper;
        public RollActions(@Rolling wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Roll_Jump;
        public InputAction @Forward => m_Wrapper.m_Roll_Forward;
        public InputAction @Brake => m_Wrapper.m_Roll_Brake;
        public InputAction @Rotate_Left => m_Wrapper.m_Roll_Rotate_Left;
        public InputAction @Rotate_Right => m_Wrapper.m_Roll_Rotate_Right;
        public InputActionMap Get() { return m_Wrapper.m_Roll; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RollActions set) { return set.Get(); }
        public void SetCallbacks(IRollActions instance)
        {
            if (m_Wrapper.m_RollActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_RollActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_RollActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_RollActionsCallbackInterface.OnJump;
                @Forward.started -= m_Wrapper.m_RollActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_RollActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_RollActionsCallbackInterface.OnForward;
                @Brake.started -= m_Wrapper.m_RollActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_RollActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_RollActionsCallbackInterface.OnBrake;
                @Rotate_Left.started -= m_Wrapper.m_RollActionsCallbackInterface.OnRotate_Left;
                @Rotate_Left.performed -= m_Wrapper.m_RollActionsCallbackInterface.OnRotate_Left;
                @Rotate_Left.canceled -= m_Wrapper.m_RollActionsCallbackInterface.OnRotate_Left;
                @Rotate_Right.started -= m_Wrapper.m_RollActionsCallbackInterface.OnRotate_Right;
                @Rotate_Right.performed -= m_Wrapper.m_RollActionsCallbackInterface.OnRotate_Right;
                @Rotate_Right.canceled -= m_Wrapper.m_RollActionsCallbackInterface.OnRotate_Right;
            }
            m_Wrapper.m_RollActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Rotate_Left.started += instance.OnRotate_Left;
                @Rotate_Left.performed += instance.OnRotate_Left;
                @Rotate_Left.canceled += instance.OnRotate_Left;
                @Rotate_Right.started += instance.OnRotate_Right;
                @Rotate_Right.performed += instance.OnRotate_Right;
                @Rotate_Right.canceled += instance.OnRotate_Right;
            }
        }
    }
    public RollActions @Roll => new RollActions(this);
    public interface IRollActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnRotate_Left(InputAction.CallbackContext context);
        void OnRotate_Right(InputAction.CallbackContext context);
    }
}
