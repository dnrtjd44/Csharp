using UnityEngine;


//OrOperator (Or ������): || �ϳ��� ���̸� ��
//��� : true, false
public class orOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �Ѵ� ���϶�
        Debug.Log(true || true);    //  -> true


        //[2] ���߿� �ϳ��� ���϶�
        Debug.Log(true || false);    //  -> true
        Debug.Log(false || true);    //  -> true


        //[1] �Ѵ� �����̸�
        Debug.Log(false || false);    //  -> false
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
