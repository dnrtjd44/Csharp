using UnityEngine;

public class HowName : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // string(���ڿ� ����) name ���� �����ϰ� ������ �ʱ�ȭ (ó��)
        string name = "������";

        int age = 50;

        Debug.Log($"���� �̸��� {name}�̰� ���̴� {age}���̾�");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
