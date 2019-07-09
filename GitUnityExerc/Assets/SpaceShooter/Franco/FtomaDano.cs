using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FtomaDano : cTomaDano
{
  
    public static int contInimigo;
    // Start is called before the first frame update
    void Awake()
    {
        contInimigo = 0;
    }
    private void Start()
    {
        contInimigo += 1;
    }
    // Update is called once per frame
    void Update()
    {
        
         
        
    }
    protected override void AoMorrer()
    {
        if (contInimigo == 1)
        {
            ManageScenes.instancia.CarregaCena(cenaParaCarregarAoMorrer, 2f);
            GameObject[] tiros = GameObject.FindGameObjectsWithTag("tiro");
            foreach (GameObject tiro in tiros)
            {
                Destroy(tiro);
            }


        }
        Destroy(gameObject);
        contInimigo = contInimigo - 1;
    }

}
