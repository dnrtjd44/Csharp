using UnityEngine;

// + : ���ϱ� ������ �߰� ���
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + "world!!"); //���ڿ� ���ϱ�
        Debug.Log("HI" + "" + "EveryOne");

        Debug.Log("123" + "456");               // ���ڿ� + ���ڿ� -> ���ڿ�
        Debug.Log("123" + 456);                 // ���ڿ� + ���� -> ���ڿ�

        Debug.Log(123 + "456" + 789 + 890);     // ���� + ���ڿ�(�ڸ� ������� ���ڿ� ������ ���ڿ���) -> ���ڿ�
        Debug.Log(123 + 456);                   // ���� + ���� -> ����

        Debug.Log("123" + true);                // ���ڿ� + bool�� -> ���ڿ�



        //Debug.Log("123" - 456);                 //���ڿ����� ������ ������ ����� ����




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
