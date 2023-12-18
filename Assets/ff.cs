using System.Collections;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;
using System.Collections.Generic;


public class ff : MonoBehaviour
{
    public AudioSource _audioSource;
    public AudioClip laa;
    public Transform cam; private RaycastHit hit;
    private bool la = true;
    void Start()
    {
        _audioSource.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.F))
        {
            la = !la;
            // _audioSource.PlayOneShot(laze);

        }
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 1000))
        {//&& Time.time > nextFire)
            if (hit.collider.name == "UlLL2")
            {
                if (la == false)
                    _audioSource.PlayOneShot(laa);


            }
            if ((la != false) || (hit.collider.name != "UlLL2"))


                _audioSource.Stop();
        }
    }
}
