using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    public float speed = 30.0f;
    public float turnSpeed = 40.0f;
    public float hInput;
    public float fInput;

    // Update is called once per frame
    void Update()
    {
        //Inputs for getting the plane to tilt up and down
        fInput = Input.GetAxis("Vertical");
        //Inputs for getting plane to move forward and backwards
        hInput = Input.GetAxis("Horizontal");
        //Code for actually getting the plane to go back and forth
        transform.Translate(Vector3.forward * Time.deltaTime * speed * hInput);
        //Code for plane tilting up and down
        transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed * fInput);
    }
}
