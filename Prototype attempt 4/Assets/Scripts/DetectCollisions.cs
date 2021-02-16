using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Destroy this object that script is attached to
        Destroy(gameObject);
        //Destroy other object hits a trigger
        Destroy(other.gameObject);
    }
}
