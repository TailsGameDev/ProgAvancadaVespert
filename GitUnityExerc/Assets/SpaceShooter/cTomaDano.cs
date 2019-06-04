using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cTomaDano : MonoBehaviour
{
    public int vida;
    public string[] naoMeDaoDano;

    bool Contem (string n) {
        bool tem = false;
        int i = 0;
        while (i < naoMeDaoDano.Length) {
            if (naoMeDaoDano[i] == n) tem = true;
            i++;
        }
        return tem;
    }

    void OnTriggerEnter2D (Collider2D col) {
        cDahDano tiro = col.GetComponent<cDahDano>();
        if (tiro == null) return;
        if (Contem(tiro.nome)) return;
        

        // se estiver aqui significa que bateu em um tiro.
        vida -= tiro.dano;

        tiro.BateuEmAlgo();

        if (vida <= 0)
            Destroy(gameObject);
    }

}
