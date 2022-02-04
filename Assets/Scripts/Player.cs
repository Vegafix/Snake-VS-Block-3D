using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 4;
    public Text healthText;
    public Game game;

    void Update()
    {
        healthText.text = health.ToString();
    }
    public void TakingDamage()
    {
        game.ScoreCount();
        health--;
        if (health == 0)
            game.Die();
    }
}
