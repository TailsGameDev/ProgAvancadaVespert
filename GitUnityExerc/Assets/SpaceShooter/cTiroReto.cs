using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cTiroReto : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 xy;
    public float vel;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.Normalize(xy) * vel;
    }

}
