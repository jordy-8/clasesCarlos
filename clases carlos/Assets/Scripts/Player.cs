using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    AudioManager AMI;

    [Header("---------- stats ----------")]
    [SerializeField]
    float jumpForce;
    [SerializeField]
    float speed;
    
    [Header("---------- controller ----------")]
    [SerializeField]
    internal bool canJump = false;

    [Header("---------- componentes ----------")]
    [SerializeField]
    Animator animator;
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    enum AnimationParameters {slideB};

    void Start()
    {
        Initialize();
        AMI = AudioManager.instance;
        
        //Vector3 pos = this.GetComponent<Transform>().position;
        //Debug.Log("pos= " + pos);
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.GetComponent<Transform>().position += new Vector3(0, 0, speed);
        //Vector3 pos = this.GetComponent<Transform>().position;
        //Debug.Log("pos= " + pos);

        MoveByRigidbody();

        if(Input.GetKeyDown("j"))
        {
            AMI.Play("playerJump");
            Debug.Log("jump");
        }
    }

    void Initialize()
    {
        AssignComponents();
        //vida = 100
        //stratpos =
        //color = verde
    }

    void AssignComponents()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void MoveByRigidbody()
    {
        rb.AddForce(0, 0, speed);
        //rb.velocity = new Vector3(0, 0, speed);
    }

    internal void ChangeSpeed(float newSpeed)
    {
        Debug.Log("change speed");
        speed = newSpeed;
    }

    public void Jump()
    {
        Debug.Log("jump");
        //if(canJump == true)
        //if(canJump)
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }

    public void FinishedMove()
    {
        Debug.Log("finished move");
    }

    public void SlideDown()
    {
        Debug.Log("slideDown");        
        animator.SetBool(AnimationParameters.slideB.ToString(), true);
    }

    public void SlideUp()
    {
        Debug.Log("slideUp");
        animator.SetBool(AnimationParameters.slideB.ToString(), false);
    }

}
