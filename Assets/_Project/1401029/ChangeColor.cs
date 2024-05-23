using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{

    //�I�𔻕ʗp�t���O
    public bool select_flg;

    private bool change_flg;

    //�I�����̐F�ύX�p
    private Color default_color;
    public Color select_color;

    //�F�ύX�Ώۂ̃I�u�W�F�N�g�̃}�e���A���i�[�p
    protected Material mat;

    void Start()
    {
        //�t���O�A�F�A�}�e���A���̏�����
        select_flg = false;
        change_flg = false;
        default_color = Color.gray;
        select_color = Color.white;
        mat = this.gameObject.GetComponent<Renderer>().material;
    }

    void Update()
    {
        if(!change_flg)
        {
            mat.color = default_color;
        }
        
        if(Input.GetMouseButtonDown(0)) 
        {
            //�t���O��true�̏ꍇ(RayCast.cs�ŕύX�����)
            if (select_flg)
            {
                //�I������O�ꂽ�Ƃ��p
                select_flg = false;
                //�I�u�W�F�N�g�̐F��ύX����
                mat.color = select_color;
                change_flg = true;
            }
        }
        
    }
}