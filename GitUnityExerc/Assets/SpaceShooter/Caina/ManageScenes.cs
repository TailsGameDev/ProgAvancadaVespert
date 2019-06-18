using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    float tempo;

    public static ManageScenes instancia;
    private void Awake () {
        if (!instancia) {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    IEnumerator CarregaCena (string cena) {
        yield return new WaitForSeconds(tempo);
        SceneManager.LoadScene(cena);
    }

    public void CarregaCena (string cena, float tempo) {
        this.tempo = tempo;
        StartCoroutine("CarregaCena", cena);
    }
}
