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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Reporter
        m_Reporter = asset.FindActionMap("Reporter", throwIfNotFound: true);
        m_Reporter_Move = m_Reporter.FindAction("Move", throwIfNotFound: true);
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
    public struct ReporterActions
    {
        private @MC m_Wrapper;
        public ReporterActions(@MC wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Reporter_Move;
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
            }
            m_Wrapper.m_ReporterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public ReporterActions @Reporter => new ReporterActions(this);
    public interface IReporterActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
