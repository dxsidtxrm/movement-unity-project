using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class jump : MonoBehaviour
{
    public float fireRate = 1f;
    public float fireRate2 = 1f;
    private float nextFire = 0f;
    private float nextFire2 = 0f;
    public GameObject shh;
    public float Jump;
    public int jumpForce;
    public Rigidbody rb;
    public float jumpHeight = 7f;
    public bool isGrounded;
    public float NumberJumps = 0f;
    public float MaxJumps = 2;
    public float JumpF;    public float JumpD=10000f;
    public float JumpSH;    
    public float speed2;
    public float speed;
    private float emit;
   // public GameObject c;
   // public GameObject ju;
   // public GameObject sh;
  //  public GameObject ss;
  //  public Transform hit;
  //  public Transform hit1;
    private bool a = true;
    private bool e = true;
    private int i;
    public Camera myCamera;
    public float fieldOfView = 60f;
    private bool fov = false;
    public float clock;
    public float cl;
    private Vector3 spx;
    CharacterController controller;
    private Vector3 vel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // hit = GetComponent<Transform>();
        //   hit1 = GetComponent<Transform>();
        // shh.SetActive(false);
        //cam=myCamera.GetComponent<Camera>();
        //  ju.SetActive(false);
        controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {


        if (fov == true)
            if (myCamera.GetComponent<Camera>().fieldOfView >= 70f)
            {
                myCamera.GetComponent<Camera>().fieldOfView -= Time.deltaTime * 1000;
            }
            else fov = false;









        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W))
        {
            if (Input.GetButtonDown("Jump"))
                if (isGrounded || NumberJumps == 1)
                    if (clock > 0.35f)
                    {

                        if (Input.GetKey(KeyCode.W))
                        {


                            rb.AddForce(Vector3.up * jumpHeight * 2); rb.AddForce(transform.forward * JumpF);
                            //rb.AddForce(Vector3.forward * jumpHeight);
                            NumberJumps += 1; clock = 0;
                            //  Instantiate(ju, hit);

                        }



                        if (Input.GetKey(KeyCode.S))
                        {


                            rb.AddForce(Vector3.up * jumpHeight * 2); rb.AddForce(-transform.forward * JumpF);
                            //rb.AddForce(Vector3.forward * jumpHeight);
                            NumberJumps += 1; clock = 0;
                            //     Instantiate(ju, hit);


                        }

                        if (Input.GetKey(KeyCode.A))
                        {


                            rb.AddForce(Vector3.up * jumpHeight * 2); rb.AddForce(-transform.right * JumpF);
                            //rb.AddForce(Vector3.forward * jumpHeight);
                            NumberJumps += 1; clock = 0;
                            //  Instantiate(ju, hit);


                        }

                        if (Input.GetKey(KeyCode.D))
                        {


                            rb.AddForce(Vector3.up * jumpHeight * 2); rb.AddForce(transform.right * JumpF);
                            //rb.AddForce(Vector3.forward * jumpHeight);
                            NumberJumps += 1; clock = 0;
                            //  Instantiate(ju, hit);

                        }

                    }
        }
        else
        {
            if (Input.GetButtonDown("Jump"))
                if (isGrounded || NumberJumps == 1)
                    if (clock > 0.35f)
                    {
                        rb.AddForce(Vector3.up * jumpHeight);
                        rb.AddForce(Vector3.up * jumpHeight);
                        //rb.AddForce(Vector3.forward * jumpHeight);
                        NumberJumps += 1;
                        clock = 0;
                    }
               
        }

      




         clock += Time.deltaTime;

        if (NumberJumps == 1)
            jumpHeight = 3222;
        else jumpHeight = 2222;

        if (isGrounded == true)
            cl++;
        else
            cl = 0;

        if (cl == 1)
            clock = -0.25f;




        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {




            if (Input.GetKey(KeyCode.LeftControl) && Time.time > nextFire)
            {







                if (Input.GetKey(KeyCode.W))
                {
                    rb.AddForce(transform.forward * JumpD);
                    nextFire = Time.time + 1f / fireRate;
                myCamera.GetComponent<Camera>().fieldOfView =95f;
                  Invoke("KILL", 0.1f);

                }
                if (Input.GetKey(KeyCode.S))
                {
                    rb.AddForce(-transform.forward * JumpD); nextFire = Time.time + 1f / fireRate;
           myCamera.GetComponent<Camera>().fieldOfView = 80f;
                 Invoke("KILL", 0.1f);

                }

                if (Input.GetKey(KeyCode.A))
                {
                    rb.AddForce(-transform.right * JumpD); nextFire = Time.time + 1f / fireRate;
                  myCamera.GetComponent<Camera>().fieldOfView =80f;
                  Invoke("KILL", 0.1f);

                }

                if (Input.GetKey(KeyCode.D))
                {
                    rb.AddForce(transform.right * JumpD); nextFire = Time.time + 1f / fireRate;
                    myCamera.GetComponent<Camera>().fieldOfView =80f;
              Invoke("KILL", 0.1f);

                }

            }
        }else
        if (Input.GetKey(KeyCode.LeftControl) && Time.time > nextFire)
        {
            rb.AddForce(transform.forward * JumpD); nextFire = Time.time + 1f / fireRate;
          myCamera.GetComponent<Camera>().fieldOfView = 90f;
         Invoke("KILL", 0.1f);
           
        }



                if (NumberJumps == 0)
                if (Input.GetKey(KeyCode.W))
                    if (Input.GetKey(KeyCode.LeftShift))
                    {
                        transform.position += transform.forward * speed2 * Time.deltaTime;
                   //     shh.SetActive(true);
                       
                    }


        // if (Input.GetKeyUp(KeyCode.LeftShift) || (Input.GetKeyUp(KeyCode.W)))
        //   shh.SetActive(false);





            if (Input.GetMouseButtonDown(4))
        {

            GetComponent<Rigidbody>().drag =20f;
        }
        if (Input.GetMouseButtonUp(4))
        {

            GetComponent<Rigidbody>().drag = 0.2f;
        }





        //  c.vec = new Vwctor3(0, 0, 5);
        if (Input.GetKeyDown(KeyCode.LeftShift))
            JumpF += JumpSH;
        if (Input.GetKeyUp(KeyCode.LeftShift))
             JumpF -= JumpSH;

       

       


        if (NumberJumps > MaxJumps - 1)
        {
            isGrounded = false;
        }
    }
    


    void KILL()
    {
        GetComponent<Rigidbody>().isKinematic = true; GetComponent<Rigidbody>().isKinematic = false ;
        fov = true;

    }

  



}

