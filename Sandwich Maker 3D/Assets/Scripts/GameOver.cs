using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshPro pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = "SCORE: " + GameFlow.playerScore.ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
