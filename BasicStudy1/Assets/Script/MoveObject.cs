using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public float speed = 5.0f; // 이동속도


    // Update is called once per frame
    void Update()
    {

        //Vector3 a = Vector3.right; //오른쪽 방향

        //키 입력에 따라 이동

        //float move = Input.GetAxis("Horizontal");

        ////방향 * 스피드 *타임델타타임 
        //transform.Translate(Vector3.right * speed * move * Time.deltaTime);



        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.position += move * speed * Time.deltaTime;



    }
}
 