// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/MC.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MC : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MC()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MC"",
    ""maps"": [
        {
            ""name"": ""Reporter"",
            ""id"": ""67d4d391-8ead-4dfe-9897-b8a4c06b4e68"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""25916f5b-d872-4c7e-acc9-08ee134649ac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trap"",
                    ""type"": ""Button"",
                    ""id"": ""887d9ae7-4653-4c65-b8bc-f39777c99b3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vaia"",
                    ""type"": ""Button"",
                    ""id"": ""bb141b90-4398-4bb6-83fc-73df25bef6f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""886c6c50-07db-4e0a-9e10-8b0e9598def6"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Wasd"",
                    ""id"": ""06496d05-952b-49d9-a0ce-cf119bb9fc6a"",
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
                    ""id"": ""9f19a421-8d47-4f3b-9905-824b0da884c0"",
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
                    ""id"": ""fec1bd97-eddb-412f-9498-843b42a49080"",
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
                    ""id"": ""eb9ad065-c42d-46f1-b0ca-780e8470d27b"",
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
                    ""id"": ""3d207df4-8191-4963-a973-1ec729e8d3db"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b5bc8124-ebca-4352-8ed5-b3df60945cc3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1829960-4c60-476c-bccb-346bfa90e96d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5536a31-c2a2-430d-95d9-660bd4b5320e"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51ac4a74-1ada-4b1e-838c-605e822e5c02"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58d4b6e7-82d2-4552-8cfb-bd7c60127995"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vaia"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fbebb3b-8f2c-45fa-af3c-d6aa24512001"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vaia"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Reporter
        m_Reporter = asset.FindActionMap("Reporter", throwIfNotFound: true);
        m_Reporter_Move = m_Reporter.FindAction("Move", throwIfNotFound: true);
        m_Reporter_Trap = m_Reporter.FindAction("Trap", throwIfNotFound: true);
        m_Reporter_Vaia = m_Reporter.FindAction("Vaia", throwIfNotFound: true);
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

    // Reporter
    private readonly InputActionMap m_Reporter;
    private IReporterActions m_ReporterActionsCallbackInterface;
    private readonly InputAction m_Reporter_Move;
    private readonly InputAction m_Reporter_Trap;
    private readonly InputAction m_Reporter_Vaia;
    public struct ReporterActions
    {
        private @MC m_Wrapper;
        public ReporterActions(@MC wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Reporter_Move;
        public InputAction @Trap => m_Wrapper.m_Reporter_Trap;
        public InputAction @Vaia => m_Wrapper.m_Reporter_Vaia;
        public InputActionMap Get() { return m_Wrapper.m_Reporter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ReporterActions set) { return set.Get(); }
        public void SetCallbacks(IReporterActions instance)
        {
            if (m_Wrapper.m_ReporterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ReporterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ReporterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ReporterActionsCallbackInterface.OnMove;
                @Trap.started -= m_Wrapper.m_ReporterActionsCallbackInterface.OnTrap;
                @Trap.performed -= m_Wrapper.m_ReporterActionsCallbackInterface.OnTrap;
                @Trap.canceled -= m_Wrapper.m_ReporterActionsCallbackInterface.OnTrap;
                @Vaia.started -= m_Wrapper.m_ReporterActionsCallbackInterface.OnVaia;
                @Vaia.performed -= m_Wrapper.m_ReporterActionsCallbackInterface.OnVaia;
                @Vaia.canceled -= m_Wrapper.m_ReporterActionsCallbackInterface.OnVaia;
            }
            m_Wrapper.m_ReporterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Trap.started += instance.OnTrap;
                @Trap.performed += instance.OnTrap;
                @Trap.canceled += instance.OnTrap;
                @Vaia.started += instance.OnVaia;
                @Vaia.performed += instance.OnVaia;
                @Vaia.canceled += instance.OnVaia;
            }
        }
    }
    public ReporterActions @Reporter => new ReporterActions(this);
    public interface IReporterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnTrap(InputAction.CallbackContext context);
        void OnVaia(InputAction.CallbackContext context);
    }
}
