using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Game game;
    private Text _text;
    private void Awake()
    {
        _text = GetComponent<Text>();
    }
    private void Update()
    {
        _text.text = game.score.ToString();
    }
}
