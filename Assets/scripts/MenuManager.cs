using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Sala de inicio");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
