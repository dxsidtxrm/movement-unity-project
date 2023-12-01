using System.Collections;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform camTarget;
  // public float pLerp = .01f;
//public float rLerp = .02f;
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float _rotationX = 0;
    public int speedRotation = 3;
    private bool ����� = false;
    public float  x = 1f;
    public float y = 0f;
    public float z = 0f;
    public float fieldOfView=1f;
    public Camera myCamera;
    public GameObject sq;
    public float q;
    public GameObject aim;

    void Start()
    {
       
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;

    }
    void Update()
    {
       // transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
       // transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }

       
           // camTarget.transform.Translate(1, 0, 0);


    }

}