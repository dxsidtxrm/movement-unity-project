using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
            rb.mass += 1000000;
    }
}
