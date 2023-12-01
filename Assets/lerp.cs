
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerp : MonoBehaviour
{
    public Transform target;
    public float pLerp = .01f;
    public float rLerp ;


    // public float turnSpeed = 0.01f;
    // public float speed = 1f;
    //Quaternion rotgoal;
    //Vector3 direction;
    //  public Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // direction = (target.position - transform.position).normalized;
        //  rotgoal = Quaternion.LookRotation(direction);
        //   transform.rotation = Quaternion.Slerp(transform.rotation, rotgoal, turnSpeed);
        //  transform.position = Vector3.Smooth(transform.position, target.position,ref velocity, speed*Time.deltaTime);


         transform.position = Vector3.Lerp(transform.position, target.position, pLerp);
        
       //      rotationy -= Input.GetAxis("Mouse Y") * sensitivityVert;
        //     rotationx -= Input.GetAxis("Mouse X") * sensitivityHor;
        //    rotationy = Mathf.Clamp(rotationy, minimumVert, maximumVert);
          //  rotationx = Mathf.Clamp(rotationx, minimumHor, maximumHor);
          //  transform.localEulerAngles = new Vector3(rotationx, rotationy, 0);
       // if (transform.localEulerAngles.y>Mathf.Abs(10f));
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, rLerp);
    
    //    if (transform.rotation.y >= 20 || transform.rotation.x >= 20 || transform.rotation.x <=- 20 || transform.rotation.y<=- 20)
        //    rLerp =2;
      //  else
         //   rLerp = 0.05f;
      
    }
}
