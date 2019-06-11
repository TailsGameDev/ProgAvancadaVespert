using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cSeDestroi : MonoBehaviour
{
    public float tempoParaDestruicao;

    void Start () {
        Invoke("Destroise", tempoParaDestruicao);
    }

    void Destroise () {
        Destroy(this.gameObject);
    }
}
