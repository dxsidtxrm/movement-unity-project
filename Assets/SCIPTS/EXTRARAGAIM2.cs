using System.Collections;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UI;
using System.Collections.Generic;


public class EXTRARAGAIM2 : MonoBehaviour
{
    //  public Animator anim;
    //public Transform head;
    // public Text MText;
    public GameObject chii;
    public GameObject hr;
    private bool додик = true;
    public float col=2;
    public GameObject bodyMPREF; public GameObject bodyPREF;
    public GameObject headPREF;
    public VisualEffect blood;
    private float B = 1;
    private float A = 1;
    public float range = 10f;
    public Transform MAC;
    public GameObject hachd;
    public float force = 100;
    public Transform cam;
    private Rigidbody[] rb_AR;
    private RaycastHit hit;
    public float y;
    public float x;
    public int activeDistance = 10;
    public Transform[] wayPoints;
    public float stoppingDistance = 5;
    public float timeWait = 3;
    public float rotationSpeed = 5;
    public Rigidbody[] r_A;
    private Vector3 target;
    private float curTimeout;
    private int wayCount;
    private bool isTarget;
    public float fireRate = 1f;
    private float nextFire = 0f;
    public string a;
    public string s;
    public string d;
    public string f;
    public float start;
    public float end;
    public int qwqw = 2;
    public GameObject hitblood;
    //CharacterJoint joint;
    public CharacterJoint leg;
    public CharacterJoint hipsll;
    public CharacterJoint hipsrr;
    public CharacterJoint kneell;
    public CharacterJoint kneerr;
    public CharacterJoint footll;
    public CharacterJoint footrr;
    public int z = 1;
    public GameObject body;
    public GameObject bodyM;
    public GameObject head1;
    public GameObject KneeL;
    public GameObject KneeR;
    public GameObject FootL;
    public GameObject FootR;
    public GameObject bul;
    public GameObject kill;
    public GameObject UI;
    public AudioClip m1;
    public AudioClip m2;
    public AudioClip m3;
    public AudioClip m4;
    public AudioClip m5;
    public AudioClip m6;
    public AudioSource _audioSource;
    public AudioSource audioSource;
    private float H = 1;
    public GameObject hitEffect;
    public GameObject hitEffect2;
    public Transform head;
    public AudioClip mm;
    public AudioClip shotSFX;
    public score S;
    public GameObject met;
    private bool la=true;
    public int lazer;
    public GameObject laz;
    public AudioClip laze;
    public GameObject bl; public GameObject li;
    private bool sv=false;
    private float svvvv=0;
    private bool die = false;

    private float st = 1;
    public GameObject stoPREF;
    public GameObject sto;
    public GameObject UII;
    public Transform U;
    public Text mText;
    public int p;
    public GameObject bbodypre;
    public GameObject hedpre;
    public GameObject hed;
    public GameObject bbody;
   
    public GameObject v1;
    public GameObject v2;
    public GameObject v3;
    public GameObject v4;
    public GameObject vp1;
    public GameObject vp2;
    public GameObject vp3;
    public GameObject vp4;
    public Transform za;
    public jump ground;
    public float M =0;
    public CharacterJoint cj;
    public GameObject shqual;

    void Start()
    {
        // mText = GetComponent<Text>();
        mText = GetComponent<Text>();
        leg = GetComponent<CharacterJoint>();
        cj = GetComponent<CharacterJoint>();
       
        //UI = GetComponent<Image>();
        //  anim = GetComponent<Animator>();
        r_A =GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody r in r_A)
        {
            //r.isKinematic = true;
        }

