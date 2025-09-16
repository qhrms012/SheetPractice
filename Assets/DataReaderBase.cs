using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DataReaderBase : ScriptableObject
{
    [Header("시트 주소")][SerializeField] public string sheet = "";
    [Header("스프레드 시트의 시트 이름")][SerializeField] public string sheetName = "";
    [Header("읽기 시작할 행 번호")][SerializeField] public int sheetIndex = 2;
    [Header("읽을 마지막 행 번호")][SerializeField] public int sheetEnd = -1;
}
