using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Game game;

    private void OnTriggerEnter()
    {
        game.ReachFinish();
    }
}
