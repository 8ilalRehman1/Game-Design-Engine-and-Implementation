using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{

    private Rigidbody2D rb;
    private float movementX;
    private float speed = 1;

    public bool isDead;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        Vector3 movement = new Vector2(movementX, 0.0f);
        rb.AddForce(movement * speed);
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
