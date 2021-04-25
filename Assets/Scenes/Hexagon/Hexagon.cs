using UnityEngine;

namespace Scenes.Hexagon
{
    /// <summary>
    /// Draws a hexagon
    /// </summary>
    public class Hexagon : MonoBehaviour
    {
        [SerializeField] private GameObject cornerPrefab;
        [SerializeField] private float size = 1f;
    
        private Vector2 _center;
        private readonly Vector2[] _points = new Vector2[6];
        private readonly GameObject[] _corners = new GameObject[6];

        private void Start()
        {
            _center = transform.position;
            for (var i = 0; i < _points.Length; i++)
            {
                var angleDeg = 60 * i - 30;
                var angleRad = Mathf.PI / 180 * angleDeg;
                _points[i] = new Vector2((_center.x + size) * Mathf.Cos(angleRad), (_center.y + size) * Mathf.Sin(angleRad));
                if (!cornerPrefab) continue;
                var corner = Instantiate(cornerPrefab, new Vector3(_points[i].x, 0, _points[i].y), Quaternion.identity);
                _corners[i] = corner;
                corner.name = i.ToString();
                corner.transform.parent = transform;
                var line = corner.AddComponent<LineRenderer>();
                var cornerPosition = corner.transform.position;
                line.SetPosition(0, cornerPosition);
                line.startWidth = 0.1f;
                line.endWidth = 0.1f;

                if (i > 0)
                {
                    var lastPoint = _points[i - 1];
                    line.SetPosition(1, new Vector3(lastPoint.x, 0, lastPoint.y));
                }

                if (i != 5) continue;
                var firstCorner = _corners[0];
                var firstLine = firstCorner.GetComponent<LineRenderer>();
                firstLine.SetPosition(1, corner.transform.position);
            }
        }
    }
}
