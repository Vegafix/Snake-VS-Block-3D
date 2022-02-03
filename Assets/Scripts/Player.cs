using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 4;
    public Text healthText;

    void Update()
    {
        healthText.text = health.ToString();
        if (health <= 0)
            Debug.Log("You Dead");
    }
}
