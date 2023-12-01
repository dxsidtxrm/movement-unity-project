using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    public float durat=2;
    private Vector3 origpos;
    private float ammount;
    private bool nac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (durat == 0.5f)
        {
       //     if (2f + Time.time >= Time.time + Time.deltaTime)
        //    {
         //       transform.Rotate(50 * Time.deltaTime, 0, 0);
         //   }
            nac =true;
           // durat = Time.time;
        }
        if(durat +1>Time.time)
        {
            
            transform.Rotate(-2 * Time.deltaTime, 0, 0);

        }

        if (nac == true)
        {
            if (2f + Time.time >= Time.time + Time.deltaTime)
            {
              transform.Rotate(5 * Time.deltaTime, 0, 0);
            }
            else
            {
                durat = Time.time;
                nac = false;
            }
               
            
        }


    }
    public void fallshake()
    {
       


    }
}
