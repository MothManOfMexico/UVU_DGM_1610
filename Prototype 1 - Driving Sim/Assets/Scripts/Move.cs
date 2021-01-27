using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 30.0f;
    private float turnSpeed = 35.0f;
    private float hInput;
    private float fInput;

    // Update is called once per frame
    void Update()
    {
        //gathers inputs for controls
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        //makes the vehicle go forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        //makes the vehicle go side to side
        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime);
    }
}
