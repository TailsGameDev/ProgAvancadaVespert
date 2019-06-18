using UnityEngine;

public class cPlayer : MonoBehaviour
{
    Rigidbody2D rb;
    public float vel;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update() {
      mover(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    //vertical e horizontal devem estar entre -1 e 1
    void mover(float vertical, float horizontal) {
      Vector2 velocidade = new Vector2(vertical, horizontal);
      velocidade.Normalize();
      velocidade = velocidade * vel;
      rb.velocity = velocidade;
    }
}
