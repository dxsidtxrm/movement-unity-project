
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpy : MonoBehaviour
{
    public int a;
    public bool нет = false;
    public Transform target;
    public float pLerp = .01f;
    public float rLerp = .01f;
    public float turningRate = 30f;
    // Rotation we should blend towards.
    private Quaternion _targetRotation = Quaternion.identity;
    // Call this when you want to turn the object smoothly.
    public void SetBlendedEulerAngles(Vector3 angles)
    {
        _targetRotation = Quaternion.Euler(angles);
    }

    // Update is called once per frame
    void Update()
    {
        // direction = (target.position - transform.position).normalized;
        //  rotgoal = Quaternion.LookRotation(direction);
        //   transform.rotation = Quaternion.Slerp(transform.rotation, rotgoal, turnSpeed);
        //  transform.position = Vector3.Smooth(transform.position, target.position,ref velocity, speed*Time.deltaTime);


         transform.position = Vector3.Lerp(transform.position, target.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, rLerp);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _targetRotation, turningRate * Time.deltaTime);




        
    }
}
