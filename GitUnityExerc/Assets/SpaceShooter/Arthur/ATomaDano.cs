using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATomaDano : cTomaDano
{
    static int qtddMortos = 0;

    private void Start()
    {
        qtddMortos = 0;
    }

    protected override void AoMorrer()
    {
        qtddMortos++;
        print(qtddMortos);
        if (qtddMortos >= 3)
        {
            ManageScenes.instancia.CarregaCena(cenaParaCarregarAoMorrer, 2f);
        }
        Destroy(gameObject);
    }
}
