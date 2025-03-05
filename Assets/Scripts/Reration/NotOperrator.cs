using UnityEngine;

// NotOperator (부정 연산자, Not) : ! 참이면 거짓이고, 거짓이면 참으로 변환
// 결과 : true, false
public class NotOperrator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]참일때
        Debug.Log(!true);   // -> false
        
        //[2]거짓일때
        Debug.Log(!false);   // -> true

        //[3]
        bool bin = false;

        Debug.Log(!bin);    // -> true
        Debug.Log(!!bin);    // -> false
        Debug.Log(!(!(!bin)));    // -> true


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
