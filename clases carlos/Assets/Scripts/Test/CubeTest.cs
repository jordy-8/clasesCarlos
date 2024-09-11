using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    public void Grow()
    {
        transform.localScale *= 1.1f;
    }
    
    void OnEnable()
    {
        Debug.Log("enabled");
    	GameController.buttonPressed += Grow;
    }

    void OnDisable()
    {
        Debug.Log("disabled");
	    GameController.buttonPressed -= Grow;
    }

}
