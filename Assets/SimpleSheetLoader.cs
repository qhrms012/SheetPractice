using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SimpleSheetLoader : MonoBehaviour
{
    // 여기에 시트 게시한 URL 붙여넣기
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
    //            Debug.LogError("시트 불러오기 실패: " + req.error);
    //        }
    //        else
    //        {
    //            string text = req.downloadHandler.text;
    //            Debug.Log("시트 내용:\n" + text);
    //        }
    //    }
    //}
}

