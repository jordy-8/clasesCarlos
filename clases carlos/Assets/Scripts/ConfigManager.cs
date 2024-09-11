using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConfigManager : MonoBehaviour
{
    public Player playerScript;
    public TextMeshProUGUI speedCurrentValue;
    public Slider speedS;
    private float speedV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speedV = speedS.value;
        //playerScript.speed = speedV; // mal
        playerScript.ChangeSpeed(speedV); // bien
        //speedCurrentValue.text = speedV.ToString();
        speedCurrentValue.SetText("{0:4}", speedV);
        //speedCurrentValue.SetText("The first number is {0} and the 2nd is {1:2} and the 3rd is {2:0}.", 4, 6.345f, 3.5f);
        //Debug.Log("speed value= " + speedV);
    }
}

/*
using UnityEngine;
using System.Collections;
using TMPro;

public class ExampleClass : MonoBehaviour
{
    void Example()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        textmeshPro.SetText("The first number is {0} and the 2nd is {1:2} and the 3rd is {3:0}.", 4, 6.345f, 3.5f);
        // The text displayed will be:
        // The first number is 4 and the 2nd is 6.35 and the 3rd is 4.
    }
}
*/
