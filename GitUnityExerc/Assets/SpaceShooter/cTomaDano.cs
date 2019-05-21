using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cTomaDano : MonoBehaviour
{
    public int vida;

    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D col) {
        cDahDano tiro = col.GetComponent<cDahDano>();
        if (tiro == null) return;

        // se estiver aqui significa que bateu em um tiro.
        vida -= tiro.dano;

        tiro.BateuEmAlgo();

        if (vida <= 0)
            Destroy(gameObject);
    }

}
