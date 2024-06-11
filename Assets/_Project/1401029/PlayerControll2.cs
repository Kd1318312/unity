
using UnityChan;
using UnityEngine;
public class PlayerControll2:MonoBehaviour
{

    public Rigidbody rb;
    public Transform trans;

    private float Horizontal;                               //���E���AA�L�[�ED�L�[
    private float Vertical;                                 //���E���AW�L�[�ES�L�[

    private float dashSpeed;
    private Vector3 vec;

    public Color stuckcol;

    void Start()
    {
        // Rigidbody�R���|�[�l���g���擾���� 
        rb = GetComponent<Rigidbody>();
        trans= GetComponent<Transform>();
    }


    void Update()
    {
        //�J������ɂ���}�E�X�̈ʒu�ɔ�΂����C���쐬����
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //���C���R���C�_�[�ɓ��������ꍇ�ɏ����i�[����
        RaycastHit hit = new RaycastHit();

        //�쐬�������C�𓊂���B�R���C�_�[�ɓ��������ꍇ��true���Ԃ�
        if (Physics.Raycast(ray, out hit))
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.gameObject.GetComponent<MyColor>())
                {
                    stuckcol = hit.collider.gameObject.GetComponent<MyColor>().myColor;

                    Debug.Log("Get Color!!!");
                }
            }

        }
    }

    void FixedUpdate()
    {
       


        if (Input.GetKey(KeyCode.LeftShift))     
        {
            dashSpeed = 3;
        }
        else
        {
            dashSpeed = 1.5f;
        }

        //Horizontal = Input.GetAxisRaw("Horizontal");
        //Vertical = Input.GetAxisRaw("Vertical");

        //rb.velocity = new Vector3(Horizontal * dashSpeed, 0, Vertical * dashSpeed);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, Input.GetAxis("Horizontal") * 3.0f, 0));
        rb.velocity = new Vector3(0, rb.velocity.y, 0) + trans.forward * Input.GetAxis("Vertical") * (-3.0f);

    }
}

