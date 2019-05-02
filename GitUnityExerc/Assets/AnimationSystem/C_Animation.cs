using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Animation : MonoBehaviour
{
    // voce pode arrastar varios sprites de uma vez para setar esse vetor!!
    public Sprite[] sprites;
    public uint framesPorSegundo; // int positivo
    SpriteRenderer sr;
    public bool transicao;


    void Start()
    {
      sr = GetComponent<SpriteRenderer>();
      StartCoroutine(RunAnim());
    }

    // vai percorrendo o array Sprites e passando os frames
    IEnumerator RunAnim (){
      int  numeroDoFrame= 0;
      float timer = 0;
      float t = 1/framesPorSegundo;
      while (true){
        timer+= Time.deltaTime;
        bool deuTempoMaximo = timer >= t;
        //o if atualiza quando ha transicao de animacao ou no tempo maximo
        if (transicao || deuTempoMaximo){
          timer = 0; transicao = false;
          sr.sprite = sprites[numeroDoFrame];
          numeroDoFrame = (numeroDoFrame + 1) % sprites.Length;
        }
        yield return null;
      }
    }

}
