using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyDatabase enemyDB; // �����Ϳ��� SO �巡��&���

    void Start()
    {
        foreach (var e in enemyDB.enemies)
        {
            Debug.Log($"{e.name} ü��={e.hp}, �ӵ�={e.speed}");
        }
    }
}

