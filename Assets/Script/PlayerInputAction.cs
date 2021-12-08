// GENERATED AUTOMATICALLY FROM 'Assets/Script/PlayerInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""Mouvement"",
            ""id"": ""9dc013f5-8625-4709-95b5-1ceb33156054"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b55722e9-a90a-4e02-a986-9938cace5f70"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""c344f327-e686-4283-8bfe-a5a3ae85f670"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""259beab2-6ede-436b-8fcd-a038d5bcc2d1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cd50f2e1-c7bc-47f6-b154-5993e5cd918a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""36eb2b49-335f-4be7-ae6a-0f5568630c38"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5e9ed84c-3e74-47d3-9d7c-30c95ee04945"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Fire"",
            ""id"": ""2bb3d578-76de-425c-aa0e-7bc82f7d5a1e"",
            ""actions"": [
                {
                    ""name"": ""Bim"",
                    ""type"": ""Button"",
                    ""id"": ""b7be14f1-47c6-42e1-a4ce-b0b910b15c6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""55544e34-29d2-438a-8c9a-6427b493cc44"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouvement
        m_Mouvement = asset.FindActionMap("Mouvement", throwIfNotFound: true);
        m_Mouvement_Move = m_Mouvement.FindAction("Move", throwIfNotFound: true);
        // Fire
        m_Fire = asset.FindActionMap("Fire", throwIfNotFound: true);
        m_Fire_Bim = m_Fire.FindAction("Bim", throwIfNotFound: true);
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

    // Mouvement
    private readonly InputActionMap m_Mouvement;
    private IMouvementActions m_MouvementActionsCallbackInterface;
    private readonly InputAction m_Mouvement_Move;
    public struct MouvementActions
    {
        private @PlayerInputAction m_Wrapper;
        public MouvementActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Mouvement_Move;
        public InputActionMap Get() { return m_Wrapper.m_Mouvement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouvementActions set) { return set.Get(); }
        public void SetCallbacks(IMouvementActions instance)
        {
            if (m_Wrapper.m_MouvementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_MouvementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public MouvementActions @Mouvement => new MouvementActions(this);

    // Fire
    private readonly InputActionMap m_Fire;
    private IFireActions m_FireActionsCallbackInterface;
    private readonly InputAction m_Fire_Bim;
    public struct FireActions
    {
        private @PlayerInputAction m_Wrapper;
        public FireActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bim => m_Wrapper.m_Fire_Bim;
        public InputActionMap Get() { return m_Wrapper.m_Fire; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FireActions set) { return set.Get(); }
        public void SetCallbacks(IFireActions instance)
        {
            if (m_Wrapper.m_FireActionsCallbackInterface != null)
            {
                @Bim.started -= m_Wrapper.m_FireActionsCallbackInterface.OnBim;
                @Bim.performed -= m_Wrapper.m_FireActionsCallbackInterface.OnBim;
                @Bim.canceled -= m_Wrapper.m_FireActionsCallbackInterface.OnBim;
            }
            m_Wrapper.m_FireActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bim.started += instance.OnBim;
                @Bim.performed += instance.OnBim;
                @Bim.canceled += instance.OnBim;
            }
        }
    }
    public FireActions @Fire => new FireActions(this);
    public interface IMouvementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IFireActions
    {
        void OnBim(InputAction.CallbackContext context);
    }
}
