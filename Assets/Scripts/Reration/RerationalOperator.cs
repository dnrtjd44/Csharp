using UnityEngine;

// RelationalOperator(������ ������, �� ������)
// <(����), <=(�۰ų� ����), >(ŭ), >=(ũ�ų� ����), == (����), != (�ٸ�)
// ��� : true(��), false(����)

public class RerationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y); //x�� y���� ������?
        Debug.Log(x <= y); //x�� y���� �۰ų� ������?
        Debug.Log(x > y); //x�� y���� ũ��?
        Debug.Log(x >= y); //x�� y���� ũ�ų� ������?
        Debug.Log(x == y); //x�� y���� ������?
        Debug.Log(x != y); //x�� y���� �ٸ���?

        Debug.Log("AAA" == "aaa"); //


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
