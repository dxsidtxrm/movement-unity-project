using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitcollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   private void Awake()
    {


        Destroy(gameObject, 2f);
        Destroy(this, 2f);


    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); Destroy(this);
    }
    
}
