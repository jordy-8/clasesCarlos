using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomizeObstacles : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject obstaclePrefab;

    int obstaclesLimit;
    // Start is called before the first frame update
    void Start()
    {
        CreateObstacles();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObstacles()
    {
        obstaclesLimit = Random.Range(1, 4);
        for(int i = 0; i < obstaclesLimit; i++)
        {
            GameObject obstacleTemp = Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
            obstacleTemp.transform.SetParent(transform);
            obstacleTemp.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-0.4f, 0.4f), 0, 0.5f);
            obstacles[i] = obstacleTemp;
        }
    }

    internal void Randomize()
    {
        DestroyAllObstacles();
        
        CreateObstacles();

        RandomizePosition();              
    }

    void DestroyAllObstacles()
    {
        Debug.Log("destuir todos");
        foreach(GameObject obstacle in obstacles)
        {
            Destroy(obstacle);
        }
    }

    void RandomizePosition()
    {
        Debug.Log("soy " + gameObject.name);
        foreach(GameObject obstacle in obstacles)
        {
            if(obstacle != null)
            {
                obstacle.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-0.4f, 0.4f), 0, 0.5f);
            }
            Debug.Log("obstacle doesn't exist");
        }
    }
}
