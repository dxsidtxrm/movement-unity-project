using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;



public class shoot : MonoBehaviour
{
    private float ti;
    public float firerate;

    public Transform cam;
    public Transform dulo;
    public GameObject bulletPrefab;
    public float shotSpeed;
    public float des;
    public float dist;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit, 1000))
        {
            dulo.LookAt(hit.point);
        }

            if (Input.GetMouseButtonDown(0))
            if (Time.time > ti)
            {
                ti = Time.time + firerate;
                GameObject bullet = Instantiate(bulletPrefab, dulo.transform.position, dulo.transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = transform.forward * shotSpeed;
                Destroy(bullet, 0.3f);
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out  hit, 1000))
                {
                    dulo.LookAt(hit.point);
                    if (Time.time>des)
                    {
                        des = Time.time+ Time.deltaTime;
                        dist = (Vector3.Magnitude(hit.transform.position - dulo.transform.position)) / shotSpeed*100;
                        if ((Vector3.Magnitude(hit.transform.position - dulo.transform.position)) / shotSpeed <= 0.7f ||  hit.point == null)
                            des = Time.time - 0.3f;
                        else
                        {
                            des = Time.time - (Vector3.Magnitude(hit.transform.position - dulo.transform.position)) / shotSpeed;
                           
                        }
                       
                    }
                }
               
           //     Destroy(bullet, 0.5f);


            }

    }
}
