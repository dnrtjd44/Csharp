using UnityEditor.Rendering;
using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int Temp;


        //�ڸ��ٲٱ�

        Temp = i;   // �ӽú��� (temp)�� i�� ����
        i = j;      // i ������ j ��(200) �� ����
        j = Temp;   //j ������ �ӽú��� (temp)�� ����Ǿ��� i���� ����


        Debug.Log($"ó������ i: {i}, j: {j},");
              


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*
[Q]

+,-,*,/ ���� ������� ���� I, J�� ���� ���� �ٲپ �����ϼ���
temp ������ ���� �̿��غ�����.

[OUTPUT]

ó�� i:100, j:200
���� i:200, j:100
*/