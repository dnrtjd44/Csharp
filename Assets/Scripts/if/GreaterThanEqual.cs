using UnityEngine;

//�μ��� �Է� �޾� ���߿��� ū���� ���
public class GreaterThanEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5;
        int second = 8;

        //first�� second�� ���ؼ� Ŭ���� ���
        //���� first�� second �̻��̸� first ���� ��� �ƴϸ� second ���� ���

        if(first >= second)
        {
            Debug.Log($"ū ���� {first}");

        }
        else
        {
            Debug.Log($"ū ���� {second}");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
