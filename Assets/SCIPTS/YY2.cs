using System.Collections;
using UnityEngine;

public class YY2 : MonoBehaviour
{
    public Transform camTarget;
   public float pLerp = .01f;
public float rLerp = .02f;
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor ;
    public float sensitivityVert ;
    public float minimumVert ;

    public float maximumVert ;

    private float _rotationX = 0;

    public float spx;
    public float spxmin;
    public float spxmax;
    public float spy;


    void Start()
    {
       
        

    }
    void Update()
    {
        spx = Input.GetAxis("Mouse X");
       spx= Mathf.Clamp(spx, spxmin, spxmax);
                spy = Input.GetAxis("Mouse Y");


        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
         if (axes == RotationAxes.MouseX)
        {
            
            transform.Rotate(0, spx * sensitivityHor, 0);
        }
        else
         if (axes == RotationAxes.MouseY)
        {
        
            _rotationX -=spy * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);

           
        }
        else
        {
            _rotationX -= spy * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            
            float delta = spy * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }

      
        


    }

}