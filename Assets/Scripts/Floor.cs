using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Splines;

public class Floor : MonoBehaviour
{
    [SerializeField]
    private SplineContainer _floorSplineContainer;

    private Spline _floorSpline;

    // Start is called before the first frame update
    void Awake()
    {
        _floorSpline = _floorSplineContainer.Spline;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TODO
    // Doesn't actually work correctly
    public Vector2 GetClosestFloorLocation(Ray clickRay) {
        Vector2 closestPoint = Vector2.positiveInfinity;
        SplineUtility.GetNearestPoint(_floorSpline, clickRay, out float3 nearestPoint, out float t);
        Vector3 worldPoint = nearestPoint;
        closestPoint = worldPoint;

        return closestPoint;
    }
}
