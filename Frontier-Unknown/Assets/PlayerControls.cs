// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4ed939c5-59ef-4c5e-80f6-6ad6e9c72d16"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a1caab29-121d-4ab4-a282-8721670023fb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""96958eb4-c2e9-4a94-bb98-2ff523ec984c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""04cc02d7-15e3-4ead-babb-d178a6be1d6a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu Up"",
                    ""type"": ""Button"",
                    ""id"": ""c5b4e4f4-f8a2-461d-b823-95ce6b35ba66"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu Down"",
                    ""type"": ""Button"",
                    ""id"": ""b0848824-26b3-4cef-a908-278852733dca"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu Back"",
                    ""type"": ""Button"",
                    ""id"": ""3263176b-00db-4bf0-b8d2-636a563d5454"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu Forward/Select"",
                    ""type"": ""Button"",
                    ""id"": ""794f3728-7930-4559-9ebd-3244361ee8ec"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""61c31c14-4e24-4d8e-93e5-884614d2c98d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AltAttack"",
                    ""type"": ""Button"",
                    ""id"": ""c93142ae-f20e-4279-a93f-c0258ee9a5dd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TertAttack"",
                    ""type"": ""Button"",
                    ""id"": ""d355e38e-9e95-450e-b38f-6dea75c80604"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""60090a6a-375a-44dd-9bb7-67425dee0fb3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b051acd0-83ac-43e0-8742-4618c911054e"",
                    ""path"": ""<WebGLGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a02f6e2a-9560-4ec4-9190-3b113e51eac4"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9147cb9a-f810-4924-bcf2-4ebeff2d5370"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ed67960b-1f57-4344-94f2-69bda612acd4"",
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
                    ""id"": ""e25bc5a7-16f0-4614-9bcd-40f34a89c369"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ff559470-c19f-4df3-b707-94c4bd84629a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2ff5907e-408a-414b-a1f6-d33922ccba30"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ba286545-a15e-488d-9438-ac8563595841"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f49f6a63-0a51-43c7-a6dc-a373bef3ab9e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e92a5ad6-bcab-4d0b-b985-e2f6d76357b1"",
                    ""path"": ""<WebGLGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f309397a-68d2-4796-81fa-ed923be3b21f"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9075cce5-3328-4e6e-ad07-a0b595bc28a5"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4aba9ad6-6e04-4c07-b688-27e8ae1cb83b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73565eda-ab74-495a-a489-52e9672cb988"",
                    ""path"": ""<WebGLGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""771549b0-fd58-405b-8988-7873a8d1b8ba"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""501828cb-92b2-4be2-b25a-e9a2e2e6a610"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f453e2ba-8381-4b57-a09e-a4285ae77da6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Menu Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a203ce29-8ae8-4578-8f41-3f400c72edb8"",
                    ""path"": ""<WebGLGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Menu Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""262245e9-80f9-4e3c-8917-e8eebe10bd26"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Menu Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31df81fb-3957-4f88-b2b1-40e7bf4e3de8"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Menu Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87c70589-526c-4183-8eca-1c49ef054b67"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Menu Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb23ea6b-e04c-4be4-8ae3-a363bdbd289f"",
                    ""path"": ""<WebGLGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Menu Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""621a78ac-4d60-45f8-bfde-acab248441fc"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Menu Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e29e38a-c889-45f4-b65e-63275baa955b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Menu Forward/Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e054023-3391-4d40-a7e7-d0dfc95fdb0c"",
                    ""path"": ""<WebGLGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Menu Forward/Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbc1faaf-8616-4423-b3da-5b9d751c1db9"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Menu Forward/Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b55f79c7-bcdf-47ff-b80e-5e33f2d51b47"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Menu Forward/Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16a77980-b212-4db5-b461-3701b7900e50"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Menu Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89599e2d-e22d-40e2-8377-40e5a4e68056"",
                    ""path"": ""<WebGLGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Menu Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f65ffa08-d459-4748-9526-18513f2797ef"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Menu Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad02cf22-ad27-494f-968a-d12a9f2f0ab8"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Menu Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74003980-1689-4ba8-80a6-13e566650f01"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Menu Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0f3960d-22a3-470c-90d9-7795d8322401"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1823b0eb-adec-47cc-9037-b4bdae2ea8c5"",
                    ""path"": ""<WebGLGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3e22142-4e5b-4bfd-a6e9-ca39a98d4fd7"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e83afe3a-0b31-4c56-b109-20b7fdbc4f78"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad8ec42d-db90-47f2-88b2-b81038506fc4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9729fe68-f431-4b5a-97ae-dbaa2c115b1f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c857b765-58da-4373-ae10-65963d8d0e1a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76f79a3b-eb8e-42fd-8c0f-757f3e38c652"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbc3c5e6-2628-4aa6-a375-755b291eefab"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TertAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77299d88-5027-48dd-aa75-4598c4f39743"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TertAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71158aab-6fa3-4826-824f-3620ce1a549e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TertAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e44a81a4-f492-4bae-8b67-8bf54eff4744"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TertAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e1de02b-0adc-4524-b3f0-6fd453745a5b"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Reload"",
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
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": []
        },
        {
            ""name"": ""PS4"",
            ""bindingGroup"": ""PS4"",
            ""devices"": []
        },
        {
            ""name"": ""Xbox"",
            ""bindingGroup"": ""Xbox"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_MenuUp = m_Player.FindAction("Menu Up", throwIfNotFound: true);
        m_Player_MenuDown = m_Player.FindAction("Menu Down", throwIfNotFound: true);
        m_Player_MenuBack = m_Player.FindAction("Menu Back", throwIfNotFound: true);
        m_Player_MenuForwardSelect = m_Player.FindAction("Menu Forward/Select", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_AltAttack = m_Player.FindAction("AltAttack", throwIfNotFound: true);
        m_Player_TertAttack = m_Player.FindAction("TertAttack", throwIfNotFound: true);
        m_Player_Reload = m_Player.FindAction("Reload", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_MenuUp;
    private readonly InputAction m_Player_MenuDown;
    private readonly InputAction m_Player_MenuBack;
    private readonly InputAction m_Player_MenuForwardSelect;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_AltAttack;
    private readonly InputAction m_Player_TertAttack;
    private readonly InputAction m_Player_Reload;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @MenuUp => m_Wrapper.m_Player_MenuUp;
        public InputAction @MenuDown => m_Wrapper.m_Player_MenuDown;
        public InputAction @MenuBack => m_Wrapper.m_Player_MenuBack;
        public InputAction @MenuForwardSelect => m_Wrapper.m_Player_MenuForwardSelect;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputAction @AltAttack => m_Wrapper.m_Player_AltAttack;
        public InputAction @TertAttack => m_Wrapper.m_Player_TertAttack;
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
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @MenuUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuUp;
                @MenuUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuUp;
                @MenuUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuUp;
                @MenuDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuDown;
                @MenuDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuDown;
                @MenuDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuDown;
                @MenuBack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuBack;
                @MenuBack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuBack;
                @MenuBack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuBack;
                @MenuForwardSelect.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuForwardSelect;
                @MenuForwardSelect.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuForwardSelect;
                @MenuForwardSelect.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenuForwardSelect;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @AltAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAltAttack;
                @AltAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAltAttack;
                @AltAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAltAttack;
                @TertAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTertAttack;
                @TertAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTertAttack;
                @TertAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTertAttack;
                @Reload.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Reload.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
                @Reload.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReload;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @MenuUp.started += instance.OnMenuUp;
                @MenuUp.performed += instance.OnMenuUp;
                @MenuUp.canceled += instance.OnMenuUp;
                @MenuDown.started += instance.OnMenuDown;
                @MenuDown.performed += instance.OnMenuDown;
                @MenuDown.canceled += instance.OnMenuDown;
                @MenuBack.started += instance.OnMenuBack;
                @MenuBack.performed += instance.OnMenuBack;
                @MenuBack.canceled += instance.OnMenuBack;
                @MenuForwardSelect.started += instance.OnMenuForwardSelect;
                @MenuForwardSelect.performed += instance.OnMenuForwardSelect;
                @MenuForwardSelect.canceled += instance.OnMenuForwardSelect;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @AltAttack.started += instance.OnAltAttack;
                @AltAttack.performed += instance.OnAltAttack;
                @AltAttack.canceled += instance.OnAltAttack;
                @TertAttack.started += instance.OnTertAttack;
                @TertAttack.performed += instance.OnTertAttack;
                @TertAttack.canceled += instance.OnTertAttack;
                @Reload.started += instance.OnReload;
                @Reload.performed += instance.OnReload;
                @Reload.canceled += instance.OnReload;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    private int m_PS4SchemeIndex = -1;
    public InputControlScheme PS4Scheme
    {
        get
        {
            if (m_PS4SchemeIndex == -1) m_PS4SchemeIndex = asset.FindControlSchemeIndex("PS4");
            return asset.controlSchemes[m_PS4SchemeIndex];
        }
    }
    private int m_XboxSchemeIndex = -1;
    public InputControlScheme XboxScheme
    {
        get
        {
            if (m_XboxSchemeIndex == -1) m_XboxSchemeIndex = asset.FindControlSchemeIndex("Xbox");
            return asset.controlSchemes[m_XboxSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnMenuUp(InputAction.CallbackContext context);
        void OnMenuDown(InputAction.CallbackContext context);
        void OnMenuBack(InputAction.CallbackContext context);
        void OnMenuForwardSelect(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnAltAttack(InputAction.CallbackContext context);
        void OnTertAttack(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
}
