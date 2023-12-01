using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class move : MonoBehaviour
{

    private Vector3 vel;
    public Rigidbody rb;
    private CharacterController controller;
    private Vector3 mov;
    private Vector3 playerVelocity;
    public bool groundedPlayer;
    private float playerSpeed = 1f;
    private float jumpHeight = 10;
    private float gravityValue = -16f; 
    public float clock;
    public float cl;
    public float NumberJumps = 0f;
    public float vert=0;
    private float sum;
    private Vector3 vec;
    public float hui;
    public float jum=0;
    public float jumx=0;
    private float consdt;
    private float zzz=1;
    private float xxx=1;
    public float fps;
    [SerializeField]
    private TextMeshProUGUI mtext;
    private float tm;
    [SerializeField]
    private int LIMIT_FPS;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = LIMIT_FPS;
        controller = GetComponent<CharacterController>();
    }
    
    // Update is called once per frame
    void Update()
    {
        tm += Time.deltaTime;

        if (tm > 0.1f)
        {
            mtext.text = (Mathf.Floor(1 / Time.deltaTime)).ToString();tm = 0;

        }
        groundedPlayer = controller.isGrounded;

        jum =jum/(1+Mathf.Abs( Input.GetAxis("Mouse X")) /50);
        jumx =jumx/(1+Mathf.Abs( Input.GetAxis("Mouse X")) /50);

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0;
        }

       
        if (jum >0)
        {
            if (vert == 1)
                jum -=hui;
        }
        else
        {
            vert = 0;
            jum = 0;
            zzz = 1;
        }
        if (jumx >0)
        {
            if (vert == 1)
                jumx -=hui;
        }
        else
        {
            vert = 0;
            jumx = 0;
            xxx = 1;
        }





        





        if (vert==1)
        hui += Time.deltaTime/36 ;


        if (!groundedPlayer)
            consdt = 6.66f;
        else
            consdt = 15;

        mov = new Vector3(Input.GetAxisRaw("Horizontal") * consdt+jumx*15*xxx, 0, Input.GetAxisRaw("Vertical") * consdt + jum*15*zzz );
            mov = transform.TransformDirection(mov);
        //  mov = transform.InverseTransformPoint(mov);
        controller.Move(mov * Time.deltaTime* playerSpeed);

      

        if  ( Input.GetKey(KeyCode.LeftShift) && (Input.GetAxisRaw("Horizontal")!=0|| Input.GetAxisRaw("Vertical")!=0))
        {
            if (playerSpeed <= 1.66f)
                if (groundedPlayer)
                    playerSpeed += Time.deltaTime;
        }              
        else playerSpeed = 1;



        if (playerSpeed > 0 && !groundedPlayer)
            playerSpeed -= Time.deltaTime / 2;
        else
          if (playerSpeed <= 1)
            if (!Input.GetKey(KeyCode.LeftShift))
                playerSpeed += Time.deltaTime;




        playerVelocity.y += gravityValue * Time.deltaTime*3.5f; 
        controller.Move(playerVelocity * Time.deltaTime);




        if (groundedPlayer)
            cl++;
        else
            cl = 0;

        if (cl == 1)
        {clock = -0.467f;   NumberJumps = 0;
            jum = 0;
            jumx = 0;
        }

        clock += Time.deltaTime;


        if (Input.GetButtonDown("Jump") && (groundedPlayer || NumberJumps == 1) && clock > 0.33f)
        {
            if ((Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0))
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -2.5f * gravityValue);

                if (Input.GetKey(KeyCode.W))
                {
                    vert = 1;
                    consdt = 1;
                    jum= 1.33f;
                    hui = 0;
                    NumberJumps += 1; clock = 0;
                    zzz = 1; jumx = 0;
                }



                if (Input.GetKey(KeyCode.S))
                {
                    vert = 1;
                    consdt = 1;
                    jum = Random.Range(1f,1.33f) ;
                    hui = 0;
                    NumberJumps += 1; clock = 0;
                    zzz = -1; jumx = 0;

                }

                if (Input.GetKey(KeyCode.A))
                {
                   
                    vert = 1;
                    consdt = 1;
                    jumx = Random.Range(1f, 1.33f);
                    hui = 0;
                    NumberJumps += 1; clock = 0;
                    xxx = -1; jum = 0;
                }

                if (Input.GetKey(KeyCode.D))
                {
                    vert = 1;
                    consdt = 1;
                    jumx = Random.Range(1f, 1.33f);
                    hui = 0;
                    NumberJumps += 1; clock = 0;
                    xxx = 1; jum = 0;
                }


            }
            else
            {
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3f * gravityValue);
                NumberJumps += 1;
                clock = 0;
                
            }
        }

        if (NumberJumps == 1)
            jumpHeight = 16.6f;
        else jumpHeight =10;


        if (Input.GetKey(KeyCode.W))
            if (Physics.Raycast(this.transform.position, this.transform.forward, out RaycastHit hit,2f)) 
                if(!groundedPlayer )
                    jum = 0.25f;

        if (Input.GetKey(KeyCode.S))
            if (Physics.Raycast(this.transform.position, -this.transform.forward, out RaycastHit hit, 2f))
                if (!groundedPlayer)
                    jum = 0.25f;

        if (Input.GetKey(KeyCode.A))
            if (Physics.Raycast(this.transform.position, -this.transform.right, out RaycastHit hit, 2f))
                if (!groundedPlayer)
                    jumx = 0.25f;

        if (Input.GetKey(KeyCode.D))
            if (Physics.Raycast(this.transform.position, this.transform.right, out RaycastHit hit, 2f))
                if (!groundedPlayer)
                    jumx = 0.25f;









    }
    

     


}
