
using UnityChan;
using UnityEngine;
public class PlayerControll2:MonoBehaviour
{

    public Rigidbody rb;
    public Animator anime;

    private float Horizontal;                               //���E���AA�L�[�ED�L�[
    private float Vertical;                                 //���E���AW�L�[�ES�L�[

    private float dashSpeed;
    private Vector3 vec;
    private Vector3 input;

    public Color stuckcol;

    void Start()
    {
        // Rigidbody�R���|�[�l���g���擾���� 
        rb = GetComponent<Rigidbody>();
        stuckcol=Color.white;
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

        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        input = new Vector3(Horizontal, 0, Vertical);
        if(input.magnitude>0f)
        {
            anime.SetFloat("Speed", input.magnitude);
        }
        else
        {
            anime.SetFloat("Speed", 0f);
        }


        //rb.velocity = new Vector3(Horizontal * dashSpeed, 0, Vertical * dashSpeed);
        // �J�����̕�������AX-Z���ʂ̒P�ʃx�N�g�����擾
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // �����L�[�̓��͒l�ƃJ�����̌�������A�ړ�����������
        Vector3 moveForward = cameraForward * Vertical + Camera.main.transform.right * Horizontal;

        // �ړ������ɃX�s�[�h���|����B�W�����v�◎��������ꍇ�́A�ʓrY�������̑��x�x�N�g���𑫂��B
        rb.velocity = moveForward * dashSpeed + new Vector3(0, rb.velocity.y, 0);

        // �L�����N�^�[�̌�����i�s������
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }

    }
}

