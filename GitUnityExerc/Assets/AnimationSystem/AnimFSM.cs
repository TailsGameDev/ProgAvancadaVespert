using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Estados {
    IDLE,
    WALK
}

public class AnimFSM : MonoBehaviour
{
    Estados estadoAtual = Estados.IDLE;
    Estados proximoEstado = Estados.WALK;
    C_Animation c_Animation;

    public Sprite[] idleSprites, walkSprites;

    void Start()
    {
      c_Animation = GetComponent<C_Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        animFSM(Input.GetKey(KeyCode.Space));
    }

    void animFSM(bool andando){

      //FSM
      switch(estadoAtual){
        case Estados.IDLE:
          if (andando){
            c_Animation.sprites = walkSprites;
            c_Animation.transicao = true;
            proximoEstado = Estados.WALK;
          }
          break;
        case Estados.WALK:
          if (!andando){
            c_Animation.sprites = idleSprites;
            c_Animation.transicao = true;
            proximoEstado = Estados.IDLE;
          }
          break;
      }

      //atualizacao
      estadoAtual = proximoEstado;
    }
}
