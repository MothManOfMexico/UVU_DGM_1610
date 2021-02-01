using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject PlayerPlane;
    private Vector3 offset = new Vector3(22,4,14);

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerPlane.transform.position + offset;
    }
}
