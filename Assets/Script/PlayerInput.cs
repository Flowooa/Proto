// GENERATED AUTOMATICALLY FROM 'Assets/Script/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""af1852e3-c7dd-4ef0-b385-0f4277e7cb9b"",
            ""actions"": [
                {
                    ""name"": ""Déplacement"",
                    ""type"": ""Value"",
                    ""id"": ""6dce7dd6-5948-43c6-a03f-573aaf8b2c0c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""14936642-0d02-4a7d-b52c-0b5b52889dd1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""feb70705-db25-4e8f-9e4b-58a7a94573dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackShoot"",
                    ""type"": ""Button"",
                    ""id"": ""8368cf1e-5216-4b49-ba4d-2ecf1b8370a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ede15ec8-8ae0-4e06-9fef-ecc434ee0e08"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f962b1a7-3929-4d3c-9b64-0554ea1afc17"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""14b195c4-3b1a-4532-8b53-0b28cfb51fb3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5e551c30-e882-400c-bcfb-9cf2b8826a2c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fd993e4b-ce16-4ef2-8e04-9a01a5b035d1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""235662ea-da13-493a-ad05-cb93cc7bfa8a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cc30783-3450-4a47-ba19-a15c780a6d93"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c1394e2-2bc6-4772-b6e6-9c00226973d4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player1"",
            ""id"": ""b73c811c-368a-46d8-bc57-de2cce0b0507"",
            ""actions"": [
                {
                    ""name"": ""Déplacement"",
                    ""type"": ""Value"",
                    ""id"": ""1b72f712-ff5c-41b4-b5de-3d57c0c65ae8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""6095ba9c-dc8b-4709-aae1-bf01ab02ae3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""659d0f6f-a538-4b3e-8fc1-549f73f22d4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackShoot"",
                    ""type"": ""Button"",
                    ""id"": ""df5bdb68-82c1-438a-a100-2e94643af896"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""41bd5401-027b-48a3-ad84-e905f1571901"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3a29a7e6-5fae-4de0-b406-de54fe564a24"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""103bf49a-012e-462c-a08c-64929e8871b1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2429056d-72f7-47bf-be29-4837d87c6e86"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ab283b10-54aa-4299-85cd-c1d4051887d1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Déplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6c051bb9-c120-41ec-9d8f-06f949b7c2c0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9979f372-073d-435d-8d59-e505a2b21810"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6680d2a5-c7b1-4b4c-8c7a-64f743b1368e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Déplacement = m_Player.FindAction("Déplacement", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_BackShoot = m_Player.FindAction("BackShoot", throwIfNotFound: true);
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Déplacement = m_Player1.FindAction("Déplacement", throwIfNotFound: true);
        m_Player1_Shoot = m_Player1.FindAction("Shoot", throwIfNotFound: true);
        m_Player1_Pause = m_Player1.FindAction("Pause", throwIfNotFound: true);
        m_Player1_BackShoot = m_Player1.FindAction("BackShoot", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Déplacement;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_BackShoot;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Déplacement => m_Wrapper.m_Player_Déplacement;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputAction @BackShoot => m_Wrapper.m_Player_BackShoot;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Déplacement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDéplacement;
                @Déplacement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDéplacement;
                @Déplacement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDéplacement;
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @BackShoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackShoot;
                @BackShoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackShoot;
                @BackShoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackShoot;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Déplacement.started += instance.OnDéplacement;
                @Déplacement.performed += instance.OnDéplacement;
                @Déplacement.canceled += instance.OnDéplacement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @BackShoot.started += instance.OnBackShoot;
                @BackShoot.performed += instance.OnBackShoot;
                @BackShoot.canceled += instance.OnBackShoot;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Déplacement;
    private readonly InputAction m_Player1_Shoot;
    private readonly InputAction m_Player1_Pause;
    private readonly InputAction m_Player1_BackShoot;
    public struct Player1Actions
    {
        private @PlayerInput m_Wrapper;
        public Player1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Déplacement => m_Wrapper.m_Player1_Déplacement;
        public InputAction @Shoot => m_Wrapper.m_Player1_Shoot;
        public InputAction @Pause => m_Wrapper.m_Player1_Pause;
        public InputAction @BackShoot => m_Wrapper.m_Player1_BackShoot;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Déplacement.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDéplacement;
                @Déplacement.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDéplacement;
                @Déplacement.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDéplacement;
                @Shoot.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @Pause.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @BackShoot.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBackShoot;
                @BackShoot.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBackShoot;
                @BackShoot.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBackShoot;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Déplacement.started += instance.OnDéplacement;
                @Déplacement.performed += instance.OnDéplacement;
                @Déplacement.canceled += instance.OnDéplacement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @BackShoot.started += instance.OnBackShoot;
                @BackShoot.performed += instance.OnBackShoot;
                @BackShoot.canceled += instance.OnBackShoot;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    public interface IPlayerActions
    {
        void OnDéplacement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnBackShoot(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnDéplacement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnBackShoot(InputAction.CallbackContext context);
    }
}
