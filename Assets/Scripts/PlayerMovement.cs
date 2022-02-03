using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed;
    public float sidewaysForce;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        _rb.velocity = Vector3.forward * forwardSpeed;
        if (Input.GetKey("d"))
            _rb.velocity = Vector3.right * sidewaysForce + Vector3.forward * forwardSpeed;
        if (Input.GetKey("a"))
            _rb.velocity = Vector3.left * sidewaysForce + Vector3.forward * forwardSpeed;
    }
}
