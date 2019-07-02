using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contInimigoF1 : MonoBehaviour
{
    public static int contInimigo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (contInimigo <= 0)
        {
            ManageScenes.instancia.CarregaCena("cvitoria", 2f);
            GameObject[] tiros = GameObject.FindGameObjectsWithTag("tiro");
            foreach (GameObject tiro in tiros)
            {
                Destroy(tiro);
            }
            
        }
    }
}
