using System.Collections;
using UnityEngine;

public class xx : MonoBehaviour
{

    private bool додик = false;
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    private float _rotationX = 0;
    public int speedRotation = 3;


    public float Jump;
    public int jumpForce;
    private Rigidbody rb;
    public float jumpHeight = 7f;
    public bool isGrounded;
    public float NumberJumps = 0f;
    public float MaxJumps = 2;
    public float JumpF;
    public float speed2;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y");
            _rotationX = Mathf.Clamp(_rotationX, 0, 0);

            transform.localEulerAngles = new Vector3(_rotationX, 0, 0);
           
           
        }
    
        else
        {
            _rotationX -= Input.GetAxis("Mouse Y");
            _rotationX = Mathf.Clamp(_rotationX, 0, 0);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            transform.localEulerAngles = new Vector3(_rotationX, 0, 0);
}


        if (Input.GetMouseButtonDown(1))
        {
            додик = !додик;

            if (додик)
            {
                sensitivityHor -= 1.0f;
            }
            else
            {
                sensitivityHor += 1.0f;
            }



        }

      
     if (Input.GetButtonDown("Jump"))
                if (isGrounded)
                {
                    rb.AddForce(Vector3.up * jumpHeight);
                    rb.AddForce(new Vector3(0, 0, _rotationX) * JumpF);
                    NumberJumps += 1;
                }
        

  if (NumberJumps > MaxJumps - 1)
        {
            isGrounded = false;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
        NumberJumps = 0;
    }
    void OnCollisionExit(Collision other)
    {

    }


    
}