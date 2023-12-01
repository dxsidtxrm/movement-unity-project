using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpinfluence : MonoBehaviour
{
    public float speed;
    public bool ready;
    private float cl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ready == true)
        {
            cl = Time.time - 0.1f;
        }

        cl +=  Time.deltaTime*5;

       if(Time.time>cl)
            {
            transform.localEulerAngles+= new Vector3(0.95f*(1-Time.deltaTime), 0, 0);

        }
        
      

      
       

    }
}
