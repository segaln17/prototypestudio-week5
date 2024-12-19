//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Resources/Scripts/ColliderControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ColliderControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ColliderControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ColliderControls"",
    ""maps"": [
        {
            ""name"": ""ColliderGameplay"",
            ""id"": ""c289eb4c-0923-4c49-97f3-a594855c7c1c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""f8fe70c7-45ca-4952-9897-0d5d31b4b3f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""228ad135-2620-4720-82a4-a11976b15b63"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ColliderGameplay
        m_ColliderGameplay = asset.FindActionMap("ColliderGameplay", throwIfNotFound: true);
        m_ColliderGameplay_Move = m_ColliderGameplay.FindAction("Move", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ColliderGameplay
    private readonly InputActionMap m_ColliderGameplay;
    private List<IColliderGameplayActions> m_ColliderGameplayActionsCallbackInterfaces = new List<IColliderGameplayActions>();
    private readonly InputAction m_ColliderGameplay_Move;
    public struct ColliderGameplayActions
    {
        private @ColliderControls m_Wrapper;
        public ColliderGameplayActions(@ColliderControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_ColliderGameplay_Move;
        public InputActionMap Get() { return m_Wrapper.m_ColliderGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ColliderGameplayActions set) { return set.Get(); }
        public void AddCallbacks(IColliderGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_ColliderGameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ColliderGameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IColliderGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IColliderGameplayActions instance)
        {
            if (m_Wrapper.m_ColliderGameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IColliderGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_ColliderGameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ColliderGameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ColliderGameplayActions @ColliderGameplay => new ColliderGameplayActions(this);
    public interface IColliderGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
