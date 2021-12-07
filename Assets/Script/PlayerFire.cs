// GENERATED AUTOMATICALLY FROM 'Assets/Script/PlayerFire.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerFire : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerFire()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerFire"",
    ""maps"": [
        {
            ""name"": ""Attack"",
            ""id"": ""86f9d1b9-3bb8-4486-b844-f0298bbf2aef"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""8fddbe65-5227-4092-b77f-137c978145a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cac"",
                    ""type"": ""Button"",
                    ""id"": ""fda645e4-e752-4f6c-bf10-ce8510c71318"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49b6e217-3bca-4992-9756-3ee9e1e2433d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""745b432a-6473-490f-9c08-c26d7d3cfa46"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cac"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Attack
        m_Attack = asset.FindActionMap("Attack", throwIfNotFound: true);
        m_Attack_Fire = m_Attack.FindAction("Fire", throwIfNotFound: true);
        m_Attack_Cac = m_Attack.FindAction("Cac", throwIfNotFound: true);
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

    // Attack
    private readonly InputActionMap m_Attack;
    private IAttackActions m_AttackActionsCallbackInterface;
    private readonly InputAction m_Attack_Fire;
    private readonly InputAction m_Attack_Cac;
    public struct AttackActions
    {
        private @PlayerFire m_Wrapper;
        public AttackActions(@PlayerFire wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Attack_Fire;
        public InputAction @Cac => m_Wrapper.m_Attack_Cac;
        public InputActionMap Get() { return m_Wrapper.m_Attack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
        public void SetCallbacks(IAttackActions instance)
        {
            if (m_Wrapper.m_AttackActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnFire;
                @Cac.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnCac;
                @Cac.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnCac;
                @Cac.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnCac;
            }
            m_Wrapper.m_AttackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Cac.started += instance.OnCac;
                @Cac.performed += instance.OnCac;
                @Cac.canceled += instance.OnCac;
            }
        }
    }
    public AttackActions @Attack => new AttackActions(this);
    public interface IAttackActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnCac(InputAction.CallbackContext context);
    }
}
