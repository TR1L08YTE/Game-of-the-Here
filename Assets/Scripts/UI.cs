using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [Header("Game Over")]
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private AudioClip gameOverSound;
    private GameObject pauseScreen;

    public void GameOver()
    {
        SceneManager.LoadScene("SecretLevel");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void One()
    {
        SceneManager.LoadScene(2);
    }

    public void Two()
    {
        SceneManager.LoadScene(3);
    }

    public void Three()
    {
        SceneManager.LoadScene(4);
    }

    public void Secret()
    {
        SceneManager.LoadScene(5);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}