using System;
using UnityEngine;

public class IncrementPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        int number1 = 3;
        int number2 = 5;

        int result1 = 0;
        int result2 = 0;

        number1--;              //2
        result1 = ++number1;    //3
        Debug.Log("result1: " + result1); //3


        ++number2;              //6
        result1 = number2--;    //6
        Debug.Log("result2: " + result2); //6
        */

        int num1 = 10;
        int num2 = 10;

        Debug.Log(--num1);  // 출력: 9 (먼저 감소 후 출력)
        Debug.Log(num2--);  // 출력: 10 (현재 값 출력 후 감소)
        Debug.Log(num2);    // 출력: 9 (이제 감소됨)




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
