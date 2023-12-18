using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System;



public class shoot : MonoBehaviour
{
    [SerializeField]
    private Transform BulletSpawnPoint;
    [SerializeField]
    private TrailRenderer BulletTrail; 
    private float ti;
    [SerializeField]
    private float firerate;
    [SerializeField] private bool AddBulletSpread = true;
    [SerializeField]
    private Transform cam;
    [SerializeField]
    private Transform dulo;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float shotSpeed;
    [SerializeField]
    private float des;
    [SerializeField]
    private float dist;
    [SerializeField]
    private GameObject hiteff;
    [SerializeField]
    private GameObject ligh;
    [SerializeField]
    private Transform hol;
    [SerializeField] 
    private float force;
    [SerializeField]
    private float tm;
    [SerializeField]
    private bool bulletstop=true;
    [SerializeField]
    private Quaternion rotat;
    [SerializeField]
    private GameObject mainpers;
    [SerializeField]
    private float q1;
    [SerializeField]
    private float q2;
    [SerializeField]
    private Vector3 BulletSpreadVariance = new Vector3(0.1f, 0.1f, 0.1f);
    [SerializeField] private GameObject part;
    [SerializeField] private GameObject particl;
    [SerializeField]
    private Transform ruki;
    [SerializeField]
    private Transform preruki;
    [SerializeField] private float rlerp=0.03f;
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private float shootimpact;
    private float cl;
    [SerializeField] private
    Transform gilz;
    [SerializeField] private GameObject gilzpref;
    [SerializeField]
    private Vector3 gilzvec;
    [SerializeField]
    private float fovshoot;
    [SerializeField]
    private ParticleSystem[] muzlflashes;[SerializeField]
    private GameObject muzlflash;
    [SerializeField]
    private GameObject muzlexpl;
    [SerializeField]
    private GameObject smokepref;
    [SerializeField]
    private GameObject smokeUp;
    [SerializeField]
    private GameObject smokeUp3;
    [SerializeField]
    private Transform muzltrans;
    [SerializeField]
    private LayerMask layerMask;
    [SerializeField] Transform smoke;
    void Start()
    {
        //  prefmuzlflash = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        cl += Time.deltaTime * 2;
        RaycastHit hit;
        //gilzvec = transform.TransformDirection(gilzvec);


        if (Input.GetMouseButton(0))
        {

            if (Time.time > ti)
            {
                ti = Time.time + firerate;
                shot(); if (Time.time > cl)
                    cam.transform.localEulerAngles -= new Vector3(shootimpact * (1.8f - Time.deltaTime * 8f), 0, 0);
                cam.GetComponent<Camera>().fieldOfView += shootimpact * (1.8f - Time.deltaTime * 8f);



              
               // for (int i = 0; i != null; i++)
              //  {
               //     ParticleSystem muzl = Instantiate(muzlflashes[i], muzltrans.transform.position, muzltrans.transform.rotation);
                 //   Destroy(muzl, 2);//Õ»’”ﬂ ›“¿ ’”…Õﬂ Õ≈ –¿¡Œ“¿≈“ ¡Àﬂ“‹ ≈¡¿Õ€≈÷» À€
               // }
            
                //≈¡¿ÿ»Ã œŒ Œ“ƒ≈À‹ÕŒ—“»  ¿∆ƒ€… œ¿–“» À ..”¬€


                //ƒ€Ã
                GameObject smok = Instantiate(smokepref, muzltrans.transform.position, muzltrans.transform.rotation);
                Destroy(smok, 3f);
                //ƒ”À‹Õ¿ﬂ ¬—œ€ÿ ¿
                GameObject muzlfl = Instantiate(muzlflash, muzltrans.transform.position, muzltrans.transform.rotation);
                Destroy(muzlfl, 0.3f);
                //¬«–€¬ » ¬—ﬂ ¿ﬂ ’”…Õﬂ
                GameObject expl = Instantiate(muzlexpl, muzltrans.transform.position, muzltrans.transform.rotation);
                Destroy(expl, 3);
                //‰˚Ï ÏÂ‰ÎÂÌÌ˚È ‰ÓÎ„ËÈ ‚‚Âı 
                GameObject smoke2 = Instantiate(smokeUp, muzltrans.transform.position, muzltrans.transform.rotation);
                Destroy(smoke2, 3);
                GameObject smoke3 = Instantiate(smokeUp3, muzltrans.transform.position, muzltrans.transform.rotation);
                Destroy(smoke3, 3);

                //  muzlexpl.Play();

                //smokepref.Play();
                GameObject gilza = Instantiate(gilzpref, gilz.transform.position, gilzpref.transform.rotation);
                gilza.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(gilzvec+new Vector3(90,0,40)));
                //   gilza.transform.localEulerAngles=new Vector3(0, 0,360 * Time.deltaTime);
              //  gilza.GetComponent<Rigidbody>().MoveRotation(Quaternion.identity) ;
                Destroy(gilza, 2f); 
                Vector3 direction = GetDirection();
                if (Physics.Raycast(cam.transform.position, direction, out hit, 1000,layerMask))
                {
                    if (hit.point != null)
                        dulo.LookAt(hit.point);
                      //  ruki.LookAt(hit.point);
                    int a = 0;
                    TrailRenderer trail = Instantiate(BulletTrail, BulletSpawnPoint.position, Quaternion.identity);
          
                    StartCoroutine(SpawnTrail(trail, hit.point, hit.normal, true));

                   

                    GameObject hitimpact = Instantiate(hiteff, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(hitimpact, 0.6f);

                    if (hit.collider.gameObject.GetComponent<Rigidbody>())
                        hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force * 100);

                    GameObject light = Instantiate(ligh, hit.point, Quaternion.LookRotation(hit.normal));
                    Destroy(light, 0.05f);
                    Quaternion hitdirect = Quaternion.FromToRotation(Vector3.up, hit.normal);
                   
                   

                    dist = (Vector3.Distance(hit.point, dulo.transform.position));

                    if (Time.time > des)
                    {
                        des = Time.time + Time.deltaTime;

                        if ((Vector3.Magnitude(hit.transform.position - dulo.transform.position)) / shotSpeed <= 0.7f || hit.point == null)
                            des = Time.time - 0.3f;
                        else
                        {
                            des = Time.time - (Vector3.Magnitude(hit.point - dulo.transform.position)) / shotSpeed;

                        }
                    } 
            
                   
                    Transform hole = Instantiate(hol, hit.point+(hit.normal*0.001f), Quaternion.LookRotation(hit.normal)) as Transform;
                    hole.parent = hit.transform;
               //    Destroy(bullet, 2f);
                   Destroy(hole, 20);


                }
                else
                {

                    dulo.transform.localEulerAngles = new Vector3(UnityEngine.Random.Range(2, -2),
                                                                                                          UnityEngine.Random.Range(0, -2),
                                                                                                          UnityEngine.Random.Range(2, -2));
                    dist = float.PositiveInfinity;
                }
                GameObject bullet = Instantiate(bulletPrefab, dulo.transform.position, dulo.transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = dulo.transform.forward * shotSpeed;
              //  if (bullet.GetComponent<Rigidbody>().detectCollisions) Destroy(bullet);



                rotat = Quaternion.LookRotation(hit.normal);
              
                q2 = rotat.y;
               



            }
            else unshot();

        }
        q1 = mainpers.transform.rotation.y;
        if (Physics.Raycast(cam.transform.position, Vector3.forward, out hit, 200, layerMask))
            preruki.LookAt(hit.point);
        else preruki.transform.localEulerAngles = new Vector3(0, 0, 0);

            if (preruki.transform.localEulerAngles.y < 355f && preruki.transform.localEulerAngles.y !=0)
            {
                rlerp = 0;
            }
            else rlerp = 0.03f;
        ruki.transform.rotation = Quaternion.Lerp(ruki.transform.rotation, preruki.rotation, rlerp);
       
    }


