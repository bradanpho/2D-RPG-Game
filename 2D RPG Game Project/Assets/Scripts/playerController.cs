using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed

    private Rigidbody2D rb;
    private Vector2 input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Get Rigidbody2D component
    }

    private void Update()
    {
        // Get input for movement
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");

        // Normalize input to prevent faster diagonal movement
        if (input.magnitude > 1)
        {
            input = input.normalized;
        }
    }

    private void FixedUpdate()
    {
        // Apply movement using velocity for smooth motion
        rb.velocity = input * moveSpeed;
    }
}
