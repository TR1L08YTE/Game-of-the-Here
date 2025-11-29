using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Game Over")]
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private AudioClip gameOverSound;

    [Header("Pause")]
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private AudioClip pauseSound;

    [Header("Next Level")]
    [SerializeField] private GameObject nextScreen;
    [SerializeField] private AudioClip nextSound;

    public int nextLevelIndex;
    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Awake()
    {
        gameOverScreen.SetActive(false);
        pauseScreen.SetActive(false);
        nextScreen.SetActive(false);
    }

    public void Next()
    {
        SceneManager.LoadScene(2);
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

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        SoundManager.instance.StopMusicBGM();
        SoundManager.instance.PlaySound(gameOverSound);
        Time.timeScale = 0;
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PauseController.SetPause(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseScreen.activeInHierarchy)
                PauseGame(false);
            else
                PauseGame(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Next"))
        {
            nextScreen.SetActive(true);
        }
    }

    public void PauseGame(bool status)
    {
        pauseScreen.SetActive(status);
        SoundManager.instance.PlaySound(pauseSound);

        if (status)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void SoundVolume()
    {
        SoundManager.instance.ChangeSoundVolume(0.2f);
    }

    public void MusicVolume()
    {
        SoundManager.instance.ChangeMusicVolume(0.2f);
    }
}