using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTest : MonoBehaviour
{
    [SerializeField]
    int numeroBuscado;

    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            if(i == numeroBuscado)
            {
                Debug.Log("encontre a= " + i);
                return;
            }
            Debug.Log("i= " + i);
        }
    }
}
