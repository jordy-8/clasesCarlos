using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    [SerializeField]
    Transform[] obstaclesTrans;

    [SerializeField]
    List<ObstaclesData> obstacles = new List<ObstaclesData>();

    void Start()
    {
        obstacles.Add(new ObstaclesData(obstaclesTrans[0], 10));
        obstacles.Add(new ObstaclesData(obstaclesTrans[1], 2));
        obstacles.Add(new ObstaclesData(obstaclesTrans[2], 4.1f));
        obstacles.Add(new ObstaclesData(obstaclesTrans[3], 6));

        //obstacles.Sort();
        obstacles.Sort(SortByDistance);        
    }

    static int SortByDistance(ObstaclesData obstacle1, ObstaclesData obstacle2)
    {
        return obstacle1.distance.CompareTo(obstacle2.distance);
    }

    
}
