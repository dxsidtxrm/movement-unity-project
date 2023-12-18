using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ree : MonoBehaviour
{

    public Renderer gh;
    public Material[] new1;
    public Material[] new2;
    public Material[] new3;
    public Material[] new4;
    public Material[] new5;
    public Material[] new6;
    public Material[] new7;
    public Material[] new8;
    public Material[] new9;
    public Material[] new10;
    private int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        gh = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        gh.materials = new10;

        if (Input.GetKeyDown(KeyCode.G))
            a += 1;

        if (a == 1)
            gh.materials = new1;
        if (a == 2)
            gh.materials = new2;
        if (a == 3)
            gh.materials = new3;
        if (a == 4)
            gh.materials = new4;
        if (a == 5)
            gh.materials = new5;
        if (a == 6)
            gh.materials = new6;
        if (a == 7)
            gh.materials = new7;
        if (a == 8)
            gh.materials = new8;
        if (a == 9)
            gh.materials = new9;

        if (a == 10)
            a = 1;

    }
}
