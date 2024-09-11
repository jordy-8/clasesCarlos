using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public MainScreenSceneController mainScreenSceneControllerScript;
    // Start is called before the first frame update
    public void ChangeScene()
    {
        mainScreenSceneControllerScript.ChangeScene();
    }
}
