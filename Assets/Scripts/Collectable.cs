using UnityEngine;

public class Collectable : MonoBehaviour, CollectInterface
{
    [SerializeField] bool isCollected;
    [SerializeField] float healthIncrease = 20f;

    public 


    // Update is called once per frame
    void Update()
    {
        if (isCollected == true)
        {
            Destroy(gameObject);
        }
    }
    
}
