using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OtherGO : MonoBehaviour
{

    public float speed = 10f;

    public GameObject gm;


    void Update()
    {
      

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                gm.transform.position += gm.transform.forward * speed * Time.deltaTime;


            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
               gm. transform.position -= gm.transform.forward * speed * Time.deltaTime;


            if (Input.GetKey(KeyCode.A))
            gm.transform.Translate(-1 * speed * Time.deltaTime, 0, 0);


            if (Input.GetKey(KeyCode.D))
            gm.transform.Translate(1 * speed * Time.deltaTime, 0, 0);

    }
}






