using Scrips.CameraLogic;
using Scrips.Infrastructure;
using Scrips.Services.Input;
using UnityEngine;

namespace Scrips.Hero
{
  public class HeroMove : MonoBehaviour
  {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private float _movementSpeed;
        [SerializeField] private HeroAnimator _animator;

        private IInputService _inputService;
        private Camera _camera;

        public HeroAnimator HeroAnimator => _animator;

        private void Awake()
        {
            _inputService = Game.InputService;
        }

        private void Start()
        {
            _camera = Camera.main;

            CameraFollow();
        }

        private void Update()
        {
            Vector3 movementVector = Vector3.zero;
           
            if (_inputService.Axis.sqrMagnitude > Constants.Epsilon)
            {
                _animator.Move();
                movementVector = _camera.transform.TransformDirection(_inputService.Axis);
                movementVector.y = 0;
                movementVector.Normalize();

                transform.forward = movementVector;
            }
            else if(_inputService.Axis.magnitude < Constants.Epsilon)
            {
                _animator.Stay();
            }

            movementVector += Physics.gravity;

            _characterController.Move(_movementSpeed * movementVector * Time.deltaTime);
        }

        private void CameraFollow()
        {
            _camera.GetComponent<CameraFollow>().Follow(gameObject);
        }
    }
}