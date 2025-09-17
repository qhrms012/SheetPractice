using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SimpleSheetLoader : MonoBehaviour
{
    // ���⿡ ��Ʈ �Խ��� URL �ٿ��ֱ�
    const string csvUrl = "https://docs.google.com/spreadsheets/d/1ls9Ex1mnZJ073nyx8Qj5dBQ-kYTftmO9lWHPH1tYBSE/export?format=csv";

    void Start()
    {
        StartCoroutine(LoadSheet());
    }

    IEnumerator LoadSheet()
    {
        UnityWebRequest www = UnityWebRequest.Get(csvUrl);
        yield return www.SendWebRequest();

        string data = www.downloadHandler.text;
        print(data);
    }
}

