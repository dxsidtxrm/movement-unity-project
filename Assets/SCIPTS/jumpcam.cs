using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpcam : MonoBehaviour
{
    public float jumpHeight = 7f;
    private float ti;
    private float got;
    public bool a;
    public float x;
    public bool isGrounded;
    public int max=0;
    public float max2=0;
    public Transform cam;
    private bool fov;
    private float cl;
    private bool ground;
    public GameObject ruki;
    public float clock;
    public float fallimpact;
    [SerializeField]
    private float rukiimpact=1;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
        clock += Time.deltaTime;

        cl += Time.deltaTime * 2;


        if (Time.time > cl)
        {
            ruki.transform.localEulerAngles += new Vector3(rukiimpact * (1.5f - Time.deltaTime*1f), 0, 0);
            cam.transform.localEulerAngles+= new Vector3(fallimpact * (1.5f - Time.deltaTime * 4f), 0, 0);

        }else
            if (cam.transform.localEulerAngles.x <= 0)
        {
         //   cam.transform.Rotate(-20 * Time.deltaTime, 0, 0);
        }

        ti += Time.deltaTime * 4;

        if (Time.time > ti)
        {
            transform.position += transform.up * jumpHeight * Time.deltaTime * (4 - x);
            if (x <= 4)
                x += 0.2f;
        }
        else x = 0;

            if (max2 == 1)
            {
            fallimpact = 0.45f;
            ti = Time.time - 1.5f;
                cl = Time.time - 0.1f;
               // clock = -0.25f;
             // clock = -0.1f;
             //  j.clock = -0.1f;
           }
      



        if (clock > 0.33f)
        if (Input.GetButtonDown("Jump"))
            {
              
                clock = 0;
                max++;
            if (max < 2)
                {
                    fallimpact = 0.3f;
                    ti = Time.time - 1f;
                    
                    cl = Time.time - 0.1f;
                 
            }
               
               


            }


        if (isGrounded == true)
        {

            max2++;
            max = 0;
        }
        else
        {
            max2 = 0;
         
        }
            if (max2 == 1)
            clock = -0.45f;
            



 



        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            fov = true;
        }
        else
            fov = false;


        if (fov == true)
        {
            if (this.GetComponent<Camera>().fieldOfView <= 75f)
                this.GetComponent<Camera>().fieldOfView += Time.deltaTime * 25;
        }
        else
        {

            if (this.GetComponent<Camera>().fieldOfView > 70.10f)
            {
                this.GetComponent<Camera>().fieldOfView -= Time.deltaTime * 75;
            }
            if (this.GetComponent<Camera>().fieldOfView < 70f)
            {
                this.GetComponent<Camera>().fieldOfView += Time.deltaTime /2 ;
            }



        }








    }


    
}
