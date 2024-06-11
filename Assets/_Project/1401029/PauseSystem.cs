using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public GameObject goj;

    public bool PauseFlg;

    public GameObject Color1;
    public GameObject Color2;
    public GameObject Color3;
    public GameObject Color4;
    public GameObject Color5;
    public GameObject Color6;
    public GameObject Color7;

    private void Start()
    {
        goj.SetActive(false);
        Color1.SetActive(false);
        Color2.SetActive(false);
        Color3.SetActive(false);
        Color4.SetActive(false);
        Color5.SetActive(false);
        Color6.SetActive(false);
        Color7.SetActive(false);
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseFlg)
            {
                PauseFlg = false;
            }
            else
            {
                PauseFlg = true;
            }
        }
        if (!PauseFlg)
        {
            Time.timeScale = 1;
            goj.SetActive(false);
            Color1.SetActive(false);
            Color2.SetActive(false);
            Color3.SetActive(false);
            Color4.SetActive(false);
            Color5.SetActive(false);
            Color6.SetActive(false);
            Color7.SetActive(false);
            
        }
        else
        {
            Time.timeScale = 0;
            goj.SetActive(true);
            Color1.SetActive(true);
            Color2.SetActive(true);
            Color3.SetActive(true);
            Color4.SetActive(true);
            Color5.SetActive(true);
            Color6.SetActive(true);
            Color7.SetActive(true);
        }

    }
}
