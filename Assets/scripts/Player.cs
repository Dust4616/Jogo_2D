using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private bool isGrounded = false; // o boll so tem duas formas de verificação se é verdadeira ou falsa, e a varivel isGrounded e literalmente se esta no chão;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// rb vai receber o Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        float movehorizontal = Input.GetAxis("Horizontal");//Vai reconhecer o movimento horizontal
        rb.linearVelocity = new Vector2(movehorizontal * speed, rb.linearVelocity.y);//Vector2 tem vetores, no caso 2, e eles são separados pela virgula, onde o primeiro ta mechendo no eixo x, e o outro no eixo y
        if ( Input.GetKeyDown(KeyCode.Space) && isGrounded)// Condição que ve se a tecla espaço está sendo apertada, e se o chao e verdadeiro
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); //Adiciona uma força no objeto fazendo ele subir, e tem o forcemode para deixar a fisica mais realista, por conta que sem ele o objeto apenas iria se teleportar para a posição 5
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)// verifica se os colisores estão se tocando;
    {
        
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Vai reconhecer quando o is Grounded for igual a verdadeiro;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)// verifica se os colisores pararam de se encostar
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; // vai reconhecer quando o jogador estiver fora do chão impedindo que ele realize o pulo novamente;
        }
    }

}
