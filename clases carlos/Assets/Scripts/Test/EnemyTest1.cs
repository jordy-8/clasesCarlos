using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest1 : MonoBehaviour
{
    [SerializeField]
    static int vitalidad = 10;

    [SerializeField]
    KeyCode tecla;

    void Update()
    {
        if(Input.GetKeyDown(tecla))
        {
            vitalidad -= 1;
        }
        Debug.Log(gameObject.name + " miVitalidad= " + vitalidad);
    }
}
