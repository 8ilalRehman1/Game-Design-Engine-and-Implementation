using UnityEngine;

public class Collectable : MonoBehaviour, CollectInterface
{
    [SerializeField] bool isCollected;
    PlayerScript player;
    public void Capture (PlayerScript player)
    { isCollected = true;
        Debug.Log("Captured");
    }

    void OnCollision2D(Collider2D collision)
    {
        if ( (collision.CompareTag("Player")))
        {
            Capture(collision.GetComponent<PlayerScript>());
            Debug.Log("Collided");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isCollected == true)
        {
            Destroy(gameObject);
            player.IncreaseScore();
            Debug.Log("Collected");
        }
    }
    
}
