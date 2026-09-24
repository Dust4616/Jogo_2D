using System.Collections;
using UnityEngine;

public class PlayerOnewayPlataform : MonoBehaviour
{
    private GameObject currentOnewayPlataform;

    [SerializeField] private BoxCollider2D PlayerCollider; // faz com que podemos pegar o box collider do player como referencia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if(currentOnewayPlataform != null)// caso isso seja verdadeiro com base na condição anterior, vai começar a rodar o codigo de deixar os colisores desabilitados;
            {
                StartCoroutine(DisableCollision());
            }
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OneWayPlataform"))
        {
            currentOnewayPlataform = collision.gameObject;
        }  
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OneWayPlataform"))
        {
            currentOnewayPlataform = null;
        }
    }

    private IEnumerator DisableCollision()
    {
        BoxCollider2D plataformCollider = currentOnewayPlataform.GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(PlayerCollider, plataformCollider);// vai fazer com que a colisão da plataforma e do player seja ignorada;
        yield return new WaitForSeconds(1f); // define em quanto tempo a plataforma e o player vão voltar a ter colisor;
        Physics2D.IgnoreCollision(PlayerCollider, plataformCollider, false);

    }
    
}
