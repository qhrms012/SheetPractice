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
        string csvUrl = "1ls9Ex1mnZJ073nyx8Qj5dBQ-kYTftmO9lWHPH1tYBSE"; // 시트 주소
        string sheetName = "Sheet";

        UnityWebRequest www = UnityWebRequest.Get(csvUrl);
        www.SendWebRequest();

        while (!www.isDone) { } // 간단히 동기처리 (Editor에서는 OK)

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(www.error);
            return;
        }

        string[] lines = www.downloadHandler.text.Split('\n');
        List<EnemyData> list = new List<EnemyData>();

        for (int i = 1; i < lines.Length; i++) // 첫줄은 헤더
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

        // SO 파일 저장
        EnemyDatabase db = ScriptableObject.CreateInstance<EnemyDatabase>();
        db.enemies = list.ToArray();

        AssetDatabase.CreateAsset(db, "Assets/EnemyDB.asset");
        AssetDatabase.SaveAssets();

        Debug.Log($"불러오기 완료: {list.Count}개");
    }
}
#endif
