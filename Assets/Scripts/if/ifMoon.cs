using UnityEngine;

// ���� score�� 60 �� �̻��̸� "�հ�" �̶�� ���,
// score 61��

public class ifMoon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        if(score�� 60 �̻�)
            {

            
            "�հ�"�̶�� ���

        }
            */


            int score = 61;

            if (score >= 60) // ���ǹ��� ���̸� ��Ͼȿ� �ִ� ���๮ ����

            {
                //���๮
                Debug.Log("�հ�");

            }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*
 
if�� - ���ǹ�
���ǽ��� ���϶��� ���๮�� ����˴ϴ�
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�.


//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�
if(���ǽ�)
{
    //���๮1
    //���๮2
    //.....
}
 


 
 */
