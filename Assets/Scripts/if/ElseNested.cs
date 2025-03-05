using UnityEngine;

//else 중첩문

public class ElseNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char input = '1';

        // [1] input 'Y' 이면 YES 출력
        // [2] input 'N' 이면 NO 출력
        // [3] input 그 외 나머지 이면 CANCEL 출력

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
