// using 사용할때
/*
using UnityEngine;

public class NewMemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello world!!"); 
    }

   
}
*/

// using 사용하지 않으면


public class NewMemo : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //네임스페이스.클래스.메서드()
        UnityEngine.Debug.Log("Hello world!!");
    }


}
