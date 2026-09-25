using UnityEngine;
public class GameManager : Singleton<GameManager>
{
    private Enemy[] allEnemies;
    [SerializeField] private EnemyFactory Factory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Factory.CreateEnemy();
        allEnemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None);
    }
    // Update is called once per frame
    void Update()
    {
        foreach (Enemy enemy in allEnemies)
        {
            enemy.EnemyMove();
        }
    }
}
