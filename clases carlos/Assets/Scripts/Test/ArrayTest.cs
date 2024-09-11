using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public GameObject[] floors;
    int indexFloor = 0;

    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        for(int i= 0; i <= 3; i++)
        {
            //floors[i].GetComponent<Transform>().position = new Vector3(floors[i].GetComponent<Transform>().position.x + 60, 0, 0);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        /*
         for(int i= 0; i <= 3; i++)
        {
            Debug.Log("soy= " + floors[i]);
        }
        */        

        /*
        foreach(GameObject floor in floors)
        {
            Debug.Log("soy= " + floor.name);
        }
        */        
    }

    internal void MoveFloor()
    {        
        //Debug.Log("soy " + floors[indexFloor]); 
        Debug.Log("indiceFloor= " + indexFloor);
        floors[indexFloor].transform.localPosition = new Vector3(floors[indexFloor].transform.localPosition.x + 80, 0, 0);
        floors[indexFloor].GetComponent<RadomizeObstacles>().Randomize();  
        indexFloor += 1;
        if(indexFloor >= 4)
        {
            indexFloor = 0;
        }
            
    }
}
