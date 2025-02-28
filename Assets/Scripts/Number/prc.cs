using UnityEngine;

public class prc : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        float f = 3.14F;
        double d = 3.14D;
        decimal m = 3.14M;


        Debug.Log("float: " + f);
        Debug.Log("double: " + d);
        Debug.Log("decimal: " + m);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*
 [Q]
실수형 값 float 3.14, double 3.14, decima 3.14 값 출력하기

[output]
float: 3.14
double: 3.14
decimal: 3.14
 
 */