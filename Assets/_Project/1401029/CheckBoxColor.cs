using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class CheckBoxColor : MonoBehaviour
{
    public TextMeshProUGUI m_text;
    int a;
    bool b = false;

    // Start is called before the first frame update
    void Start()
    {
        a = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        a++;
        if (a > 360)
        {
            m_text.gameObject.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (this.GetComponent<Renderer>().material.color == new Color32(255, 0, 0, 0))
            {
                m_text.text = "ìÆÇ´èoÇµÇΩ!";
                m_text.gameObject.SetActive(true);
                Debug.Log(m_text.text);
                b = true;
                a = 0;
            }
        }
        if (b)
        {

        }
    }
}