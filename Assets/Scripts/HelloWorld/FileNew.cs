//[1] 네임스페이스 선언부
using UnityEngine; //현재 (FileNew)클래스 파일에서 UnityEngine 네임스페이를 사용

//[2] 클래스 선언부 : 클래스의 이름은 FileNew
public class FileNew : MonoBehaviour

//FileNew 코드블럭
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //[3] (Start) 메서드 선언 : 프로그램을 시작할때 1번만 실행
    void Start()
    {
        //[5] 명령문: 콘솔창 출력문ㅣ
        Debug.Log("C#은 대문자와 소문자를 구분합니다");
    }

   
}
