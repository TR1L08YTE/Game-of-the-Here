using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public Image[] lifeImages = new Image[5];

    public Sprite activeLife;

    public Sprite deactiveLife;

    public GameObject winUi;

    public GameObject loseUi;

    public int nextLevelIndex;

    public void WinGame()
    {
        winUi.SetActive(true);
    }

    public void LoseGame()
    {
        loseUi.SetActive(true);
    }

    public void OnExitClicked()
    {
        SceneManager.LoadScene(0);
    }
    public void OnNextLevel()
    {
        SceneManager.LoadScene(3);
    }
    public void OnNextLevelClicked()
    {
        SceneManager.LoadScene(nextLevelIndex);
    }

    public void OnRetryClicked()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i);
    }

}