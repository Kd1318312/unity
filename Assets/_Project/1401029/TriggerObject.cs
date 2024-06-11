using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    private GameObject _parent;


    private void Start()
    {
        _parent = transform.root.gameObject;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _parent.GetComponent<MovingPlatform>().PlayerTriggerStay = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            _parent.GetComponent<MovingPlatform>().PlayerTriggerStay = false;
        }
    }
}
