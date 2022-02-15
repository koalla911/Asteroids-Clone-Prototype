using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts
{
    public class SpaceshipActionEvents : MonoBehaviour
    {
        public delegate void ProjectileShooting();
        public static event ProjectileShooting OnProjectileShootingEvent;
        
        public delegate void LaserShooting();
        public static event LaserShooting OnLaserShootingEvent;


        private PlayerControls _inputActions;

        private Vector3 _moveTransformInput;
        private float _velocityFactor = 0.01f;
        private float _dragFactor = 0.9f;
        private float _maxVelocity = 13.2f;

        private Vector3 _moveRotateInput;
        private float _velocityFactorRotate = -1.5f;
        private float _dragFactorRotate = 1f;
        private float _maxVelocityRotate = 15.0f;

        private Vector2 _shootActivateDirection;

        private void OnEnable()
        {
            _inputActions.Enable();
        }


        private void Awake()
        {
            _moveTransformInput = Vector3.zero;
            _moveRotateInput = Vector3.zero;
            _inputActions = new PlayerControls();

            _inputActions.SpaceShip.ShootProjectile.performed += ctx => ShootProjectile(ctx);
            _inputActions.SpaceShip.ShootLaser.performed += ctx => ShootLaser(ctx);
        }


        private void ShootLaser(InputAction.CallbackContext ctx)
        {
            Debug.Log("start shoot LASER coroutine");
            OnLaserShootingEvent?.Invoke();
        }


        private void ShootProjectile(InputAction.CallbackContext obj)
        {
            OnProjectileShootingEvent?.Invoke();
        }


        private void FixedUpdate()
        {

            _moveRotateInput.z = _inputActions.SpaceShip.MovementRotate.ReadValue<float>() * _velocityFactorRotate;
            _moveRotateInput.z *= _dragFactorRotate;
            _moveRotateInput = Vector3.ClampMagnitude(_moveRotateInput, _maxVelocityRotate);
            transform.Rotate(_moveRotateInput);

            _moveTransformInput.y += _inputActions.SpaceShip.MovementPosition.ReadValue<float>() * _velocityFactor;
            _moveTransformInput.y *= _dragFactor;
            _moveTransformInput = Vector3.ClampMagnitude(_moveTransformInput, _maxVelocity);
            transform.Translate(_moveTransformInput);
        }


        private void OnDisable()
        {
            _inputActions.Disable();
        }
    }
}