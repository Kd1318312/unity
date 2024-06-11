using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EventText : MonoBehaviour
{
    public TextMeshProUGUI m_text;
    GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        m_text.gameObject.SetActive(false);
        parent = transform.parent.gameObject;
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {

        if(Input.GetKeyDown(KeyCode.Return)) 
        {
            if (other.CompareTag("Event"))
            {
                m_text.text = "���́B����ȊO�̉����ł��Ȃ��B";
                m_text.gameObject.SetActive(true);
            }
            if (other.CompareTag("Platform"))
            {
                m_text.text = "��������B�����͕s���B";
                m_text.gameObject.SetActive(true);
                if(other.GetComponent<ChangeColor>())
                {
                    other.GetComponent<ChangeColor>().select_color = parent.GetComponent<PlayerControll2>().stuckcol;
                }
            }

        }
    }

}
