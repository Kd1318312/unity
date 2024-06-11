using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour
{
    public Color stuckcol;
    void Start()
    {

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
            //���C�����������I�u�W�F�N�g��ChangeColor�R���|�[�l���g���A�^�b�`���Ă����ꍇ�A�t���O��true�ɂ���
            if (hit.collider.gameObject.GetComponent<ChangeColor>())
            {
                hit.collider.gameObject.GetComponent<ChangeColor>().select_flg = true;
                if(stuckcol!=Color.black)
                {
                    hit.collider.gameObject.GetComponent<ChangeColor>().select_color = stuckcol;


                }
            }
            
            if(Input.GetMouseButtonDown(0)) 
            {
                if (hit.collider.gameObject.GetComponent<MyColor>())
                {
                    stuckcol = hit.collider.gameObject.GetComponent<MyColor>().myColor;

                    Debug.Log("Get Color!!!");
                }
            }
            
        }
    }
}