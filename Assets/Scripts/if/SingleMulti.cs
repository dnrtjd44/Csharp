using UnityEngine;


// ���๮: �ܹ�(1��), ����(2�� �̻�)

public class SingleMulti : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�
        /*
         if(���ǽ�)
        {
        
            //���๮1
            //���๮2
            //.....  
              
        }
        */             
                         
        
        //�ܹ��� {} ���๮�� 1�� 
        if(1 == 1)
        {
            Debug.Log("�ܹ� 1");
        }

        if (1 == 1) // {} �ڵ����� ������ �Ǹ� �ٷ� �Ʒ��ִ� 1�ٸ� ����
            Debug.Log("�ܹ� 2");

        if (1 == 1) Debug.Log("�ܹ� 3");

        //���� (���๮�� 2�� �̻��϶�)

        if(1 == 1)
        {

            Debug.Log("���� 1");
            Debug.Log("���� 2");

        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*
 
if()
{




}
 
 
 
 
 */