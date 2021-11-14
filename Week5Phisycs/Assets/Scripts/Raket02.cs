using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raket02 : MonoBehaviour
{
    public float Speed = 100f;
    public float RotationSpeed = 5f;

    Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {   
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddForce(transform.up * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && ! Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back, RotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && ! Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, RotationSpeed * Time.deltaTime);
        }
    }
}
