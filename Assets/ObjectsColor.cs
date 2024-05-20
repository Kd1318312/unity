using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetColor : MonoBehaviour
{
    public GameObject obj; //オブジェクト自身
    private Color color;


    void Start()
    {
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            color = obj.GetComponent<Renderer>().material.color;
        }
        
    }
}
