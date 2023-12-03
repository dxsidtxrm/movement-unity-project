using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isgrounded : MonoBehaviour
{
     public jumpcam jc;



    void Update()
    {
        if (GetComponent<CharacterController>().isGrounded)
        {
            jc.isGrounded = true;
        }
        else
        {
            jc.isGrounded = false;
        }






    }
}
