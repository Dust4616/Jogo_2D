using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();// rb vai receber o Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        float movehoriontal = Input.GetAxis("Horizontal");//Vai reconhecer o movimento horizontal
        rb.linearVelocity = new Vector2(movehoriontal * speed, rb.linearVelocity.y);//Vector2 tem vetores, no caso 2, e eles são separados pela virgula, onde o primeiro ta mechendo no eixo x, e o outro no eixo y
        if ( Input.GetKeyDown(KeyCode.Space))// Condição que ve se a tecla espaço está sendo apertada
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); //Adiciona uma força no objeto fazendo ele subir, e tem o forcemode para deixar a fisica mais realista, por conta que sem ele o objeto apenas iria se teleportar para a posição 5
        }
    }
}
