using UnityEngine;

namespace Prefabs.DemonDog.Scripts
{
    public class MoveToTarget : MonoBehaviour
    {
        public float moveSpeed;
    
        private Camera _camera;
        private Vector2 _target;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (_camera is { }) _target = _camera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, _target, moveSpeed * Time.deltaTime);
        }
    }
}
