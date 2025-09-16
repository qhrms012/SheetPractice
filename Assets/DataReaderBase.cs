using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DataReaderBase : ScriptableObject
{
    [Header("��Ʈ �ּ�")][SerializeField] public string sheet = "";
    [Header("�������� ��Ʈ�� ��Ʈ �̸�")][SerializeField] public string sheetName = "";
    [Header("�б� ������ �� ��ȣ")][SerializeField] public int sheetIndex = 2;
    [Header("���� ������ �� ��ȣ")][SerializeField] public int sheetEnd = -1;
}
