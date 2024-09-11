using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    internal delegate void ButtonPressedAction();
    internal static event ButtonPressedAction buttonPressed;

    public void ButtonPressed()
    {
        //if(buttonPressed != null)
            {
                buttonPressed();
            }
    }
}
