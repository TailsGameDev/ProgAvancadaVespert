using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cTiroCircular : MonoBehaviour
{
    Rigidbody2D rb;
    public float vel;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.up * vel;
        rb.transform.eulerAngles += new Vector3(0, 0, 10f);
    }
}
