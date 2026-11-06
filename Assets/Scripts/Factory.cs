using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    public abstract Enemy CreateEnemy();
    public abstract Apple SpawnApple();
}
