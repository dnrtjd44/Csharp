using UnityEngine;

//else ��ø��

public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char input = '1';

        // [1] input 'Y' �̸� YES ���
        // [2] input 'N' �̸� NO ���
        // [3] input �� �� ������ �̸� CANCEL ���

        if(input == 'y')
        {
            Debug.Log("YES");
        }
        else
        {
            if(input == 'n')
            {
                Debug.Log("NO");
            }
            else 
            {
                Debug.Log("CANCEL");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
