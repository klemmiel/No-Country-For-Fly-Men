using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glenn : MonoBehaviour
{
    float xInput;
    float xSpeed = 10f;
    float yInput;
    float ySpeed = 10f;

    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(xInput * xSpeed, yInput * ySpeed, 0); 
    }
}
