using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;



public class TextControl : MonoBehaviour
{
    public GameObject cube; //あるオブジェクト
                            //public Text right;


    public TMP_Text textUI;

    
    void Start()
    {
        
    }
    void Update()
    {
        cube = this.gameObject;

        if(Input.GetKeyUp(KeyCode.Return))
        {
            textUI.text = cube.GetComponent<GetRenderTexturePixels>().color.ToString();
            textUI.gameObject.SetActive(true);

            
        }
       
    }
}
