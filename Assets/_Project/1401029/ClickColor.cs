using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickColor : MonoBehaviour
{
    public Color32 myColor;
    public GameObject mgo;
   

    public void OnClick()
    { 
        Debug.Log(myColor.ToString());
        mgo = GameObject.FindWithTag("Player");
        mgo.GetComponent<PlayerControll2>().stuckcol = myColor;
        
    }
  
}
