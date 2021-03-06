using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Platform : MonoBehaviour
{
    public int maxHitPoints;
    public Text hitPointText;

    private int _hitPoints;

    void Awake()
    {
        _hitPoints = Random.Range(1, maxHitPoints + 1);
    }
    private void Update()
    {
        hitPointText.text = _hitPoints.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out Player player))
        {
            Vector3 normal = collision.contacts[0].normal.normalized;
            float dot = Vector3.Dot(normal, Vector3.forward);
            if (dot <= 0.1) return;
            StartCoroutine(Cycle_Platform());
        }
        IEnumerator Cycle_Platform()
        {
            while (_hitPoints > 0)
            {
                if (player.health == 0)
                    yield break;
                player.TakingDamage();
                _hitPoints--;
                yield return new WaitForSeconds(.05f);
            }
            Destroy(gameObject);
        }
    }
}