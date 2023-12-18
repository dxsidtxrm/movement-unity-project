using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quq : MonoBehaviour
{ 
    public float range = 15f;
    public Camera _cam;
    public Camera MAC;
    public Transform quad;
    private int z = 1;
    public ParticleSystem muz;
    public ParticleSystem notmuz;
    public float fireRate = 1f;
    public float nextFire = 1f;
    public float a ;
    public Transform cub;
    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time + 1f / fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetMouseButtonDown(1))
            z += 1;


        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        nextFire = Time.time + 1f / fireRate;

        if (z % 2 == 1)
        {
            if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
                muz.Play();
           // nextFire = Time.time + 1f / fireRate;
        }
        else
        {
            if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
                notmuz.Play();
           // nextFire = Time.time + 1f / fireRate;
        }


        if (z % 2 == 1)
        {
            if (Physics.Raycast(_cam.transform.position, _cam.transform.forward, out hit, range))
            {
                quad.LookAt(hit.point);
                cub.LookAt(hit.point);
                cub.transform.Rotate(0, 0.3f, 0);

            }
            if (Input.GetKeyDown(KeyCode.D))
            {
              //  cub.transform.Rotate(0, a, 0);
               // quad.transform.Rotate(0, a, 0);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
              //  cub.transform.Rotate(0, -a, 0);
                //quad.transform.Rotate(0, -a, 0);
            }


            //  if (Input.GetMouseButtonDown(0) && Time.time > nextFire)

            //   muz.Play();
            //  nextFire = Time.time + 1f / fireRate;
        }

        if (z % 2 == 0)
        {
            if (Physics.Raycast(MAC.transform.position, MAC.transform.forward, out hit, range))
            {
                quad.LookAt(hit.point);
                cub.LookAt(hit.point);
                cub.transform.Rotate(0, 0.3f, 0);

            }

            //  if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
            //  nextFire = Time.time + 1f / fireRate;
            //  notmuz.Play();
        }





    }
}
