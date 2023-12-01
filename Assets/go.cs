using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class go : MonoBehaviour
{
    public Transform myCamera;
    public float speed = 10f;
    // public bool isGrounded;
    //public float Gravity = 1f;
    //     public int a = 5;
    public bool IsGrounded;
    public float Jump;
    // public Text ScoreText;
    public int jumpForce;
    private Rigidbody rb;
    public float jumpHeight = 7f;
    public bool isGrounded;
    public float NumberJumps = 0f;
    public float MaxJumps = 2;
    public float JumpF;
    public float speed2;
    private bool fov = false;
    //  public float Mass;
    // NavMeshAgent navMeshAgent;


    void Start()
    {

       // if (isGrounded = true)
       //     rb.mass = 1500;
        rb = GetComponent<Rigidbody>();
        //  navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // ScoreText.text = "Score"+ score;



        if (Input.GetKey(KeyCode.W) )
            transform.position += transform.forward * speed * Time.deltaTime;



        if (Input.GetKey(KeyCode.S) )
                transform.position -= transform.forward * speed * Time.deltaTime;


            if (Input.GetKey(KeyCode.A))
            transform.position -= transform.right * speed * Time.deltaTime;



        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W)&& Input.GetKey(KeyCode.LeftShift))     
            {
                
                transform.position += transform.forward * speed2 * Time.deltaTime;
            }
    
            

        /// if (isGrounded = false)
        //    if (e.Control)
        //       rb.mass = Mass;

    
    }
}


       // navMeshAgent.velocity = dir.normalized * moveSpeed;



       