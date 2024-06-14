using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPalet : MonoBehaviour
{
    public GameObject Color1;
    public GameObject Color2;
    public GameObject Color3;
    public GameObject Color4;
    public GameObject Color5;
    public GameObject Color6;
    public GameObject Color7;


    // Start is called before the first frame update
    void Start()
    {
        Color1.SetActive(false); 
        Color2.SetActive(false);
        Color3.SetActive(false);
        Color4.SetActive(false);
        Color5.SetActive(false);
        Color6.SetActive(false);
        Color7.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.timeScale==0)
        {
            Color1.SetActive(true);
            Color2.SetActive(true);
            Color3.SetActive(true);
            Color4.SetActive(true);
            Color5.SetActive(true);
            Color6.SetActive(true);
            Color7.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Color1.SetActive(false);
                Color2.SetActive(false);
                Color3.SetActive(false);
                Color4.SetActive(false);
                Color5.SetActive(false);
                Color6.SetActive(false);
                Color7.SetActive(false);
            }
        }        
        
    }
}
