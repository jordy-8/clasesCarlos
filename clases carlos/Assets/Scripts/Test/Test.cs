using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("entre en " + col.name);
    }
    
    void OnTriggerExit(Collider col)
    {
        Debug.Log("sali de " + col.name);
    }

    void OnTriggerStay(Collider col)
    {
        Debug.Log("estoy dentro de " + col.name);
    }
}
