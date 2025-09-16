using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyDatabase enemyDB; // 에디터에서 SO 드래그&드롭

    void Start()
    {
        foreach (var e in enemyDB.enemies)
        {
            Debug.Log($"{e.name} 체력={e.hp}, 속도={e.speed}");
        }
    }
}

