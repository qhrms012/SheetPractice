#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class EnemySheetImporter : MonoBehaviour 
{
    const string csvUrl = "https://docs.google.com/spreadsheets/d/1ls9Ex1mnZJ073nyx8Qj5dBQ-kYTftmO9lWHPH1tYBSE/export?format=csv"; // ��Ʈ �ּ�
    string sheetName = "Sheet";

    private void Start()
    {
        StartCoroutine(Import());
    }
    [MenuItem("Tools/Import/Enemy From Sheet")]
    IEnumerator Import()
    {       
        UnityWebRequest www = UnityWebRequest.Get(csvUrl);
        yield return www.SendWebRequest();

        

        string[] lines = www.downloadHandler.text.Split('\n');
        List<EnemyData> list = new List<EnemyData>();

        for (int i = 1; i < lines.Length; i++) // ù���� ���
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;

            string[] cols = lines[i].Split(',');

            EnemyData enemy = new EnemyData
            {
                id = cols[0],
                name = cols[1],
                hp = int.Parse(cols[2]),
                speed = float.Parse(cols[3])
            };
            list.Add(enemy);
        }

        // SO ���� ����
        EnemyDatabase db = ScriptableObject.CreateInstance<EnemyDatabase>();
        db.enemies = list.ToArray();

        AssetDatabase.CreateAsset(db, "Assets/EnemyDB.asset");
        AssetDatabase.SaveAssets();

        Debug.Log($"�ҷ����� �Ϸ�: {list.Count}��");
    }

}
#endif
