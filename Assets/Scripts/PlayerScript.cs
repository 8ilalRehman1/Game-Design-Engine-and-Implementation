using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed = 10;
    [SerializeField] float jumpForce = 10;
    [SerializeField] float healthPoints = 300;
    [SerializeField] bool isDead;
    [SerializeField] bool winState;
    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() // Update is called once per frame
    {
        float moveInput = Input.GetAxis("Horizontal"); 
        rb.linearVelocity = new Vector2 (moveInput * speed, rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
        if (healthPoints == 0)
        {
            Die();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            winState = true;
            Debug.Log("You Win!");
            Application.Quit();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log($"{healthPoints}");
            Debug.Log("Ouch");
        }
    }
    private void Die()
    {
        Debug.Log("You Lose! Level Restart.");
        isDead = true;
        Destroy(gameObject);
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    public void TakeDamage(float damage)
    {
        healthPoints -= damage;
    }
    public void addHealth(float health)
        { healthPoints += health; }
    public void showHealth()
    {
        Debug.Log(healthPoints);
    }
}
