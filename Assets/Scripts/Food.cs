using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public int maxFood;
    public Text healText;

    private int _healPoints;

    void Awake()
    {
        _healPoints = Random.Range(1, maxFood + 1);
        healText.text = _healPoints.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent(out Player player))
        {
            player.health += _healPoints;
            Destroy(gameObject);
        }
    }
}
