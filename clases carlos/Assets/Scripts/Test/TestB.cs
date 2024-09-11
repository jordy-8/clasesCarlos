using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestB : MonoBehaviour
{
   [SerializeField]
   //TestA testA;

    void Update()
    {
        if(TestA.vida <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}
