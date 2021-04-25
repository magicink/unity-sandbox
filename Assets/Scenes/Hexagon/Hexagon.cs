using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Draws a hexagon
/// </summary>
public class Hexagon : MonoBehaviour
{
    [SerializeField] private GameObject cornerPrefab;
    
    private Vector2 center;
    private float size = 1f;
    private Vector2[] points = new Vector2[6];
    private GameObject[] corners = new GameObject[6];

    private void Start()
    {
        center = transform.position;
        for (var i = 0; i < points.Length; i++)
        {
            var angleDeg = 60 * i - 30;
            var angleRad = Mathf.PI / 180 * angleDeg;
            points[i] = new Vector2((center.x + size) * Mathf.Cos(angleRad), (center.y + size) * Mathf.Sin(angleRad));
            if (cornerPrefab)
            {
                var corner = Instantiate(cornerPrefab, new Vector3(points[i].x, 0, points[i].y), Quaternion.identity);
                corners[i] = corner;
                corner.name = i.ToString();
                corner.transform.parent = transform;
                var line = corner.AddComponent<LineRenderer>();
                var cornerPosition = corner.transform.position;
                line.SetPosition(0, cornerPosition);
                line.startWidth = 0.1f;
                line.endWidth = 0.1f;

                if (i > 0)
                {
                    var lastPoint = points[i - 1];
                    // Debug.Log($"Last point: {lastPoint}");
                    line.SetPosition(1, new Vector3(lastPoint.x, 0, lastPoint.y));
                }

                if (i == 5)
                {
                    var firstCorner = corners[0];
                    var firstLine = firstCorner.GetComponent<LineRenderer>();
                    firstLine.SetPosition(1, corner.transform.position);
                }
            }
        }
    }
}
