using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour
{

    //選択判別用フラグ
    public bool select_flg;

    private bool change_flg;

    //選択時の色変更用
    private Color default_color;
    public Color select_color;

    //色変更対象のオブジェクトのマテリアル格納用
    protected Material mat;

    void Start()
    {
        //フラグ、色、マテリアルの初期化
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
            //フラグがtrueの場合(RayCast.csで変更される)
            if (select_flg)
            {
                //選択から外れたとき用
                select_flg = false;
                //オブジェクトの色を変更する
                mat.color = select_color;
                change_flg = true;
            }
        }
        
    }
}