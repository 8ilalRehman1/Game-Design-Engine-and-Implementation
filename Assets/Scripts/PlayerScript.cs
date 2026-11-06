using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class PlayerScript : Singleton<PlayerScript>
{
    private Rigidbody2D rb;
    [SerializeField] float speed = 10;
    [SerializeField] bool isDead;
    [SerializeField] bool winState;
    public float score = 0;
    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() // Update is called once per frame
    {
        float moveInput = Input.GetAxisRaw("Horizontal"); 
        rb.linearVelocity = new Vector2 (moveInput * speed, rb.linearVelocity.y);
        

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
    public void IncreaseScore()
    {
        score += 1;
    }

}
