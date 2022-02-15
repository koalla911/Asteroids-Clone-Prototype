// GENERATED AUTOMATICALLY FROM 'Assets/InputMap/PlayerControls.inputactions'

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
            ""name"": ""SpaceShip"",
            ""id"": ""ca3d8262-c4b8-4c5b-891e-6ec97015922a"",
            ""actions"": [
                {
                    ""name"": ""MovementRotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ba2663ad-cdeb-4614-8b84-fb83cdede545"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5a372baf-7352-43b6-8158-bef2eb7514a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootProjectile"",
                    ""type"": ""PassThrough"",
                    ""id"": ""348321df-fb38-4fa4-8303-ce706de73d33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ShootLaser"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9b050d55-e060-47c2-88d7-0e4a8f9e194c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""22693666-8c3d-47f0-8a44-e5f29c5ebe6a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootProjectile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4aa13176-2fda-4f48-bbfe-e856f005da77"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb128cb4-71a2-477c-a0e5-3e08c8bc4654"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D AxisKeys"",
                    ""id"": ""71261737-b378-4732-bff2-daaaf4e212bb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""e3f9aca8-1cfe-4c35-96ff-c060a9c26410"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""fa99a2ab-2db0-4e49-8fce-89d9b868bb27"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D AxisArrows"",
                    ""id"": ""de3adfda-5ea5-4ceb-b85a-e185e3bdfe40"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c5a917d3-551a-4496-9698-6ad669cfd65b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0eeb0dc2-0ee2-496d-9551-262ba1cc73f2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D AxisKeys"",
                    ""id"": ""270d66b8-1c51-403e-b1aa-6e57ee1905b3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementPosition"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""954a34fb-c823-4879-a3bd-899ae1e4123f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D AxisArrows"",
                    ""id"": ""8a16c0e6-f483-4d0b-b333-631de121d3b5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementPosition"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fff802f8-e6c8-4631-80ae-9332158317b7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SpaceShip
        m_SpaceShip = asset.FindActionMap("SpaceShip", throwIfNotFound: true);
        m_SpaceShip_MovementRotate = m_SpaceShip.FindAction("MovementRotate", throwIfNotFound: true);
        m_SpaceShip_MovementPosition = m_SpaceShip.FindAction("MovementPosition", throwIfNotFound: true);
        m_SpaceShip_ShootProjectile = m_SpaceShip.FindAction("ShootProjectile", throwIfNotFound: true);
        m_SpaceShip_ShootLaser = m_SpaceShip.FindAction("ShootLaser", throwIfNotFound: true);
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

    // SpaceShip
    private readonly InputActionMap m_SpaceShip;
    private ISpaceShipActions m_SpaceShipActionsCallbackInterface;
    private readonly InputAction m_SpaceShip_MovementRotate;
    private readonly InputAction m_SpaceShip_MovementPosition;
    private readonly InputAction m_SpaceShip_ShootProjectile;
    private readonly InputAction m_SpaceShip_ShootLaser;
    public struct SpaceShipActions
    {
        private @PlayerControls m_Wrapper;
        public SpaceShipActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementRotate => m_Wrapper.m_SpaceShip_MovementRotate;
        public InputAction @MovementPosition => m_Wrapper.m_SpaceShip_MovementPosition;
        public InputAction @ShootProjectile => m_Wrapper.m_SpaceShip_ShootProjectile;
        public InputAction @ShootLaser => m_Wrapper.m_SpaceShip_ShootLaser;
        public InputActionMap Get() { return m_Wrapper.m_SpaceShip; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpaceShipActions set) { return set.Get(); }
        public void SetCallbacks(ISpaceShipActions instance)
        {
            if (m_Wrapper.m_SpaceShipActionsCallbackInterface != null)
            {
                @MovementRotate.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMovementRotate;
                @MovementRotate.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMovementRotate;
                @MovementRotate.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMovementRotate;
                @MovementPosition.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMovementPosition;
                @MovementPosition.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMovementPosition;
                @MovementPosition.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMovementPosition;
                @ShootProjectile.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootProjectile;
                @ShootProjectile.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootProjectile;
                @ShootProjectile.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootProjectile;
                @ShootLaser.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootLaser;
                @ShootLaser.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootLaser;
                @ShootLaser.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShootLaser;
            }
            m_Wrapper.m_SpaceShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementRotate.started += instance.OnMovementRotate;
                @MovementRotate.performed += instance.OnMovementRotate;
                @MovementRotate.canceled += instance.OnMovementRotate;
                @MovementPosition.started += instance.OnMovementPosition;
                @MovementPosition.performed += instance.OnMovementPosition;
                @MovementPosition.canceled += instance.OnMovementPosition;
                @ShootProjectile.started += instance.OnShootProjectile;
                @ShootProjectile.performed += instance.OnShootProjectile;
                @ShootProjectile.canceled += instance.OnShootProjectile;
                @ShootLaser.started += instance.OnShootLaser;
                @ShootLaser.performed += instance.OnShootLaser;
                @ShootLaser.canceled += instance.OnShootLaser;
            }
        }
    }
    public SpaceShipActions @SpaceShip => new SpaceShipActions(this);
    public interface ISpaceShipActions
    {
        void OnMovementRotate(InputAction.CallbackContext context);
        void OnMovementPosition(InputAction.CallbackContext context);
        void OnShootProjectile(InputAction.CallbackContext context);
        void OnShootLaser(InputAction.CallbackContext context);
    }
}