    private Vector3 GetDirection()
    {
        Vector3 direction = transform.forward;

        if (AddBulletSpread)
        {
            direction += new Vector3(
                UnityEngine.Random.Range(-BulletSpreadVariance.x, BulletSpreadVariance.x),
              UnityEngine.Random.Range(-BulletSpreadVariance.y, 0),
            UnityEngine.Random.Range(-BulletSpreadVariance.z, BulletSpreadVariance.z)
            );

            direction.Normalize();
        }

        return direction;
    }

    private IEnumerator SpawnTrail(TrailRenderer Trail, Vector3 HitPoint, Vector3 HitNormal, bool MadeImpact)
    {
        // This has been updated from the video implementation to fix a commonly raised issue about the bullet trails
        // moving slowly when hitting something close, and not
        Vector3 startPosition = Trail.transform.position;
        float distance = Vector3.Distance(Trail.transform.position, HitPoint);
        float remainingDistance = distance;

        while (remainingDistance > 0)
        {
            Trail.transform.position = Vector3.Lerp(startPosition, HitPoint, 1 - (remainingDistance / distance));

            remainingDistance -= shotSpeed * Time.deltaTime;

            yield return null;
        }
        Trail.transform.position = HitPoint;


        Destroy(Trail.gameObject, 1.2f);
    }
    private void shot()
    {
        anim.SetBool("shoot", true); cl = Time.time - 0.1f;

    }
    private void unshot()
    {
        anim.SetBool("shoot", false);
    }




}

