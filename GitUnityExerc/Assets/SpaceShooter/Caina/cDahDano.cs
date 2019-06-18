using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cDahDano : MonoBehaviour
{
    public int dano = 1;
    public string nome;

    public virtual void BateuEmAlgo() {
        Destroy(gameObject);
    }
}
