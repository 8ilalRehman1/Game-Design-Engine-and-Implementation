using UnityEngine;

public class EvilHexagon : Enemy
{
    public override void EnemyMove()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MUHAHA I'M A EVIL HEXAGON");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
