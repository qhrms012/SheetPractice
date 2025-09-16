#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;

public class EnemySheetImporter
{
    [MenuItem("Tools/Import/Enemy From Sheet")]
    public static void Import()
    {
        string csvUrl = "1ls9Ex1mnZJ073nyx8Qj5dBQ-kYTftmO9lWHPH1tYBSE"; // ��Ʈ �ּ�
        string sheetName = "Sheet";

        UnityWebRequest www = UnityWebRequest.Get(csvUrl);
        www.SendWebRequest();

        while (!www.isDone) { } // ������ ����ó�� (Editor������ OK)

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(www.error);
            return;
        }

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
