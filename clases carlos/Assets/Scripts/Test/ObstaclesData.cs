using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObstaclesData
{
    [SerializeField]
    internal Transform obstacleTransform;
    [SerializeField]
    internal float distance;

    internal ObstaclesData(Transform _transform, float _distance)
    {
        this.obstacleTransform = _transform;
        this.distance = _distance;
    }

    
}
