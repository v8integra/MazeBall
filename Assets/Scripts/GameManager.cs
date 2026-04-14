using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timeLeft = 30f;
    bool gameOver = false;
    bool win = false;
    public GameObject winText;
    public GameObject gameOverText;
    public GameObject ball;
    public PlayerController player;

    public TextMeshProUGUI timerText;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(timeLeft >= 0 && !win)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = timeLeft.ToString("F1") + " secs";
        }
        else if(timeLeft <= 0 && !win)
        {
            GameOver();
        }

    }

    public void GameWin()
    {
        win = true;
        winText.SetActive(true);
        player.enabled = false;
        ball.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        player.enabled = false;
        ball.SetActive(false);
        gameOver = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
