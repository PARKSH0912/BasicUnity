using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start : 게임이 시작될때 호출됩니다");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update : 매 프레임마다 호출됩니다");
    }


    void FixedUpdate()
    {
        Debug.Log("FixedUpdate : 물리 연산에 사용됩니다");
    }


    //컨트롤 쉬프트 M

}
