using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Enemy[] allEnemies;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allEnemies = FindObjectsOfType<Enemy>();
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
