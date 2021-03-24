// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Characters/MC/Input Controls/McControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @McControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @McControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""McControls"",
    ""maps"": [
        {
            ""name"": ""MC"",
            ""id"": ""5021358d-6517-4110-a4a8-bd7001c3530e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""7aee639e-6018-4b6e-8d22-da68f6709234"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bda597ae-8b9a-4435-9981-7d535162db3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1)""
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""4dd0bf3e-154e-48a7-9b91-87bf039f626a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fd7841df-b54c-4b94-806c-db2ce3cd4bc7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Hold(duration=0.01,pressPoint=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b5483e2a-5c27-4ed8-a782-8fe8c566522d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1513eb51-20ab-4a98-8996-978bc11d1127"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""eafb19e4-e9b4-40f7-9988-911794051981"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Hold(duration=0.01,pressPoint=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f3c830f4-29e0-4b7e-bca7-cfcc4a1e29bb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""12c31a61-0c60-446c-b916-28f520a0e718"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PS4 dualshock"",
                    ""id"": ""d0f51990-768c-4c1b-a998-4f321c7731c3"",
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
                    ""id"": ""df5f5a91-5a77-432e-9677-7faafe746442"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8652d806-2598-4f59-ba4a-ca332078c9c6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""22b2db32-a99c-4db3-87c2-6ea5f93c5eb2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1f6ba59-8094-45ed-afcb-bd005b9c6950"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9de5fdcf-fb7d-4224-9e3f-09126ffffff6"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b57da85-99b6-454a-bf6d-6232ac085cbf"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
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
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MC
        m_MC = asset.FindActionMap("MC", throwIfNotFound: true);
        m_MC_Move = m_MC.FindAction("Move", throwIfNotFound: true);
        m_MC_Jump = m_MC.FindAction("Jump", throwIfNotFound: true);
        m_MC_Dash = m_MC.FindAction("Dash", throwIfNotFound: true);
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

    // MC
    private readonly InputActionMap m_MC;
    private IMCActions m_MCActionsCallbackInterface;
    private readonly InputAction m_MC_Move;
    private readonly InputAction m_MC_Jump;
    private readonly InputAction m_MC_Dash;
    public struct MCActions
    {
        private @McControls m_Wrapper;
        public MCActions(@McControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MC_Move;
        public InputAction @Jump => m_Wrapper.m_MC_Jump;
        public InputAction @Dash => m_Wrapper.m_MC_Dash;
        public InputActionMap Get() { return m_Wrapper.m_MC; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MCActions set) { return set.Get(); }
        public void SetCallbacks(IMCActions instance)
        {
            if (m_Wrapper.m_MCActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MCActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MCActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MCActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MCActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MCActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MCActionsCallbackInterface.OnJump;
                @Dash.started -= m_Wrapper.m_MCActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_MCActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_MCActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_MCActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public MCActions @MC => new MCActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
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
    public interface IMCActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
}
