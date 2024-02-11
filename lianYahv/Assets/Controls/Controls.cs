//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Controls/Controls.inputactions
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

public partial class @Controls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Girl_Controls"",
            ""id"": ""6669813e-6b48-4899-9d50-7c6e3b36e46c"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""d459fcfa-9a0f-4dce-9c28-44c575fb95c7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9e74e0df-55dc-45b1-9338-9ac65b2bb0d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""97fbca63-20da-4099-90fb-1523f4cef116"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d6da105d-2b0e-421e-b639-ba18b757e56c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""54ad8ca2-da9b-4b7c-95f4-818d29e7cc52"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""521f4b74-04ac-4691-b3dc-4dbcfd2bff37"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Cat_Controls"",
            ""id"": ""23b4ee43-446c-4b1c-8f47-ea76dd95aa76"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cf1391b8-2bf0-4fe5-a3ec-ac8716d2ce3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""f5ca8bc9-ba7c-475e-b7da-0e43e7f138b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f247491a-63df-49d1-8662-c75acf2b3978"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1058f953-4b70-4d3b-bef4-1c8e5422595a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f5dbadb1-afde-4045-980e-91e23f643ed8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""58fb5752-72e3-4d2c-8c7c-f72c6c5aa6f8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Girl_Controls
        m_Girl_Controls = asset.FindActionMap("Girl_Controls", throwIfNotFound: true);
        m_Girl_Controls_Horizontal = m_Girl_Controls.FindAction("Horizontal", throwIfNotFound: true);
        m_Girl_Controls_Jump = m_Girl_Controls.FindAction("Jump", throwIfNotFound: true);
        // Cat_Controls
        m_Cat_Controls = asset.FindActionMap("Cat_Controls", throwIfNotFound: true);
        m_Cat_Controls_Jump = m_Cat_Controls.FindAction("Jump", throwIfNotFound: true);
        m_Cat_Controls_Move = m_Cat_Controls.FindAction("Move", throwIfNotFound: true);
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

    // Girl_Controls
    private readonly InputActionMap m_Girl_Controls;
    private IGirl_ControlsActions m_Girl_ControlsActionsCallbackInterface;
    private readonly InputAction m_Girl_Controls_Horizontal;
    private readonly InputAction m_Girl_Controls_Jump;
    public struct Girl_ControlsActions
    {
        private @Controls m_Wrapper;
        public Girl_ControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Girl_Controls_Horizontal;
        public InputAction @Jump => m_Wrapper.m_Girl_Controls_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Girl_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Girl_ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGirl_ControlsActions instance)
        {
            if (m_Wrapper.m_Girl_ControlsActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_Girl_ControlsActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_Girl_ControlsActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_Girl_ControlsActionsCallbackInterface.OnHorizontal;
                @Jump.started -= m_Wrapper.m_Girl_ControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Girl_ControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Girl_ControlsActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Girl_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public Girl_ControlsActions @Girl_Controls => new Girl_ControlsActions(this);

    // Cat_Controls
    private readonly InputActionMap m_Cat_Controls;
    private ICat_ControlsActions m_Cat_ControlsActionsCallbackInterface;
    private readonly InputAction m_Cat_Controls_Jump;
    private readonly InputAction m_Cat_Controls_Move;
    public struct Cat_ControlsActions
    {
        private @Controls m_Wrapper;
        public Cat_ControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Cat_Controls_Jump;
        public InputAction @Move => m_Wrapper.m_Cat_Controls_Move;
        public InputActionMap Get() { return m_Wrapper.m_Cat_Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Cat_ControlsActions set) { return set.Get(); }
        public void SetCallbacks(ICat_ControlsActions instance)
        {
            if (m_Wrapper.m_Cat_ControlsActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_Cat_ControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Cat_ControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Cat_ControlsActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_Cat_ControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Cat_ControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Cat_ControlsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Cat_ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public Cat_ControlsActions @Cat_Controls => new Cat_ControlsActions(this);
    public interface IGirl_ControlsActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ICat_ControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
