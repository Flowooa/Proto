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
                    ""name"": ""Deplacement"",
                    ""type"": ""PassThrough"",
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
                    ""action"": ""Deplacement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f962b1a7-3929-4d3c-9b64-0554ea1afc17"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""14b195c4-3b1a-4532-8b53-0b28cfb51fb3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5e551c30-e882-400c-bcfb-9cf2b8826a2c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fd993e4b-ce16-4ef2-8e04-9a01a5b035d1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2e304020-7d61-4ae4-a4dd-2d7cb7e9f71c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5f058c8-8091-4674-a19a-52a9bf8a5f23"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""235662ea-da13-493a-ad05-cb93cc7bfa8a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""287d32fd-18cb-4838-93bc-3cc759d286df"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
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
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98e6eaef-bcce-4ac2-b7ea-fc05082c9414"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""586778e3-accd-493f-acb0-dca6616dad93"",
                    ""path"": ""<XInputController>/start"",
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
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BackShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0816338-6b84-4ff4-b97b-2d7f6ef699af"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
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
                    ""name"": ""BackShoot"",
                    ""type"": ""Button"",
                    ""id"": ""b20e0942-5075-4a47-a7af-01cea3f487ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""6e3c5049-96ee-4421-a207-44d12f7d6131"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""90654dde-1b4c-48c0-801d-c7fe546dfe86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Deplacement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""76b71d3b-5c6d-4de6-af99-f5dcb52536f9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2601083b-e70a-4b53-8d30-913351228ab4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Deplacement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d4aeca60-450f-441f-81cc-ef66b4b1051d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c5e9f9b6-2a69-46ce-882b-aa5ec9757d6c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""138974ff-a15e-4f7d-9cfa-e05585d0a350"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3779f00b-05d4-4783-9486-458e8d1655a4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""59536ecb-ab57-4f35-9535-7790495f86fe"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aed393af-801a-4dca-bc02-d4cbc7383381"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Deplacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6509a98-251a-4697-9393-ae51f613f10d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13fd19e8-b936-49a3-83d6-c2be71170217"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40756ea2-83c9-44ef-bffd-f3cb7cc2bbc6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29ae2cd9-3340-4307-8fa2-4b7a64ae06ed"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0193b944-5c10-4b36-8111-69a231c84109"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7e0edfb-d95d-41cc-b341-4ddcf09a1d0f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BackShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""560a9ca4-8de6-48b1-a79a-8070e89518e8"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BackShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Deplacement = m_Player.FindAction("Deplacement", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_BackShoot = m_Player.FindAction("BackShoot", throwIfNotFound: true);
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_BackShoot = m_Player1.FindAction("BackShoot", throwIfNotFound: true);
        m_Player1_Pause = m_Player1.FindAction("Pause", throwIfNotFound: true);
        m_Player1_Shoot = m_Player1.FindAction("Shoot", throwIfNotFound: true);
        m_Player1_Deplacement = m_Player1.FindAction("Deplacement", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Deplacement;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_BackShoot;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Deplacement => m_Wrapper.m_Player_Deplacement;
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
                @Deplacement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeplacement;
                @Deplacement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeplacement;
                @Deplacement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDeplacement;
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
                @Deplacement.started += instance.OnDeplacement;
                @Deplacement.performed += instance.OnDeplacement;
                @Deplacement.canceled += instance.OnDeplacement;
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
    private readonly InputAction m_Player1_BackShoot;
    private readonly InputAction m_Player1_Pause;
    private readonly InputAction m_Player1_Shoot;
    private readonly InputAction m_Player1_Deplacement;
    public struct Player1Actions
    {
        private @PlayerInput m_Wrapper;
        public Player1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @BackShoot => m_Wrapper.m_Player1_BackShoot;
        public InputAction @Pause => m_Wrapper.m_Player1_Pause;
        public InputAction @Shoot => m_Wrapper.m_Player1_Shoot;
        public InputAction @Deplacement => m_Wrapper.m_Player1_Deplacement;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @BackShoot.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBackShoot;
                @BackShoot.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBackShoot;
                @BackShoot.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBackShoot;
                @Pause.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Shoot.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @Deplacement.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDeplacement;
                @Deplacement.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDeplacement;
                @Deplacement.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDeplacement;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BackShoot.started += instance.OnBackShoot;
                @BackShoot.performed += instance.OnBackShoot;
                @BackShoot.canceled += instance.OnBackShoot;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Deplacement.started += instance.OnDeplacement;
                @Deplacement.performed += instance.OnDeplacement;
                @Deplacement.canceled += instance.OnDeplacement;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnDeplacement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnBackShoot(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnBackShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDeplacement(InputAction.CallbackContext context);
    }
}
