using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public float speed = 5.0f; // �̵��ӵ�


    // Update is called once per frame
    void Update()
    {

        //Vector3 a = Vector3.right; //������ ����

        //Ű �Է¿� ���� �̵�

        //float move = Input.GetAxis("Horizontal");

        ////���� * ���ǵ� *Ÿ�ӵ�ŸŸ�� 
        //transform.Translate(Vector3.right * speed * move * Time.deltaTime);



        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.position += move * speed * Time.deltaTime;



    }
}
 