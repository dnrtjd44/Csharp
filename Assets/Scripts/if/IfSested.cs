using UnityEngine;

// ��ø if ��
public class IfSested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "ȫ�浿";
        int age = 20;

        //�̸��� ȫ�浿�� ������ ���๮(��ɹ�)�� ����
        if (name == "ȫ�浿")
       /* {
            //���๮ - ���� ���̰� 20�� ������ ���๮ ����
            if(age == 20)
            {

                //���๮
                Debug.Log($"�̸��� {name}, ���̴�{age}");

            }



        }*/

        if (name == "ȫ�浿" && age == 20)
                    {
            Debug.Log($"�̸��� {name}, ���̴� {age}");

        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
