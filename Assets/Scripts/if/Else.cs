using UnityEngine;


// 만약 score가 60 점 이상이면 "합격" 이라고 출력,
// 아니면 "불합격" 이라고 출력
// score 61점


public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 59; //[1]


        // 만약 score가 60 점 이상이면
        if(score >= 60)
        {

            Debug.Log("합격"); //[2]

        }
        else // 조건식이 아니면
        {
            Debug.Log("불합격"); //[3]

        }

        Debug.Log("종료"); //[4]


    }

    //score = 59; : [1] -> [3] -> [4]
    //score = 61; : [1] -> [2] -> [4]

    // Update is called once per frame
    void Update()
    {
        
    }
}
