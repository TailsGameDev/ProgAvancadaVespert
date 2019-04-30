using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LJogador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0,10,0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            GetComponent<Rigidbody2D>().velocity = new Vector3(6,0,0);
            print("apertou left");
        }
        
    }
}
