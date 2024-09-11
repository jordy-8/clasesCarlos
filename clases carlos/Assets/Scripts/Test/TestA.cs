using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestA : MonoBehaviour
{
    internal static int vida = 100;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        vida -= 1;
        Debug.Log("vida= " + vida);
    }
}
