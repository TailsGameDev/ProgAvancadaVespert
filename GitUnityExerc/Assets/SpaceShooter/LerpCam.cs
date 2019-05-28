using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCam : MonoBehaviour
{
    public Transform CoisaPraSeguir;

    private void Start () {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = Vector3.Lerp(transform.position, CoisaPraSeguir.position, 0.02f);
        pos = new Vector3(pos.x , pos.y , -10);
        transform.position = pos;
    }


    //nao esta sendo usada essa corrotina. Era soh um exemplo pro Franco
    IEnumerator minhaCorrotina(float o) {
        yield return new WaitForSeconds(o);
        Destroy(gameObject);

        float t = 0;
        while (t < o) {
            yield return null;
            t += Time.deltaTime;
        }
    }
}
