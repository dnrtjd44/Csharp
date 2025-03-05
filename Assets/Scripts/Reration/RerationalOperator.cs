using UnityEngine;

// RelationalOperator(관계형 연상자, 비교 연산자)
// <(작음), <=(작거나 같음), >(큼), >=(크거나 같음), == (같음), != (다름)
// 결과 : true(참), false(거짓)

public class RerationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y); //x가 y보다 작으냐?
        Debug.Log(x <= y); //x가 y보다 작거나 같으냐?
        Debug.Log(x > y); //x가 y보다 크냐?
        Debug.Log(x >= y); //x가 y보다 크거나 같으냐?
        Debug.Log(x == y); //x가 y보다 같으냐?
        Debug.Log(x != y); //x가 y보다 다르냐?

        Debug.Log("AAA" == "aaa"); //


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
