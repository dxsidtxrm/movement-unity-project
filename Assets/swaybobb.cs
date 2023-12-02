using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swaybobb : MonoBehaviour
{

    public CharacterController mover;
    public
    Vector2 walkInput;
    [Header("Sway")]
    public float step = 0.01f;
    public float maxStepDistance = 0.06f;
    Vector3 swayPos;

    [Header("Sway Rotation")]
    public float rotationStep = 4f;
    public float maxRotationStep = 5f;
    Vector3 swayEulerRot;

    public float smooth = 10f;
    float smoothRot = 12f;

    [Header("Bobbing")]
    public float speedCurve;
    float curveSin { get => Mathf.Sin(speedCurve); }
    float curveCos { get => Mathf.Cos(speedCurve); }

    public Vector3 travelLimit = Vector3.one * 0.025f;
    public Vector3 bobLimit = Vector3.one * 0.01f;
    Vector3 bobPosition;

    public float bobExaggeration;

    [Header("Bob Rotation")]
    public Vector3 multiplier;
    Vector3 bobEulerRotation;
    public float fallimpact;

    public GameObject cam;
    private float tm;
    private bool ste = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetInput();

        Sway();
        SwayRotation();
        BobOffset();
        BobRotation();
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {

            walkInput.y = 0;
        }
       

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
         
            walkInput.x = 0;
        }
        if (walkInput == new Vector2(0, 0))
        {




            if (bobExaggeration > 1.1f)
            {
                
                bobExaggeration -= Time.deltaTime * 100;
            }
            if(bobExaggeration<1)
                bobExaggeration += Time.deltaTime * 2;

        }
        else




            if (bobExaggeration < 10)
           {
            bobExaggeration += Time.deltaTime*15;
            }

        tm += Time.deltaTime;


  //   if ((Mathf.Abs(walkInput.y)  +Mathf.Abs(  walkInput.x) )!= 0)
        if (bobExaggeration > 10)
            if(ste==true)if(Mathf.Abs(speedCurve)>=5.5555f)
        {
            Invoke("Step",0);
                ste = false;
        }


        
       
        CompositePositionRotation();
    }


    Vector2 lookInput;
    void Step()
    {
        cam.transform.localEulerAngles += new Vector3(fallimpact * (1.5f - Time.deltaTime * 4f), 0, 0);
        cam.GetComponent<Camera>().fieldOfView -=0.18f;
        ste = true;
        speedCurve = 0;
    }
    void GetInput()
    {
        walkInput.x = Input.GetAxisRaw("Horizontal");
        walkInput.y = Input.GetAxisRaw("Vertical");
        walkInput = walkInput.normalized;

        lookInput.x = Input.GetAxis("Mouse X");
        lookInput.y = Input.GetAxis("Mouse Y");
    }


    void Sway()
    {
        Vector3 invertLook = lookInput * -step;
        invertLook.x = Mathf.Clamp(invertLook.x, -maxStepDistance, maxStepDistance);
        invertLook.y = Mathf.Clamp(invertLook.y, -maxStepDistance, maxStepDistance);

        swayPos = invertLook;
    }

    void SwayRotation()
    {
        Vector2 invertLook = lookInput * -rotationStep;
        invertLook.x = Mathf.Clamp(invertLook.x, -maxRotationStep, maxRotationStep);
        invertLook.y = Mathf.Clamp(invertLook.y, -maxRotationStep, maxRotationStep);
        swayEulerRot = new Vector3(invertLook.y, -invertLook.x, invertLook.x);
    }

    void CompositePositionRotation()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, swayPos + bobPosition, Time.deltaTime * smooth);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(swayEulerRot) * Quaternion.Euler(bobEulerRotation), Time.deltaTime * smoothRot);
    }

    void BobOffset()
    {
        //   if (!(Input.GetKey(KeyCode.W) &&Input.GetKey(KeyCode.S))  && !(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A)))

        if (bobExaggeration > 1.1f)
            speedCurve += Time.deltaTime * (((Mathf.Abs(Input.GetAxis("Horizontal")) != Mathf.Abs(Input.GetAxis("Vertical"))) ? (mover.isGrounded ? (Mathf.Abs(walkInput.x + walkInput.y)) * bobExaggeration : 1f) : bobExaggeration)) + 0.01f;
        else speedCurve = 0;
        bobPosition.x = (curveCos * bobLimit.x * (mover.isGrounded ? 1 : 0)) - (Mathf.Abs(walkInput.x )* travelLimit.x);
        bobPosition.y = (curveSin * bobLimit.y) - (Input.GetAxisRaw("Vertical") * travelLimit.y);
        bobPosition.z = -(Mathf.Abs(walkInput.y) * travelLimit.z);
    }

    void BobRotation()
    {
        bobEulerRotation.x = (walkInput != Vector2.zero ? multiplier.x * (Mathf.Sin(2 * speedCurve)) : multiplier.x * (Mathf.Sin(2 * speedCurve) / 2));
        bobEulerRotation.y = (walkInput != Vector2.zero ? multiplier.y * curveCos : 0);
        bobEulerRotation.z = (walkInput != Vector2.zero ? multiplier.z * curveCos * walkInput.x : 0);
    }

}