using UnityEngine;

public class Collectable : MonoBehaviour, CollectInterface
{
    [SerializeField] bool isCollected;
    [SerializeField] float healthIncrease = 20f;

    public void Capture (PlayerScript player)
    { isCollected = true;
    player.addHealth(healthIncrease);
        player.showHealth();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ( (collision.CompareTag("Player")))
        {
            Capture(collision.GetComponent<PlayerScript>());
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isCollected == true)
        {
            Destroy(gameObject);
        }
    }
    
}
