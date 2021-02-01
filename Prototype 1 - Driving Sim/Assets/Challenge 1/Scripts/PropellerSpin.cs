using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float speed = 400.0f;

    // Update is called once per frame
    void Update()
    {
        //Code for getting the propeller to rotate and spin
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
