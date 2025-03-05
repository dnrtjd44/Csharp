using UnityEngine;


//OrOperator (Or 연산자): || 하나라도 참이면 참
//결과 : true, false
public class orOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘다 참일때
        Debug.Log(true || true);    //  -> true


        //[2] 둘중에 하나가 참일때
        Debug.Log(true || false);    //  -> true
        Debug.Log(false || true);    //  -> true


        //[1] 둘다 거짓이면
        Debug.Log(false || false);    //  -> false
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
