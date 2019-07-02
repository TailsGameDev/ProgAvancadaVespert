using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cTomaDano : MonoBehaviour
{
    public int vida;
    public string[] naoMeDaoDano;
    public string cenaParaCarregarAoMorrer;

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

        if (vida <= 0) {
            if (cenaParaCarregarAoMorrer == null || cenaParaCarregarAoMorrer == "")
            {
                print(this.name);
            }
            ManageScenes.instancia.CarregaCena(cenaParaCarregarAoMorrer , 2f);
            Destroy(gameObject);
        }
    }


}
