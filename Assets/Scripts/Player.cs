using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 4;
    public Text healthText;
    public Game game;
    private AudioSource _audio;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        healthText.text = health.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out Food food))
        {
            _audio.Play();
        }
    }
    public void TakingDamage()
    {
        game.ScoreCount();
        health--;
        if (health == 0)
            game.Die();
    }
}
