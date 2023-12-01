using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Text mText;
    public float scor = 0f;

    public float fireRate = 1f;
    private float nextFire = 0f;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        mText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + 1f / fireRate;
           // scor += 1;
        }
            mText.text = scor.ToString();


        if (scor > 49)
            UI.GetComponent<Text>().color = new Color(0.84f, 0f, 0.6f, 1f);
        if (scor > 99)
            UI.GetComponent<Text>().color = new Color(0.92f, 1f, 0f, 1f);
        if (scor > 149)
            UI.GetComponent<Text>().color = new Color(1f, 0.36f, 0f, 1f);
        if (scor > 199)
            UI.GetComponent<Text>().color = new Color(1f, 0f, 0f, 1f);
        if (scor > 299)
        {
            UI.GetComponent<Text>().color = new Color(1f, 0.3820755f, 0.9363934f, 1f);

        }


    }
}
