using UnityEngine;

[System.Serializable]
public class EnemyData
{
    public string id;
    public string name;
    public int hp;
    public float speed;
}

[CreateAssetMenu(fileName = "EnemyDB", menuName = "GameData/EnemyDB")]
public class EnemyDatabase : ScriptableObject
{
    public EnemyData[] enemies;
}
