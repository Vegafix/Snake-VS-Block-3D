using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 3f;
    public float sidewaysForce = 500f;
    void FixedUpdate()
    {
        transform.Translate(0, 0, -forwardSpeed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            transform.Translate(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
