using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cArmaInimigo : MonoBehaviour {
    public GameObject tiro;
    public float delay;
    float contador;

    void Start () {
        contador = 0;
    }

    void Update () {
        Atirar(true);
    }

    void Atirar (bool teclaApertada) {
        if (teclaApertada) {
            contador += Time.deltaTime;
            if (contador >= delay) {
                contador = 0;
                Instantiate(tiro , transform.position , Quaternion.identity);
            }
        } else {
            contador = delay;
        }
    }
}
