using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 4;
    public Text healthText;

    void Update()
    {
        healthText.text = health.ToString();
    }
}
