using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




public class move : MonoBehaviour
{

    private Vector3 vel;
    private CharacterController controller;
    private Vector3 mov;
    private Vector3 playerVelocity;
    [SerializeField]
    private bool groundedPlayer;
    private float playerSpeed = 1f;
    private float jumpHeight = 15;
    private float gravityValue = -16f;
    [SerializeField]
    private float clock;
    [SerializeField]
    private float cl;
    [SerializeField]
    private float NumberJumps = 0f;
    [SerializeField]
    private float vert=0;
    private float sum;
    private Vector3 vec;
    [SerializeField]
    private float hui;
    [SerializeField]
    private float jum=1;
    [SerializeField]
    private float jumx=1;
    private float consdt;
    private float zzz=1;
    private float xxx=1;
    [SerializeField]
    private float fps;
    [SerializeField]
    private TextMeshProUGUI mtext;
    private float tm;
    [SerializeField]
    private int LIMIT_FPS;
    [SerializeField] private bool tru;
    [SerializeField] private bool wallju;
    [SerializeField]
    private bool walljump = false;
void Start()
    {
        
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
            mtext.text = (Mathf.Floor(1 / Time.deltaTime)).ToString(); tm = 0;

        }
        groundedPlayer = controller.isGrounded;

        jum = jum / (1 + Mathf.Abs(Input.GetAxis("Mouse X")) / 50);
        jumx = jumx / (1 + Mathf.Abs(Input.GetAxis("Mouse X")) / 50);

        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0;
        }






        if (Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") != 0)
            if (consdt <=1)
        {
            consdt += Time.deltaTime*1.25f;
        } 
        if (Mathf.Abs(Input.GetAxis("Horizontal"))+Mathf.Abs( Input.GetAxis("Vertical"))== 0)
            if (consdt > 0.2f)
                consdt -= Time.deltaTime*5;





        if (vert == 1)
            hui += Time.deltaTime / 36;




        mov = new Vector3(Input.GetAxisRaw("Horizontal")*consdt , 0, Input.GetAxisRaw("Vertical") * consdt) *15;
        mov = transform.TransformDirection(mov);
        //  mov = transform.InverseTransformPoint(mov);
        controller.Move(mov * Time.deltaTime * playerSpeed);



        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0))
        {
            if (playerSpeed <= 1.66f)
                if (groundedPlayer)
                    playerSpeed += Time.deltaTime;
        }
        else playerSpeed = 1;

        if (!groundedPlayer)
            playerSpeed = 1f;






        playerVelocity.y += gravityValue * Time.deltaTime * 3.5f;
        controller.Move(playerVelocity * Time.deltaTime);




        if (groundedPlayer)
            cl++;
        else
            cl = 0;

        if (cl == 1)
        { clock = -0.467f; NumberJumps = 0;
            jum = 0;
            jumx = 0;
        }

        clock += Time.deltaTime;


        if (Input.GetButtonDown("Jump") && (groundedPlayer || NumberJumps == 1) && clock > 0.33f)
        { 
        playerVelocity.y += Mathf.Sqrt(jumpHeight * -3f * gravityValue);
        NumberJumps += 1;
        clock = 0;
        }
   

        if (NumberJumps == 1)
            jumpHeight = 15;
        else jumpHeight =12;

        if (walljump == true)
        {



            if (Physics.Raycast(this.transform.position, this.transform.forward, out RaycastHit hit, 2f))
            {


                if (Input.GetKey(KeyCode.W))
                    if (!groundedPlayer)
                        jum = 0.25f;

                if (Input.GetKey(KeyCode.S))
                    if (!groundedPlayer)
                        jum = 0.25f;

                if (Input.GetKey(KeyCode.A))
                    if (!groundedPlayer)
                        jumx = 0.25f;

                if (Input.GetKey(KeyCode.D))
                    if (!groundedPlayer)
                        jumx = 0.25f;

            }
            if (wallju == true)
                if (Physics.Raycast(this.transform.position, -this.transform.right, out RaycastHit hit2, 1f) && !groundedPlayer)
                {
                    Quaternion rotat = Quaternion.LookRotation(hit2.normal);
                    if ((Mathf.Abs(Mathf.Abs(this.transform.rotation.y) - Mathf.Abs(rotat.y)) < 0.6f) || (Mathf.Abs(Mathf.Abs(this.transform.rotation.y) - Mathf.Abs(rotat.y)) > 0.4f) && Input.GetAxis("Vertical") == 1)
                    {
                        tru = true;

                        gravityValue = -2;
                        jum = 1.5f;
                        if (wallju == true)
                            if (Input.GetButtonDown("Jump"))
                            {

                                jumx = 1.5f; playerVelocity.y += 42;
                                jum = 1.8f;
                                xxx = 1; wallju = false;
                            }
                    }
                    else tru = false;



                }
                else
                {
                    wallju = false;
                    tru = true;
                    gravityValue = -16;
                }
            if (wallju == true)
                if (Physics.Raycast(this.transform.position, this.transform.right, out RaycastHit hit1, 1f) && !groundedPlayer)
                {
                    Quaternion rotat2 = Quaternion.LookRotation(hit1.normal);
                    if ((Mathf.Abs(Mathf.Abs(this.transform.rotation.y) - Mathf.Abs(rotat2.y)) < 0.7f) || (Mathf.Abs(Mathf.Abs(this.transform.rotation.y) - Mathf.Abs(rotat2.y)) > 0.4f) && Input.GetAxis("Vertical") == 1)
                    {
                        tru = true;
                        gravityValue = -2;
                        jum = 1.5f;
                        if (wallju == true)
                            if (Input.GetButtonDown("Jump"))
                            {


                                jum = 1.8f; jumx = 1.5f; xxx = -1; playerVelocity.y += 42; wallju = false;
                            }

                    }
                    else tru = false;



                }
                else
                {
                    tru = false;
                    wallju = true;
                    gravityValue = -16;
                }


            if (groundedPlayer) wallju = true;

        }
    }
    

     


}
