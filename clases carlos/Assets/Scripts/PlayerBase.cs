using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public Player playerScript;

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("entre en " + col.name);
        if(col.name == "floor")
        {
            playerScript.canJump = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        //Debug.Log("entre en " + col.name);
        if(col.name == "floor")
        {
            playerScript.canJump = false;
        }
    }
}
