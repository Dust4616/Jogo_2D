using UnityEngine;

public class ChangeScane : MonoBehaviour
{
    [SerializeField] bool goNextRoom;// faz com que ele apenas siga pra proxima sla na lista;
    [SerializeField] string roomName;// pode especificar a sala;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))//Observa se o player encostou no objeto de transição
        {
            if (goNextRoom)
            {
                SceneController.instance.Nextroom1();// vai carregr a proxima scene na lista
            }
            else
            {
                SceneController.instance.LoadScene(roomName);// vai carregar a que a gente especificar o nome
            }
        }
    }
}
