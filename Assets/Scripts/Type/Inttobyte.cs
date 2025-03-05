using UnityEngine;

public class Inttobyte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수 x를 선 언 하 고 255로 초 기 화 
        int x = 255;

        //byte형 변수 y 를 선언하고 x 의 값으로 초기화
        //byte 0~255 저 장 범 위
        byte y = (byte)x;
        Debug.Log(x + "->" + y);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
