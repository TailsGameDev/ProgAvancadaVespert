using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cTiroCaina : MonoBehaviour
{
    float t = 0;
    public float vel;
    float raio = 1;
    Vector3 originalPos;

    void Start()
    {
        originalPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = originalPos+raio * (new Vector3(Mathf.Sin(t) , Mathf.Cos(t) , 0));
        t += Time.deltaTime * vel;
        raio += Time.deltaTime;
    }
}
