using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changermaterial : MonoBehaviour
{
    public Renderer renderer;
    private float spec=1;
    private Vector2 till;
    public Texture dpp;
    // Start is called before the first frame update
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        spec = 0;
        till = new Vector2(0, 0);
        renderer.material.SetTexture("Iridescence Layer Thickness Map", dpp);
       renderer.material.SetFloat("Iridescence Layer Thickness map", spec);
       renderer.material.SetVector("Tilling", till);
       renderer.material.SetVector("_Tilling", till);
    }
}
