using UnityEngine;

// + : 더하기 연산의 추가 기능
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + "world!!"); //문자열 더하기
        Debug.Log("HI" + "" + "EveryOne");

        Debug.Log("123" + "456");               // 문자열 + 문자열 -> 문자열
        Debug.Log("123" + 456);                 // 문자열 + 숫자 -> 문자열

        Debug.Log(123 + "456" + 789 + 890);     // 숫자 + 문자열(자리 상관없이 문자열 있으면 문자열됨) -> 문자열
        Debug.Log(123 + 456);                   // 숫자 + 숫자 -> 숫자

        Debug.Log("123" + true);                // 문자열 + bool형 -> 문자열



        //Debug.Log("123" - 456);                 //문자열에서 정수형 데이터 빼기는 없다




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
