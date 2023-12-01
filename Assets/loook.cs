using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loook : MonoBehaviour
{



    public Transform c;
    public Transform im;
    public Transform imall;
    public Transform head;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        im.LookAt(c);
        head.LookAt(c);

        //  Vector3 cPosition = new Vector3(c.transform.position.x, transform.position.y, c.transform.position.z);
        imall.LookAt(new Vector3(c.transform.position.x, 0, c.transform.position.z));







    }
}
