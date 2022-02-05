using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Game game;

    private ParticleSystem _ps;
    private void Awake()
    {
        _ps = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter()
    {
        game.ReachFinish();
        _ps.Play();
    }
}
