using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hittt : MonoBehaviour
{
    public Texture prefab;
    public Transform parent;
    public Vector2 position;
    public Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        Texture childGameObject = Instantiate(prefab, parent.position, parent.rotation, parent);
    }

    // Update is called once per frame
    void f()
    {
        Texture childGameObject = Instantiate(prefab, parent.position, parent.rotation, parent);


    }
}
