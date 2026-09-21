using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float damage = 10;
    [SerializeField] protected float speed = 0.01f;

    [SerializeField] private PlayerScript PlayerReference;


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
            PlayerReference.TakeDamage(damage);
        }
    }

    public virtual void EnemyMove()
    {
        transform.Translate(Vector2.left * speed *  Time.deltaTime);
    }

}
