using UnityEngine;


//IncrementOperator (증가연산자) : 정수형 변수의 값을 1 증가
//DectementOperator (감소연산자) : 정수형 변수의 값을 1 감소

public class IncremantOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = -100;
        //1증가식
        //num = num + 1;
        //num += 1;
        //++num; //++을 증가 연산자 101
        --num; //--을 감소 연산자 -101

        Debug.Log("num: " + num);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
