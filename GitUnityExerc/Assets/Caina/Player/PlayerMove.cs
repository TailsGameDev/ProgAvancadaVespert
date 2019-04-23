using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esse script cuida do movimento do playerou de outros objetos, vai q neh
public class PlayerMove : MonoBehaviour
{
    public float vel;
    public float okDistance;
    Rigidbody rb;
    Vector3 destination;
    float y;

    void Start()
    {
        //vel = 1f;
        rb = GetComponent<Rigidbody>();
        Camera.main.GetComponent<RayHit>().clickOnFloor += MoveToPoint;
        y = transform.position.y;
    }

    void MoveToPoint (Vector3 point) {
        destination = point;
        StartCoroutine(CMoveToPoint());
    }

    IEnumerator CMoveToPoint() {
        float distance = (destination - transform.position).magnitude;
        while (distance > okDistance) {
            Vector3 direction = destination - transform.position;
            direction = new Vector3(direction.x , 0 , direction.z);
            direction.Normalize();
            rb.velocity = direction * vel;
            distance = (destination - transform.position).magnitude;
            yield return null;
        }
        rb.velocity = Vector3.zero;
    }
}
