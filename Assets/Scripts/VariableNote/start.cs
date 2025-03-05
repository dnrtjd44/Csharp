using UnityEngine;

public class start : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // int numBer = 3;

        // string name = "은(는) 홀수입니다";

        // Debug.Log($"{numBer} 은(는) 홀수입니다");


        int number = 3; //int 형 변수 number로 선언하고 3으로 초기화한다
        string resullt = "홀수"; //string형 변수 result 선언하고 "홀수"로 초기화한다

        Debug.Log($"{number}은(는) {resullt}입니다");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
