using UnityEngine;

namespace Prefabs.DemonDog.Scripts
{
    public class RotateToTarget : MonoBehaviour
    {
        public float rotationSpeed;

        private Camera _camera;
        private Vector2 _direction;

        // Update is called once per frame
        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            if (_camera is { }) _direction = _camera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            var angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
            var rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
    }
}