        rb_AR = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rb_AR)
        {
            rb.tag = "rock";
            rb.isKinematic = true;

        }

        hachd.SetActive(false);
        _audioSource.loop = true;
        p = 0;

    }


    void Update()
    {


        // start += 0.1 * Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.F))
        {
            la = !la;
           // _audioSource.PlayOneShot(laze);

        }

        if (la == false)
            laz.SetActive(true);
        else
            laz.SetActive(false);


        if (Input.GetMouseButtonDown(1))
            //додик = !додик;
            z += 1;

        if (Input.GetMouseButtonDown(2))//&&(Time.time > svvvv))
        {
            //while (sv == true)   
            // svvvv = Time.time + 1f / fireRate;
            shqual.SetActive(true);
            sv =true;
        }
        if (Input.GetMouseButtonUp(2))//&&(Time.time > svvvv))
        {
            //while (sv == true)   
            // svvvv = Time.time + 1f / fireRate;

            sv = false; shqual.SetActive(false);
        }


        if (z % 2 == 0)
            sv = false;



        //if (Input.GetMouseButtonDown(2))
        //   hachd.SetActive(false);


        RaycastHit hit;









    







        //  {
        // if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))

        if ((z % 2 == 0)||(sv==true))
            if (Physics.Raycast(MAC.transform.position, MAC.transform.TransformDirection(Vector3.forward), out hit, 1000) && Time.time > nextFire || Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 1000) &&  z % 2 == 1)
                {
                //if (Physics.Raycast(MAC.transform.position, MAC.transform.forward, out hit, range))
                {
                    if (Input.GetMouseButton(0) && (sv == false))
                        nextFire = Time.time + 1f / fireRate;

                    //   blood.transform.position = hit.transform.position;
                    if  ((sv == true) || (Input.GetMouseButton(0) &&(sv == false)))
                    {
                        nextFire = Time.time + 1f / fireRate;
                       // blood.transform.position = hit.transform.position;//  _audioSource.PlayOneShot(shotSFX);

                        if ((hit.collider.tag != "ULLPRE"))
                            if ((hit.collider.tag != "rock"))
                                if ((hit.collider.tag != "gay"))
                                    if ((hit.collider.tag != "mob_ragdoll2"))
                                        if ((hit.collider.tag != "green"))
                                            if ((hit.collider.tag != "COL"))
                                                if ((hit.collider.tag != "child"))
                                                    if ((hit.collider.tag != "hip"))
                                                        if ((hit.collider.tag != "metal"))
                                                        {
                                                            GameObject impact5 = Instantiate(bul, hit.point, Quaternion.LookRotation(hit.normal));
                                                            Destroy(impact5, 25f);
                                                        }
                                                        else
                                                        {
                                                            GameObject impact23 = Instantiate(hitEffect2, hit.point, Quaternion.LookRotation(hit.normal));
                                                            Destroy(impact23, 500f);
                                                        }

                        if ((hit.collider.tag == "ULLPRE") || (hit.collider.tag == "gay") || (hit.collider.tag == "rock"))
                        {
                            if (col >= 1)
                            {
                                GameObject impact8 = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
                                Destroy(impact8, 25f);
                            }
                            hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);

                        }


                        if (hit.collider.name == "ert")
                        {
                            GameObject impact = Instantiate(hitEffect2, hit.point, Quaternion.LookRotation(hit.normal));
                            Destroy(impact, 25f);
                        }

                        //  if ((hit.collider.tag == "ULLPRE") ||  (hit.collider.tag == "mob_ragdoll2") || (hit.collider.tag == "child"))
                        // audioSource.PlayOneShot(mm);
                        if ((hit.collider.tag == "mob_ragdoll2") || (hit.collider.tag == "child"))
                        {
                            if ((hit.collider.tag == "child"))
                            {
                                r_A = hit.collider.gameObject.GetComponentsInChildren<Rigidbody>();
                                foreach (Rigidbody r in r_A) r.isKinematic = false;
                            }
                            //  anim.SetBool("sh2", true);

                            GameObject impact = Instantiate(hitblood, hit.point, Quaternion.LookRotation(hit.normal));
                            if (sv == false)
                                S.scor += 2f;
                            else
                                S.scor += 0.1f;
                            Destroy(impact, 2f);
                            //blood.GetComponent<VisualEffect>().Play();

                            hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                            hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);
                            audioSource.PlayOneShot(mm);
                            GameObject impact11 = Instantiate(bl, hit.point, Quaternion.LookRotation(hit.normal));
                            Destroy(impact11, 2f);



                        }
                        if ((hit.collider.tag == "ULLPRE"))
                        { 
                            audioSource.PlayOneShot(mm);
                            hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);
                            if(sv==false)
                            S.scor += 1f;
                            else
                                S.scor += 0.1f;

                        }

                        if (hit.collider.name == "BodyM")
                        {

                            {



                                audioSource.PlayOneShot(m1);

                                //blood.GetComponent<VisualEffect>().Play();
                                hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);
                                Instantiate(bodyMPREF, hit.collider.transform.position, hit.collider.transform.rotation);
                                Destroy(hit.collider.gameObject);
                                Destroy(bodyMPREF, 20f);
                                chii.GetComponent<Rigidbody>().isKinematic = false;

                                //bodyPREF.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);


                                //blood.GetComponent<VisualEffect>().Play();
                                GameObject impact = Instantiate(hitblood, hit.point, Quaternion.LookRotation(hit.normal));
                                S.scor += 5f;
                                Destroy(impact, 2f);
                                nextFire = Time.time + 1f / fireRate;

                                // MText.text = a.ToString();
                            }
                        }



                        if (hit.collider.tag == "rock")
                        {

                            GameObject impact = Instantiate(hitblood, hit.point, Quaternion.LookRotation(hit.normal));
                            Destroy(impact, 2f);
                            // blood.GetComponent<VisualEffect>().Play();

                            hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                            hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);
                            // joint = GetComponent<CharacterJoint>();
                            //  Destroy(leg) ;

                            // MText.text = f.ToString();
                            //  Invoke("SetF", 5);
                            // Destroy(f, .5f);
                            audioSource.PlayOneShot(m2);
                            if (sv == false)
                                S.scor += 2f;
                            else
                                S.scor += 0.1f;
                        }


                        if (hit.collider.name == "Head")
                        {
                            //ext.di = true; ext2.di = true;
                            //Ragdoll_On();
                        }
                           













                            if (hit.collider.name == "HEad")
                        {

                            {
                                H += 1;
                                


                                   if(B<3)
                                    Ragdoll_On();
                                 
                                    // S.scor += 20;
                                 
                                hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                                    hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);

                                    Instantiate(headPREF, head1.transform.position, head1.transform.rotation);
                                    headPREF.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);
                                    Destroy(head1);

                                nextFire = Time.time + 1f / fireRate;
                                if (sv == false)
                                    S.scor += 15f;
                                else
                                    S.scor += 5f;


                            }
                        }

                        if (hit.collider.name == "Body")
                        {

                            {
                                B += 1;
                                // MText.text = s.ToString();

                                if (B == 3)
                                {
                                    if(H<2)
                                    Ragdoll_On();
                                    H += 2;
                                    audioSource.PlayOneShot(m1);

                                    //blood.GetComponent<VisualEffect>().Play();
                                    //hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                                   // hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);
                                    Instantiate(bodyPREF, body.transform.position, body.transform.rotation);
                                    Destroy(body);
                                    

                                    //bodyPREF.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);

                                }
                                //blood.GetComponent<VisualEffect>().Play();
                                GameObject impact = Instantiate(hitblood, hit.point, Quaternion.LookRotation(hit.normal));
                                if (sv == false)
                                    S.scor += 7f;
                                else
                                    S.scor += 3f;
                                Destroy(impact, 2f);
                                nextFire = Time.time + 1f / fireRate;
                               // hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                               // hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(MAC.transform.TransformDirection(Vector3.forward) * force);
                                // MText.text = a.ToString();
                            }
                        }


                        







                    }
                }
            }









 
            if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 1000) )//&& Time.time > nextFire)
            if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                if ((hit.collider.tag == "ULLPRE") || (hit.collider.tag == "gay") || (hit.collider.tag == "rock") || (hit.collider.tag == "mob_ragdoll2") || (hit.collider.tag == "child"))

                {
                    UI.GetComponent<Image>().color = new Color(1f, 0f, 0f, 1f);
                  
                }
                
                else
                {
                    UI.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);

                  
                }
             

                if (((hit.collider.tag == "ULLPRE") || (hit.collider.tag == "gay") || (hit.collider.tag == "rock") || (hit.collider.tag == "mob_ragdoll2") || (hit.collider.tag == "child")) && Input.GetMouseButton(0))

                {
                    UI.GetComponent<Image>().color = new Color(1f, 0f, 0f, 1f);
                 
                }
                if ((hit.collider.name == "UlLL2")&& (la == false))
                    {
                        GameObject impact88 = Instantiate(met, hit.point, Quaternion.LookRotation(hit.normal));
                        hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * lazer);
                        //  _audioSource.PlayOneShot(laze);
                        li.SetActive(true);
                        Destroy(impact88, 2f);
                    if(Time.time > nextFire)
                    {
                        nextFire = Time.time + 1f / fireRate;
                        S.scor += 1f;
                        //cam.GetComponent<Camera>().fieldOfView += 1f;
                    }
                    }
                      else  li.SetActive(false);

                //  if((hit.collider.name != "UlLL2") || (la != false))

                if(ground.NumberJumps == 0)
                    if(ground.isGrounded==true)
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (cam.GetComponent<Camera>().fieldOfView <= 70f)
                        if (Time.time > nextFire)
                        {
                            nextFire = Time.time + 0.001f / fireRate;
                            cam.GetComponent<Camera>().fieldOfView += .2f;
                        }
                }
                else
                    if (Time.time > nextFire)
                    if (cam.GetComponent<Camera>().fieldOfView >= 60f)
                    {
                        nextFire = Time.time + 0.001f / fireRate;
                        cam.GetComponent<Camera>().fieldOfView -= .5f;
                    }



            }




        head.LookAt(cam);
        //mText.text = p.ToString();





        if (z % 2 == 1)
            if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 1000) && Time.time > nextFire)
            {
                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
                {
                    // blood.transform.position = hit.transform.position;

                    //bodyPREF.transform.position = hit.transform.position;
                    //   blood.transform.position = hit.transform.position;
                    if (Input.GetMouseButton(0))
                    {
                        // _audioSource.PlayOneShot(shotSFX);
                        nextFire = Time.time + 1f / fireRate;
                        if ((hit.collider.tag != "ULLPRE"))
                            if ((hit.collider.tag != "rock"))
                                if ((hit.collider.tag != "gay"))
                                    if ((hit.collider.tag != "mob_ragdoll2"))
                                        if ((hit.collider.tag != "green"))
                                            if ((hit.collider.tag != "COL"))
                                                if ((hit.collider.tag != "child"))
                                                    if ((hit.collider.tag != "hip"))
                                                        if ((hit.collider.tag != "metal"))
                                                        //if (Time.time > nextFire)
                                                        {
                                                            GameObject impact5 = Instantiate(bul, hit.point, Quaternion.LookRotation(hit.normal));
                                                            Destroy(impact5, 500f);
                                                        }
                                                        else
                                                        {
                                                            GameObject impact23 = Instantiate(hitEffect2, hit.point, Quaternion.LookRotation(hit.normal));
                                                            Destroy(impact23, 500f);
                                                        }

                        if ((hit.collider.tag == "ULLPRE") || (hit.collider.tag == "gay") || (hit.collider.tag == "rock") || (hit.collider.tag == "mob_ragdoll2") || (hit.collider.tag == "child"))
                        {
                            if (col >= 1)
                            {
                                GameObject impact8 = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
                                Destroy(impact8, 25f);
                            }
                            hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);

                            //    p += 1;
                            //  mText.Text = p.ToString();

                            


                        }


                        Destroy(cj);


                        if ((hit.collider.tag == "mob_ragdoll2") || (hit.collider.tag == "child"))
                        {


                            GameObject impact11 = Instantiate(bl, hit.point, Quaternion.LookRotation(hit.normal));
                            Destroy(impact11, 2f);
                            S.scor += 1f;
                        }

                        if (hit.collider.name == "ert")
                        {
                            GameObject impact = Instantiate(hitEffect2, hit.point, Quaternion.LookRotation(hit.normal));
                            Destroy(impact, 25f);
                        }

                        //  if ((hit.collider.tag == "ULLPRE") || (hit.collider.tag == "mob_ragdoll2") || (hit.collider.tag == "child"))
                        // audioSource.PlayOneShot(mm);









                        if (hit.collider.tag == "rock")
                        {
                            
                            
                                GameObject impact = Instantiate(hitblood, hit.point, Quaternion.LookRotation(hit.normal));

                                Destroy(impact, 2f);
                                // blood.GetComponent<VisualEffect>().Play();
                                nextFire = Time.time + 1f / fireRate;
                                hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);
                                // joint = GetComponent<CharacterJoint>();
                                //  Destroy(leg) ;
                                _audioSource.PlayOneShot(m2);
                            // MText.text = f.ToString();
                            //  Invoke("SetF", 5);
                            // Destroy(f, .5f);
                            S.scor += 1;

                        }



                        if (hit.collider.name == "bbody")
                        {
    
                                Instantiate(bbodypre, bbody.transform.position, bbody.transform.rotation);
                                 Destroy(bbody);
                                S.scor += 10f;
   
                        }
                        if (hit.collider.name == "hed")
                        {

                            Instantiate(hedpre, hed.transform.position, hed.transform.rotation);
                            Destroy(hed);
                            S.scor += 10f;

                        }

                        if (hit.collider.name == "v1")
                        {

                            Instantiate(vp1, v1.transform.position, v1.transform.rotation);
                            Destroy(v1);
                            S.scor += 10f;

                        }
                        if (hit.collider.name == "v2")
                        {

                            Instantiate(vp2, v2.transform.position, v2.transform.rotation);
                            Destroy(v2);
                            S.scor += 10f;

                        }
                        if (hit.collider.name == "v3")
                        {

                            Instantiate(vp3, v3.transform.position, v3.transform.rotation);
                            Destroy(v3);
                            S.scor += 10f;

                        }
                        if (hit.collider.name == "v4")
                        {

                            Instantiate(vp4, v4.transform.position, v4.transform.rotation);
                            Destroy(v4);
                            S.scor += 10f;

                        }
















                        if (hit.collider.name == "HEad")
                        {

                            {
                                H += 1;



                                if (B < 3)
                                    Ragdoll_On();

                                // S.scor += 20;

                                hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);

                                Instantiate(headPREF, head1.transform.position, head1.transform.rotation);
                                headPREF.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);
                                Destroy(head1);

                                nextFire = Time.time + 1f / fireRate;
                                S.scor += 10f;


                            }
                        }

                        if (hit.collider.name == "he")
                        {

                            {


                                audioSource.PlayOneShot(m1);




                               Destroy( cj);
                                S.scor += 5f;
                               
                                nextFire = Time.time + 1f / fireRate;



                            }
                        }

                        if (hit.collider.name == "BodyM")
                        {

                            {
                                    
                                      
                                    
                                    audioSource.PlayOneShot(m1);

                                    //blood.GetComponent<VisualEffect>().Play();
                                    hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                                    hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);
                                    Instantiate(bodyMPREF, hit.collider.transform.position, hit.collider.transform.rotation);
                                    Destroy(hit.collider.gameObject);
                                Destroy(bodyMPREF, 20f);
                                chii.GetComponent<Rigidbody>().isKinematic = false;

                                //bodyPREF.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);


                                //blood.GetComponent<VisualEffect>().Play();
                                GameObject impact = Instantiate(hitblood, hit.point, Quaternion.LookRotation(hit.normal));
                                S.scor += 5f;
                                Destroy(impact, 2f);
                                nextFire = Time.time + 1f / fireRate;
                               
                                // MText.text = a.ToString();
                            }
                        }


                        if (hit.collider.name == "Body")
                        {

                            {
                                B += 1;
                                // MText.text = s.ToString();

                                if (B == 3)
                                {
                                    if (H < 2)
                                        Ragdoll_On();
                                    H += 2;
                                    audioSource.PlayOneShot(m1);

                                    //blood.GetComponent<VisualEffect>().Play();
                                    hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                                    hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);
                                    Instantiate(bodyPREF, body.transform.position, body.transform.rotation);
                                    Destroy(body);


                                    //bodyPREF.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);

                                }
                                //blood.GetComponent<VisualEffect>().Play();
                                GameObject impact = Instantiate(hitblood, hit.point, Quaternion.LookRotation(hit.normal));
                                S.scor += 5f;
                                Destroy(impact, 2f);
                                nextFire = Time.time + 1f / fireRate;
                                hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(cam.transform.TransformDirection(Vector3.forward) * force);
                                // MText.text = a.ToString();
                            }
                        }
                    }
                }

            }


        
    }






    
    void Ragdoll_On()
    {
       // if (hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic == true)
      // if(die==false)
        {
            foreach (Rigidbody rb in rb_AR) rb.isKinematic = false;
            kill.SetActive(true);
            Invoke("KILL", 1);
            die = true;
            S.scor += 25f;
        }
    }


    void KILL()
    {
        kill.SetActive(false);
    }






}






