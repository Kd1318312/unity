using UnityEngine;
using System.Collections;
using TMPro;

public class ChangeColor : MonoBehaviour
{

    //�I�𔻕ʗp�t���O
    public bool select_flg;

    private bool change_flg;

    public TextMeshProUGUI m_text;

    public GameObject Player;

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
        
        

        if(Input.GetKeyDown(KeyCode.G))
        {
            //�t���O��true�̏ꍇ(RayCast.cs�ŕύX�����)

            //�I������O�ꂽ�Ƃ��p
            select_color = Player.GetComponent<PlayerControll2>().stuckcol;
            //�I�u�W�F�N�g�̐F��ύX����
            mat.color = select_color;
            change_flg = true;
            
        }
    }
}