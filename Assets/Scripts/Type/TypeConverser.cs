using UnityEngine;

public class TypeConverser : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //double 형 실수형 변수 d 를선언하고 12.34로 초기화
        
        double d = 12.31; //
        
        //int형 정수혀형 변 수 i 를 선언하고 1234로 초기 화 

        int i = 1234;


        //[1] double > int : 묵시적 (암묵적, 암시적) 형식변환 
        d = i;
        Debug.Log("암묵적 형식변환:" + d);

        d = 12.34;
        i = 1234;

        //[2] int < double : 명시적인 형식 변환 필요
        i = (int)d; //() : 캐스트 연산자
        Debug.Log("명시적 형식변환:" + i);


        d = 12.34;
        i = 1234;

        //[3] 다른 형식간의 변환
        string s = ""; //string 변수 s를 선언하고 ""(빈값)으로 초기화
        s = i.ToString();
        Debug.Log("다른 형식변환:" + s);




    }

    
}
