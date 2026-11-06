using UnityEngine;
public class GameManager : Singleton<GameManager>
{
    private Enemy[] allEnemies;
    [SerializeField] private ObjectFactory Factory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Factory.SpawnApple();
        allEnemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
