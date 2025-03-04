using UnityEngine;

public class ConstanceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수
        string name = "홍길동";
        name = "이순신"; //수정 가능
        name = "이장";
        name = "이지영";
        name = "이영지";
        name = "이기신";

        //상수
        const int AGE = 20; //AGE를 20으로 고정
       // AGE = 21; //상수라서 수정불가능, 수정하면 에러 발생

        //변수, 상수 사용
        Debug.Log($"{name} - {AGE}");

    }

    
}
