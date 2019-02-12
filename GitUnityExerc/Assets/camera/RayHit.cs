using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayHit : MonoBehaviour
{
    public delegate void ClickOnFloor(Vector3 point);
    public event ClickOnFloor clickOnFloor;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        int layerMask = 0;
        layerMask = ~layerMask; //hits everything
        if (Physics.Raycast(ray , out hit , Mathf.Infinity , layerMask)) {
            if (Input.GetMouseButtonDown(0)) {
                clickOnFloor(hit.point);
            }
        }
    }
}
