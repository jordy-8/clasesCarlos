using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScreenSceneController : MonoBehaviour
{
    public Animator animator;
    [SerializeField]
    AudioManager AMI;

    void Start()
    {
        AMI = AudioManager.instance;
        AMI.Play("mainScreen");
        
    }

    void Update()
    {
        
    }

    public void Fade()
    {
        Debug.Log("ChangeScene");
        //SceneManager.LoadScene("Gameplay");        
        //StartCoroutine(Pausa());
        //activar fade
        animator.SetTrigger("ChangeScene");
    }

    /*
    IEnumerator Pausa()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
    */

    
    internal void ChangeScene()
    {        
        SceneManager.LoadScene(1);
    }
    
}
