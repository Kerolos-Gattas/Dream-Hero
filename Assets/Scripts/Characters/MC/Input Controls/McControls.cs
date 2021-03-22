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
                    ""interactions"": ""Hold(duration=0.1,pressPoint=0.1)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""bda597ae-8b9a-4435-9981-7d535162db3b"",
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
                    ""interactions"": """",
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
                    ""interactions"": """",
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
                    ""id"": ""bc46ec2a-e4fc-44cc-9192-d28298c31772"",
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
                    ""id"": ""3754025e-af2b-49f7-b1db-9436c1ee7e7f"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 dualshock"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""909da289-dfa0-41d9-80b7-4b9dec4437be"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 dualshock"",
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
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 dualshock"",
                    ""action"": ""Jump"",
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
            ""name"": ""PS4 dualshock"",
            ""bindingGroup"": ""PS4 dualshock"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
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
    public struct MCActions
    {
        private @McControls m_Wrapper;
        public MCActions(@McControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MC_Move;
        public InputAction @Jump => m_Wrapper.m_MC_Jump;
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
    private int m_PS4dualshockSchemeIndex = -1;
    public InputControlScheme PS4dualshockScheme
    {
        get
        {
            if (m_PS4dualshockSchemeIndex == -1) m_PS4dualshockSchemeIndex = asset.FindControlSchemeIndex("PS4 dualshock");
            return asset.controlSchemes[m_PS4dualshockSchemeIndex];
        }
    }
    public interface IMCActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
