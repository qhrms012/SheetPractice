using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SimpleSheetLoader : MonoBehaviour
{
    // ���⿡ ��Ʈ �Խ��� URL �ٿ��ֱ�
    public string csvUrl = "1ls9Ex1mnZJ073nyx8Qj5dBQ-kYTftmO9lWHPH1tYBSE";

    //void Start()
    //{
    //    StartCoroutine(LoadSheet());
    //}

    //IEnumerator LoadSheet()
    //{
    //    using (UnityWebRequest req = UnityWebRequest.Get(csvUrl))
    //    {
    //        yield return req.SendWebRequest();

    //        if (req.result != UnityWebRequest.Result.Success)
    //        {
    //            Debug.LogError("��Ʈ �ҷ����� ����: " + req.error);
    //        }
    //        else
    //        {
    //            string text = req.downloadHandler.text;
    //            Debug.Log("��Ʈ ����:\n" + text);
    //        }
    //    }
    //}
}

