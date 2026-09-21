using UnityEngine;

public class EvilTile : Enemy
{
    public override void EnemyMove()
    {
        transform.Translate(Vector2.left * (speed * 0.1f) * Time.deltaTime);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MUHAHA I'M A EVIL TILE!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
