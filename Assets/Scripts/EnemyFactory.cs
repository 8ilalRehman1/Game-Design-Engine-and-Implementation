using UnityEngine;

public class EnemyFactory : Factory
{
    [SerializeField] GameObject evilHexagonPrefab;
    [SerializeField] Transform EHspawnLocation;
    public override Enemy CreateEnemy()
    {
        GameObject obj = Instantiate(evilHexagonPrefab, EHspawnLocation.position, Quaternion.identity);
        return obj.GetComponent<Enemy>();
    }
}
