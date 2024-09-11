using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySceneController : MonoBehaviour
{
    [SerializeField]
    AudioManager AMI;
    // Start is called before the first frame update
    void Start()
    {
        AMI = AudioManager.instance;
        AMI.Stop("mainScreen");
        AMI.Play("level1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
