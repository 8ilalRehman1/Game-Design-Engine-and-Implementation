using UnityEngine;

public class ObjectFactory : Factory
{
    [SerializeField] GameObject evilHexagonPrefab;
    [SerializeField] Transform EHspawnLocation;
    [SerializeField] GameObject applePrefab;
    public override Enemy CreateEnemy()
    {
        GameObject obj = Instantiate(evilHexagonPrefab, EHspawnLocation.position, Quaternion.identity);
        return obj.GetComponent<Enemy>();
    }
    public override Apple SpawnApple()
    {
        GameObject obj = Instantiate(applePrefab, EHspawnLocation.position, Quaternion.identity);
        return obj.GetComponent<Apple>();
    }
}
