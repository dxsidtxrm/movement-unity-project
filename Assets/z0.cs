using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localEulerAngles.z >= 0)
            transform.Rotate(0, 0,0 );
        if (transform.rotation.z <= 0)
            transform.Rotate(0, 0,25 * Time.deltaTime);
    }
}
