using System.Collections.Generic;
using UnityEngine;

public class platMove : MonoBehaviour
{

    [Header("必要なコンポーネントを登録")]
    [SerializeField]
    Rigidbody rigidBody = null;

    [Header("基本設定")]
    [SerializeField]
    Vector3 speed = Vector3.zero;

    List<Rigidbody> rigidBodies = new();

    void FixedUpdate()
    {
        MovePlatform();
        AddVelocity();
    }

    void OnTriggerEnter(Collider other)
    {
        rigidBodies.Add(other.gameObject.GetComponent<Rigidbody>());
    }

    void OnTriggerExit(Collider other)
    {
        rigidBodies.Remove(other.gameObject.GetComponent<Rigidbody>());
    }

    void MovePlatform()
    {
        rigidBody.MovePosition(transform.position + Time.fixedDeltaTime * speed);
    }

    void AddVelocity()
    {
        if (rigidBody.velocity.sqrMagnitude <= 0.01f)
        {
            return;
        }

        for (int i = 0; i < rigidBodies.Count; i++)
        {
            rigidBodies[i].AddForce(rigidBody.velocity, ForceMode.VelocityChange);
        }
    }

}