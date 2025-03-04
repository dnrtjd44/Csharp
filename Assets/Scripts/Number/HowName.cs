using UnityEngine;

public class HowName : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // string(문자열 변수) name 변수 선언하고 나루토 초기화 (처음)
        string name = "나루토";

        int age = 50;

        Debug.Log($"너의 이름은 {name}이고 나이는 {age}살이야");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
