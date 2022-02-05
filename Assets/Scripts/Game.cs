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
    public int score;
    public AudioClip winning;
    public AudioClip losing;
    [Min(0)]
    public float volume;

    private float _restartDelay = 1f;
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
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
        _audio.Stop();
        _audio.PlayOneShot(losing, volume);
        Invoke("Lose", _restartDelay);
    }
    public void ReachFinish()
    {
        movement.enabled = false;
        finishMenu.SetActive(true);
        _audio.Stop();
        _audio.PlayOneShot(winning);
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
