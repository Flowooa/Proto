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
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""bb4728e2-5644-44d9-9a48-771285de9be0"",
                    ""expectedControlType"": ""Button"",
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
                    ""groups"": ""keyboard"",
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
                    ""groups"": ""keyboard"",
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
                    ""groups"": ""keyboard"",
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
                    ""groups"": ""keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b2ad4741-b9b8-44a9-ae71-99cdbe5b1429"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ec16d66-a172-4546-924b-09a094c0699c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pause"",
            ""id"": ""b06c97e4-3ef7-4886-90a8-1f30c47cf903"",
            ""actions"": [
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""41fd406b-2c12-47c3-b4db-f2b3cb75de02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9ee945de-275b-4020-887f-7279e8f5125b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""controller"",
            ""bindingGroup"": ""controller"",
            ""devices"": []
        },
        {
            ""name"": ""keyboard"",
            ""bindingGroup"": ""keyboard"",
            ""devices"": []
        }
    ]
}");
        // Mouvement
        m_Mouvement = asset.FindActionMap("Mouvement", throwIfNotFound: true);
        m_Mouvement_Move = m_Mouvement.FindAction("Move", throwIfNotFound: true);
        m_Mouvement_Shoot = m_Mouvement.FindAction("Shoot", throwIfNotFound: true);
        // Pause
        m_Pause = asset.FindActionMap("Pause", throwIfNotFound: true);
        m_Pause_pause = m_Pause.FindAction("pause", throwIfNotFound: true);
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
    private readonly InputAction m_Mouvement_Shoot;
    public struct MouvementActions
    {
        private @PlayerInputAction m_Wrapper;
        public MouvementActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Mouvement_Move;
        public InputAction @Shoot => m_Wrapper.m_Mouvement_Shoot;
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
                @Shoot.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_MouvementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public MouvementActions @Mouvement => new MouvementActions(this);

    // Pause
    private readonly InputActionMap m_Pause;
    private IPauseActions m_PauseActionsCallbackInterface;
    private readonly InputAction m_Pause_pause;
    public struct PauseActions
    {
        private @PlayerInputAction m_Wrapper;
        public PauseActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @pause => m_Wrapper.m_Pause_pause;
        public InputActionMap Get() { return m_Wrapper.m_Pause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseActions set) { return set.Get(); }
        public void SetCallbacks(IPauseActions instance)
        {
            if (m_Wrapper.m_PauseActionsCallbackInterface != null)
            {
                @pause.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
            }
        }
    }
    public PauseActions @Pause => new PauseActions(this);
    private int m_controllerSchemeIndex = -1;
    public InputControlScheme controllerScheme
    {
        get
        {
            if (m_controllerSchemeIndex == -1) m_controllerSchemeIndex = asset.FindControlSchemeIndex("controller");
            return asset.controlSchemes[m_controllerSchemeIndex];
        }
    }
    private int m_keyboardSchemeIndex = -1;
    public InputControlScheme keyboardScheme
    {
        get
        {
            if (m_keyboardSchemeIndex == -1) m_keyboardSchemeIndex = asset.FindControlSchemeIndex("keyboard");
            return asset.controlSchemes[m_keyboardSchemeIndex];
        }
    }
    public interface IMouvementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IPauseActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
