using UnityEngine;

public class Inttobyte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int�� ���� x�� �� �� �� �� 255�� �� �� ȭ 
        int x = 255;

        //byte�� ���� y �� �����ϰ� x �� ������ �ʱ�ȭ
        //byte 0~255 �� �� �� ��
        byte y = (byte)x;
        Debug.Log(x + "->" + y);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
