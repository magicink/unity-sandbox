using UnityEngine;

public class Trail : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int length;
    public Vector3[] segmentPositions;
    public Transform targetDirection;
    public float targetDistance;
    public float smoothSpeed;

    private Vector3[] segmentV;

    private void Awake()
    {
        segmentPositions = new Vector3[length];
        segmentV = new Vector3[length];
    }

    private void Start()
    {
        if (lineRenderer)
        {
            lineRenderer.positionCount = length;
        }
    }

    private void Update()
    {
        if (segmentPositions.Length <= 0) return;
        segmentPositions[0] = transform.position;
        for (var i = 1; i < segmentPositions.Length; i++)
        {
            segmentPositions[i] = Vector3.SmoothDamp(segmentPositions[i], segmentPositions[i - 1] + targetDirection.right * targetDistance, ref segmentV[i], smoothSpeed);
        }
        lineRenderer.SetPositions(segmentPositions);
    }
}
