using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isgrounded : MonoBehaviour
{
    public jump ju;
    public jumpcam jc;
    public Collider box;


    void Update()
    {
        if (GetComponent<CharacterController>().isGrounded)
        {
            ju.isGrounded = true;
            jc.isGrounded = true;
           // ju.NumberJumps = 0;


        }
        else
        {
            ju.isGrounded = false;
            jc.isGrounded = false;

        }






    }
}
