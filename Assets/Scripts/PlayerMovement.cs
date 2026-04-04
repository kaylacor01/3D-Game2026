using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 180f;
    private Rigidbody rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(0f, horizontal * turnSpeed * Time.deltaTime, 0f);
        
        Vector3 movement = transform.forward * vertical * moveSpeed;
        rb.linearVelocity = movement;
    }
}
