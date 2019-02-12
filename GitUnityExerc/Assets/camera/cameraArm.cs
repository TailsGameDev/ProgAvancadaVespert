using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script makes the camera be at a fixed position from the player
public class cameraArm : MonoBehaviour
{
    public Transform target;
    Vector3 arm;

    void Start()
    {
        arm = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + arm;
    }
}
