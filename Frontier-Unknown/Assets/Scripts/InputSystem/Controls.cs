// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSystem/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""2cae7eb3-e802-4af2-b383-60030d21985e"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c32368c9-0f93-4fd1-ab9d-f79fc744eef2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""974377f5-0d42-4dfe-bbea-54cf85b09a9b"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""d6baa373-84ce-4c4d-9948-45f839b49837"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchTool"",
                    ""type"": ""Value"",
                    ""id"": ""0aa5721e-2524-446c-985b-39f9ce7e0bc3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Chat"",
                    ""type"": ""Button"",
                    ""id"": ""57212478-97aa-4f94-9d18-790c2a9798a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""f51e2501-173b-4ac2-bb30-3c612c253fcc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""7e35aec1-d6dd-4624-8df7-893f856e2436"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""27abfd9f-a53d-4b42-a2fc-58fb6b99f8e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""93082b38-bf17-4d71-a54f-a133fd1b7871"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2ea72787-f7d9-497a-8616-0b1c5f823b3b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6fc6f245-63bf-48e8-b389-23f1a798e791"",
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
                    ""id"": ""57823119-819f-4c64-89c0-e195973924e6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eda9e268-0685-45d2-a437-9db8efc092b4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""75c07f78-0cbd-4f7c-a27c-e51e67b0c227"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c9a2790e-910d-4187-8c6e-9857d2afe7e0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""90bab6f7-5db7-48a5-be5e-99fa8eb72091"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b530807-2bbd-433f-ae2e-0d6be084765f"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SwitchTool"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd7557db-a83f-46e8-adec-26615fd78b68"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Chat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8182c36-1645-4919-8bbc-0edca39324f2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e00820ac-5040-498a-a776-7b62aec1d7cc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""039e7766-dfcf-431e-9cc3-36ededfc9c1e"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""310fce61-b418-4cf6-97c0-828e84b15e4f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ShipFlight"",
            ""id"": ""914921b6-127c-448a-b0f4-c061434ace0a"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""9327636e-7a68-4eb1-8b5b-c3b90d07ea17"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""d89af4d0-621d-4ce2-9f41-3cbaaaa49296"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""6bcdcc92-5efb-471c-a68b-3ae183cc7a00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""e0bb913b-c1ea-4250-b389-b4e7804d0d9e"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""35fdfb4e-a37c-4af5-bcb1-366c28e3dd73"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hover"",
                    ""type"": ""Value"",
                    ""id"": ""208e97cb-39f9-4c24-b56c-98775fd2f1cf"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""729b2644-19b8-459b-b0f9-f162191d2893"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": ""Clamp(min=-1,max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""ccca0351-5e91-4cb1-879f-e3af4f8840a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireL"",
                    ""type"": ""Button"",
                    ""id"": ""11f19008-f15b-41f0-b661-ac4ba1ca628b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireR"",
                    ""type"": ""Button"",
                    ""id"": ""d73c7350-ee88-45f8-aa73-8018b0a71007"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""QE"",
                    ""id"": ""29d6c63d-a4c2-4d02-817b-64838d1a4aae"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5b6eb36a-cfbd-4a26-b675-ad7851176f6f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""42b79983-bc84-4c0e-8003-8e157c70222f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ShiftSpace"",
                    ""id"": ""f96b20f3-5561-4177-ac34-8d183dfc55d4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hover"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bca96a48-9338-4a03-9844-2c9d3693ce8b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Hover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dc9241a8-8c67-4f4c-94cd-0a05909da9b0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Hover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a05cecee-35dc-4b8f-bb29-1b3ee8e400f9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""91c173df-65df-4724-8dd5-31a044146271"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3b6ea5f4-3c38-41e6-aa09-e46abc656645"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fba6be42-151f-42f2-8072-8fe468d719a5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e4d7e7ea-bfac-469a-9de9-538966c4b8fb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ca479fea-ad9f-4264-8bde-da82302747fc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b8a76fce-db2d-435c-ba3e-66c285d821b8"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ffed63d-6eae-4f7b-941c-e3b1ad156b7a"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1447d24-ce6d-475a-915a-07cff145ba71"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""FireL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""718abc29-26b8-4fec-8ef5-21152c741fd6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcbba014-484d-4560-8299-534728b483c3"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce0db161-9f54-46bc-896d-fe8581e55d09"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""FireR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Turret"",
            ""id"": ""874f04e2-d5af-4d1b-88bd-87a1166f5d92"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bb754d6f-4a34-4582-b0bb-c4441b690943"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""88c3eed1-c33c-40f3-ae15-1d8b2f218edc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dee19a0a-e843-4cef-9f70-f41f54439bba"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ff3b116-5766-41e2-be7b-d5834bc01e61"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_SwitchTool = m_Player.FindAction("SwitchTool", throwIfNotFound: true);
        m_Player_Chat = m_Player.FindAction("Chat", throwIfNotFound: true);
        m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Reload = m_Player.FindAction("Reload", throwIfNotFound: true);
        // ShipFlight
        m_ShipFlight = asset.FindActionMap("ShipFlight", throwIfNotFound: true);
        m_ShipFlight_Look = m_ShipFlight.FindAction("Look", throwIfNotFound: true);
        m_ShipFlight_Reload = m_ShipFlight.FindAction("Reload", throwIfNotFound: true);
        m_ShipFlight_Menu = m_ShipFlight.FindAction("Menu", throwIfNotFound: true);
        m_ShipFlight_Accelerate = m_ShipFlight.FindAction("Accelerate", throwIfNotFound: true);
        m_ShipFlight_Roll = m_ShipFlight.FindAction("Roll", throwIfNotFound: true);
        m_ShipFlight_Hover = m_ShipFlight.FindAction("Hover", throwIfNotFound: true);
        m_ShipFlight_Brake = m_ShipFlight.FindAction("Brake", throwIfNotFound: true);
        m_ShipFlight_Interact = m_ShipFlight.FindAction("Interact", throwIfNotFound: true);
        m_ShipFlight_FireL = m_ShipFlight.FindAction("FireL", throwIfNotFound: true);
        m_ShipFlight_FireR = m_ShipFlight.FindAction("FireR", throwIfNotFound: true);
        // Turret
        m_Turret = asset.FindActionMap("Turret", throwIfNotFound: true);
        m_Turret_Fire = m_Turret.FindAction("Fire", throwIfNotFound: true);
        m_Turret_Look = m_Turret.FindAction("Look", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_SwitchTool;
    private readonly InputAction m_Player_Chat;
    private readonly InputAction m_Player_Menu;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Reload;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @SwitchTool => m_Wrapper.m_Player_SwitchTool;
        public InputAction @Chat => m_Wrapper.m_Player_Chat;
        public InputAction @Menu => m_Wrapper.m_Player_Menu;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Reload => m_Wrapper.m_Player_Reload;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @SwitchTool.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchTool;
                @SwitchTool.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchTool;
                @SwitchTool.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchTool;
                @Chat.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChat;
                @Chat.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChat;
                @Chat.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChat;
                @Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Reload.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @SwitchTool.started += instance.OnSwitchTool;
                @SwitchTool.performed += instance.OnSwitchTool;
                @SwitchTool.canceled += instance.OnSwitchTool;
                @Chat.started += instance.OnChat;
                @Chat.performed += instance.OnChat;
                @Chat.canceled += instance.OnChat;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // ShipFlight
    private readonly InputActionMap m_ShipFlight;
    private IShipFlightActions m_ShipFlightActionsCallbackInterface;
    private readonly InputAction m_ShipFlight_Look;
    private readonly InputAction m_ShipFlight_Reload;
    private readonly InputAction m_ShipFlight_Menu;
    private readonly InputAction m_ShipFlight_Accelerate;
    private readonly InputAction m_ShipFlight_Roll;
    private readonly InputAction m_ShipFlight_Hover;
    private readonly InputAction m_ShipFlight_Brake;
    private readonly InputAction m_ShipFlight_Interact;
    private readonly InputAction m_ShipFlight_FireL;
    private readonly InputAction m_ShipFlight_FireR;
    public struct ShipFlightActions
    {
        private @Controls m_Wrapper;
        public ShipFlightActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_ShipFlight_Look;
        public InputAction @Reload => m_Wrapper.m_ShipFlight_Reload;
        public InputAction @Menu => m_Wrapper.m_ShipFlight_Menu;
        public InputAction @Accelerate => m_Wrapper.m_ShipFlight_Accelerate;
        public InputAction @Roll => m_Wrapper.m_ShipFlight_Roll;
        public InputAction @Hover => m_Wrapper.m_ShipFlight_Hover;
        public InputAction @Brake => m_Wrapper.m_ShipFlight_Brake;
        public InputAction @Interact => m_Wrapper.m_ShipFlight_Interact;
        public InputAction @FireL => m_Wrapper.m_ShipFlight_FireL;
        public InputAction @FireR => m_Wrapper.m_ShipFlight_FireR;
        public InputActionMap Get() { return m_Wrapper.m_ShipFlight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipFlightActions set) { return set.Get(); }
        public void SetCallbacks(IShipFlightActions instance)
        {
            if (m_Wrapper.m_ShipFlightActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnLook;
                @Reload.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnReload;
                @Menu.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnMenu;
                @Accelerate.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnAccelerate;
                @Roll.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnRoll;
                @Hover.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnHover;
                @Hover.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnHover;
                @Hover.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnHover;
                @Brake.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnBrake;
                @Interact.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnInteract;
                @FireL.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnFireL;
                @FireL.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnFireL;
                @FireL.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnFireL;
                @FireR.started -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnFireR;
                @FireR.performed -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnFireR;
                @FireR.canceled -= m_Wrapper.m_ShipFlightActionsCallbackInterface.OnFireR;
            }
            m_Wrapper.m_ShipFlightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Hover.started += instance.OnHover;
                @Hover.performed += instance.OnHover;
                @Hover.canceled += instance.OnHover;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @FireL.started += instance.OnFireL;
                @FireL.performed += instance.OnFireL;
                @FireL.canceled += instance.OnFireL;
                @FireR.started += instance.OnFireR;
                @FireR.performed += instance.OnFireR;
                @FireR.canceled += instance.OnFireR;
            }
        }
    }
    public ShipFlightActions @ShipFlight => new ShipFlightActions(this);

    // Turret
    private readonly InputActionMap m_Turret;
    private ITurretActions m_TurretActionsCallbackInterface;
    private readonly InputAction m_Turret_Fire;
    private readonly InputAction m_Turret_Look;
    public struct TurretActions
    {
        private @Controls m_Wrapper;
        public TurretActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Turret_Fire;
        public InputAction @Look => m_Wrapper.m_Turret_Look;
        public InputActionMap Get() { return m_Wrapper.m_Turret; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TurretActions set) { return set.Get(); }
        public void SetCallbacks(ITurretActions instance)
        {
            if (m_Wrapper.m_TurretActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_TurretActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_TurretActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_TurretActionsCallbackInterface.OnFire;
                @Look.started -= m_Wrapper.m_TurretActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_TurretActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_TurretActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_TurretActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public TurretActions @Turret => new TurretActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnSwitchTool(InputAction.CallbackContext context);
        void OnChat(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
    public interface IShipFlightActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnHover(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnFireL(InputAction.CallbackContext context);
        void OnFireR(InputAction.CallbackContext context);
    }
    public interface ITurretActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
