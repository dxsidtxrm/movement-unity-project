using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateY : MonoBehaviour
{

    private bool ground=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
            transform.localEulerAngles += new Vector3(360 * Time.deltaTime, 900 * Time.deltaTime, 360 * Time.deltaTime);
    }



}
