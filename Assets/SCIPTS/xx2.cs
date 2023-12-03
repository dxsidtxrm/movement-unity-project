using System.Collections;
using UnityEngine;

public class xx2 : MonoBehaviour
{

   
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
    private Rigidbody rb;
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

    }


}