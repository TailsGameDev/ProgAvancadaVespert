using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    Animator animator;
    public Transform barraVida;
    const float vidaMaxima = 100;
    float vidaAtual;
    public int danoHit = 10;
    bool morto = false;

    void Start()
    {
        vidaAtual = vidaMaxima;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && !morto) {
            vidaAtual -= danoHit;
            if (vidaAtual > 0) {
                animator.SetTrigger("damaged");
                barraVida.transform.localScale = new Vector3(vidaAtual / vidaMaxima+0.01f ,
                                                    barraVida.transform.localScale.y ,
                                                    barraVida.transform.localScale.z);
            } else {
                morto = true;
                vidaAtual = 0;
                animator.SetTrigger("morreu");
            }
        }

        if (Input.GetKeyDown("r") && morto) {
            morto = false;
            if (vidaAtual <= 0) {
                vidaAtual = vidaMaxima;
                barraVida.transform.localScale = new Vector3(vidaAtual / vidaMaxima + 0.01f ,
                                                       barraVida.transform.localScale.y ,
                                                       barraVida.transform.localScale.z);
                animator.SetTrigger("ressuscitou");
            }
        }
    }
}
