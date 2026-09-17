using UnityEngine;

public class Collectable : MonoBehaviour
{
    public bool isCollected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
