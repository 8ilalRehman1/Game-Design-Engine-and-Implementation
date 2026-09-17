using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float damage = 1;
    private float health = 2;
    private float speed = 3;

    public Rigidbody2D rb;
    public bool isDead;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
