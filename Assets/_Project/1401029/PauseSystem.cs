using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSystem : MonoBehaviour
{
    public GameObject goj;
    public GameObject goj2;
    public GameObject goj3;


    public bool PauseFlg;

    private void Start()
    {
        goj.SetActive(false);
        goj2.SetActive(false);
        goj3.SetActive(false);
       
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
            goj2.SetActive(false);
            goj3.SetActive(false);
            
            
        }
        else
        {
            Time.timeScale = 0;
            goj.SetActive(true);
            goj2.SetActive(true);
            goj3.SetActive(true);
           
        }

    }
}
