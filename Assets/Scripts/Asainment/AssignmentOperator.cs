using UnityEngine;


// = : AssignmentOperator(�Ҵ�(����) ������) - ������ ���� �����Ѵ�
public class AssignmentOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string name = "ȫ�浿"; //����, ����, �Ҵ�, �ʱ�ȭ
        int age = 19;

        Debug.Log($"�̸��� {name}, ���̴� {age}");

    }
}
