using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaFloorTest : MonoBehaviour
{
    public ArrayTest arrayTest;
    
    void OnTriggerExit()
    {
        Debug.Log("el jugador salió");
        arrayTest.MoveFloor();
    }
}
