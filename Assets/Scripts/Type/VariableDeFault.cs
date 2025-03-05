using UnityEngine;

public class VariableDeFault : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수 선언하고 deFault(기본값)값으로 초기화
        int i = default;
        double d = default;
        char c = default;
        string s = default;

        //Debug.Log($"[{i}],[{d}],[{c}],[{s}]");
        Debug.Log($"[{i}],[{d}],[{c == System.Char.MinValue}],[{s == null}]");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
