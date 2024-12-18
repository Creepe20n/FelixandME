//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Me Scrips/Player/Movement/LinksRechts.inputactions
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

public partial class @LinksRechts: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @LinksRechts()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""LinksRechts"",
    ""maps"": [
        {
            ""name"": ""AD"",
            ""id"": ""ea015e99-fa00-4f13-bbd8-18acad26a8a1"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""382731c5-ec6e-4631-8b43-9f25811d9387"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""da9d1f20-3563-4fbe-b46c-b7cddd06f7d6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""24024605-d1f3-4e1d-9b2e-2cd0f062013c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2c7c2af3-255f-471f-9dce-3c8d7ab6217a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9f655d33-cd98-4bd9-872a-d6e00b976a0b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c891a3d0-5570-4800-8d26-dd6f3c9e0059"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""99a2b903-5ced-4650-a569-d4a7ba845199"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ef66484d-e06f-4fa1-90a6-fe651bd626ed"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Shoot"",
            ""id"": ""59654df4-ef28-443c-a8ed-0e1c56b7d90b"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""1e1b2bf7-9a3b-413a-8911-301a220f0431"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5a06891c-1e90-4781-8e7c-2850fd6d9d5f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // AD
        m_AD = asset.FindActionMap("AD", throwIfNotFound: true);
        m_AD_movement = m_AD.FindAction("movement", throwIfNotFound: true);
        // Shoot
        m_Shoot = asset.FindActionMap("Shoot", throwIfNotFound: true);
        m_Shoot_Newaction = m_Shoot.FindAction("New action", throwIfNotFound: true);
    }

    ~@LinksRechts()
    {
        UnityEngine.Debug.Assert(!m_AD.enabled, "This will cause a leak and performance issues, LinksRechts.AD.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_Shoot.enabled, "This will cause a leak and performance issues, LinksRechts.Shoot.Disable() has not been called.");
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

    // AD
    private readonly InputActionMap m_AD;
    private List<IADActions> m_ADActionsCallbackInterfaces = new List<IADActions>();
    private readonly InputAction m_AD_movement;
    public struct ADActions
    {
        private @LinksRechts m_Wrapper;
        public ADActions(@LinksRechts wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_AD_movement;
        public InputActionMap Get() { return m_Wrapper.m_AD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ADActions set) { return set.Get(); }
        public void AddCallbacks(IADActions instance)
        {
            if (instance == null || m_Wrapper.m_ADActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ADActionsCallbackInterfaces.Add(instance);
            @movement.started += instance.OnMovement;
            @movement.performed += instance.OnMovement;
            @movement.canceled += instance.OnMovement;
        }

        private void UnregisterCallbacks(IADActions instance)
        {
            @movement.started -= instance.OnMovement;
            @movement.performed -= instance.OnMovement;
            @movement.canceled -= instance.OnMovement;
        }

        public void RemoveCallbacks(IADActions instance)
        {
            if (m_Wrapper.m_ADActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IADActions instance)
        {
            foreach (var item in m_Wrapper.m_ADActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ADActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ADActions @AD => new ADActions(this);

    // Shoot
    private readonly InputActionMap m_Shoot;
    private List<IShootActions> m_ShootActionsCallbackInterfaces = new List<IShootActions>();
    private readonly InputAction m_Shoot_Newaction;
    public struct ShootActions
    {
        private @LinksRechts m_Wrapper;
        public ShootActions(@LinksRechts wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Shoot_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Shoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShootActions set) { return set.Get(); }
        public void AddCallbacks(IShootActions instance)
        {
            if (instance == null || m_Wrapper.m_ShootActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ShootActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IShootActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IShootActions instance)
        {
            if (m_Wrapper.m_ShootActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IShootActions instance)
        {
            foreach (var item in m_Wrapper.m_ShootActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ShootActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ShootActions @Shoot => new ShootActions(this);
    public interface IADActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IShootActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
