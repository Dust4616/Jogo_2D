using UnityEngine;
using UnityEngine.SceneManagement; // item nescessário para gerenciar as cenas;

public class MenuScene : MonoBehaviour
{
    public GameObject painelOver;
    public GameObject painelPause;
    public GameObject painelVictory;
    bool pausado = false;
    bool GameOver = false;
    bool Victory = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        painelPause.SetActive(false);// o setActive serve para abilitar ou desativar um certo objeto dentro do jogo, nesse caso o objeto detro da variavel especificada;
        painelOver.SetActive(false);
        painelVictory.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pausado)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        if(GameOver == false)
        {
            pausado=true;
            painelPause.SetActive(true);
            Time.timeScale = 0f; // isso trava o jogo ipedindo que o jogador possa realizar ações enquanto a tela de pause estiver ativa;
        }
    }
    public void Continue()
    {
        pausado = false;
        painelPause.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void SeeGameOver()
    {
        GameOver = true;
        painelOver.SetActive(true);
        Time.timeScale = 0f;
    }

    public void SeeVictory()
    {
        Victory = true;
        painelVictory.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resetar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // faz com que recarregue a cena que o jogador esta, sem precisar configurar toda vez em cada cena especifica;
    }

    public void MenuReturn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
