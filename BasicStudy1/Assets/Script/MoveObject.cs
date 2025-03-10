using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public float speed = 5.0f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //키 입력에 따라 이동

        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * move * Time.deltaTime);
    }
}
