using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutAndIn : MonoBehaviour
{
    float alpha;
    float red, green, blue;
    float fadeSpeed = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().color=new Color(red, green, blue,alpha);
        alpha -= fadeSpeed;
    }
}
