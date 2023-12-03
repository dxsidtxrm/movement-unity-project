using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adad : MonoBehaviour
{
    public float qw;
    private bool back;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((!(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)) && !(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A)))&&(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
            {

            if (Input.GetKey(KeyCode.D))
            {
                this.transform.localEulerAngles = new Vector3(0, 0, -2);
            }

            if (Input.GetKey(KeyCode.D)&& Input.GetKey(KeyCode.W))
            {
                this.transform.localEulerAngles = new Vector3(0, 0, -1);
            }
            if (Input.GetKey(KeyCode.A))
            {  
                    this.transform.localEulerAngles = new Vector3(0, 0, 2);
            }
            if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S)))
            {
                this.transform.localEulerAngles = new Vector3(0, 0, 1);
            }


                if (!(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)))
                if (!(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)))
                    if (Input.GetKey(KeyCode.W))
            {
                this.transform.localEulerAngles = new Vector3(-1, 0, 0);
            }


                if (!(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)))
                    if (!(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)))
                        if (Input.GetKey(KeyCode.S))
            {
                this.transform.localEulerAngles = new Vector3(0.66f, 0, 0);
            }

           }
        else this.transform.localEulerAngles = new Vector3(0, 0, 0);
   
    }
}
