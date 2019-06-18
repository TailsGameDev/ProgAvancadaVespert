using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CBotoes : MonoBehaviour
{
    public void CarregaCena(string cena) {
        SceneManager.LoadScene(cena);
    }
}
