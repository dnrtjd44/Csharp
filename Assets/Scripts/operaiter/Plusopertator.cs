using UnityEngine;


  // +,-,*,/,% : 연산자
  // % : 나머지 연산
public class Plusopertator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 10;
        int j = 20;
        int k = i + j;
        Debug.Log(k);


        float f = 3.14f;
        float g = 3.14f;
        float e = f - g;
        Debug.Log(e);

        long a = 100;
        long b = 200;
        long c = a * b;
        Debug.Log(c);


        double l = 1.5;
        double m = 0.5;
        double n = l / m;
        Debug.Log(m);

        int x = 5;
        int y = 3;
        int z = x % y; // 몫은 1, (나머지 2)
        Debug.Log(z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
