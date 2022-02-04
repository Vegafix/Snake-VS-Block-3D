using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Player player;
    public PlayerMovement movement;
    public GameObject restartMenu;
    public GameObject finishMenu;
    public Text levelNumber;
    public Text bestScoreText;

    private float _restartDelay = 1f;
    public int score;

    private void Awake()
    {
        levelNumber.text = (SceneManager.GetActiveScene().buildIndex + 1).ToString();

    }
    private void Update()
    {
        bestScoreText.text = "Best: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void ScoreCount()
    {
        score++;
        if (score > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", score);
    }
    public void Die()
    {
        movement.enabled = false;
        player.healthText.enabled = false;
        Invoke("Lose", _restartDelay);
    }
    public void ReachFinish()
    {
        movement.enabled = false;
        finishMenu.SetActive(true);
    }
    void Lose()
    {
        restartMenu.SetActive(true);
    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
    }
}
