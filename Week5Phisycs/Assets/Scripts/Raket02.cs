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

        // float horizontal = Input.GetAxisRaw("Horizontal"); // pijlen links en rechts
        //Vector3 direction = new Vector3(0, 0, horizontal).normalized;

        /*
        if (direction.magnitude >= 0.1f)                                 // beweging wordt geregistreerd
        {
            transform.eulerAngles = direction * Speed * Time.deltaTime;
        }

    /*
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * Speed );
        }
        else
        {
            rigidBody.AddForce(Vector3.down * Speed * 0.5f);
        }
        

        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);

        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput - previousRotation > 0)
        {
            transform.Translate(new Vector3(horizontalInput, 0, 0) * Speed * Time.deltaTime);
            //rigidBody.rotation = Quaternion.AngleAxis( 60, Vector3.forward);
            //transform.rotation = Quaternion.AngleAxis( 30, Vector3.back );

            //transform.Rotate(0, 0, 3);
        }

        previousRotation = horizontalInput;
         /*   
            
            //Get the value of the Horizontal input axis.

            float verticalInput = Input.GetAxis("Vertical");
            //Get the value of the Vertical input axis.

            transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Speed * Time.deltaTime);
        */
    }
}
