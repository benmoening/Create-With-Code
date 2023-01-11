using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    private int strikes;
    public TextMeshProUGUI strikeText;
    private int outs;
    public TextMeshProUGUI outText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public bool isBallActive;
    public Button restartButton;
    public Button startButton;
    

    // Start is called before the first frame update
    public void Start()
    {
        score = 0;
        UpdateScore(0);
        strikes = 0;
        UpdateStrikes(0);
        outs = 0;
        UpdateOuts(0);
        isGameActive = true;
        isBallActive = false;
        
        //startButton = GetComponent<Button>();
        //startButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void UpdateStrikes(int strikesToAdd)
    {
        strikes += strikesToAdd;
        strikeText.text = "Strikes: " + strikes;
        if (strikes > 2)
        {
            UpdateOuts(1);
            strikes = 0;
        }
    }

    public void ResetStrikes()
    {
        strikes = 0;
    }

    public void UpdateOuts(int outsToAdd)
    {
        outs += outsToAdd;
        outText.text = "Outs: " + outs;
        if (outs > 2)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void BallSpawn()
    {
        isBallActive = true;
    }

    public void BallSpawns()
    {
        isBallActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
