using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowww : MonoBehaviour
{




    public Transform target;
    public float speed;
    //public Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
    }
}
