using UnityEngine;

public class ObjectFactory : Factory
{
    
    [SerializeField] Transform EHspawnLocation;
    [SerializeField] GameObject applePrefab;
    
    public override Apple SpawnApple()
    {
        GameObject obj = Instantiate(applePrefab, EHspawnLocation.position, Quaternion.identity);
        return obj.GetComponent<Apple>();
    }
}
