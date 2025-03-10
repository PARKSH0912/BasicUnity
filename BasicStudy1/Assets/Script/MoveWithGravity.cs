using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{
    public Rigidbody rb;

    public float jumpForce = 5.0f;  //������


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Rgidbody : ���� ȿ���� �߰��� �߷��� �����մϴ�
            //Addforce : ������ ���� ������Ʈ�� ���� �ݴϴ�.
            //ForceMode.Impulse : ���������� ���� ���ϴ� �ɼ� 

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }
}
