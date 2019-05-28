using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpScript : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.Lerp(transform.position , player.position , 0.02f);
        pos = new Vector3(pos.x , pos.y , -10);
        transform.position = pos;
    }
}
