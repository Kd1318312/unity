using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public bool PlayerTriggerStay;
    private GameObject PlayerObject;
    
    float x = 0;
    bool y = false;
    bool z = false;
    public float movingTime;

    private void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        PlayerTriggerStay = false;
    }

    

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            z = true;
            
        }

        if (z)
        {
            x++;
            if (!y && x > movingTime * 60) 
            {
                x = 0;
                y = true;
            }
            if (y && x > movingTime * 60) 
            {
                x = 0;
                y = false;
                z = false;
            }

            if (!y)
            {
                transform.position += new Vector3(0.025f, 0, 0);
            }
            if (y)
            {
                transform.position -= new Vector3(0.025f, 0, 0);
            }
        }
        
       
        



        if(PlayerTriggerStay)
        {
            PlayerObject.transform.parent = this.transform;
        }
        else
        {
            PlayerObject.transform.parent = null;
        }
    }
}
