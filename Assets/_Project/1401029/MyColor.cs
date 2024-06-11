using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyColor : MonoBehaviour
{
    public Color myColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Renderer>().material.color = myColor;
    }
}
