using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    [ContextMenu("Increase Score")]
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();

        if (score == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Gameover()
    {
        gameOverScreen.SetActive(true);
    }

 
}
