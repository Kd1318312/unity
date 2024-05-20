using Es.InkPainter;
using JetBrains.Annotations;
using System.Collections;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class GetRenderTexturePixels : MonoBehaviour
{
    
    Texture renTex;
    [SerializeField] 
    private Texture _target;



    void Start()
    {
        renTex = this.GetComponent<InkCanvas>().GetPaintMainTexture("Sample");
    }

    /*
    public void OnPostRender()
    {
        // �A�N�e�B�u�ȃ����_�[�e�N�X�`�����L���b�V�����Ă���
        var currentRT = renTex;

        // �A�N�e�B�u�ȃ����_�[�e�N�X�`�����ꎞ�I��Target�ɕύX����
        renTex = _target;

        // Texture2D.ReadPixels()�ɂ��A�N�e�B�u�ȃ����_�[�e�N�X�`���̃s�N�Z�������e�N�X�`���Ɋi�[����
        var texture = new Texture2D(_target.width, _target.height);
        texture.ReadPixels(new Rect(0, 0, _target.width, _target.height), 0, 0);
        texture.Apply();

        // �s�N�Z�������擾����
        col = texture.GetPixels();


        // �A�N�e�B�u�ȃ����_�[�e�N�X�`�������ɖ߂�
        renTex = currentRT;

    }
    */


    /*
    public Color[] GetPixels()
    {
        OnPostRender();
        return col;
    }
    */
    public IEnumerator GetPixels()
    {
        
        
        yield return new WaitForEndOfFrame();

        // �A�N�e�B�u�ȃ����_�[�e�N�X�`�����L���b�V�����Ă���
        var currentRT = renTex;

        // �A�N�e�B�u�ȃ����_�[�e�N�X�`�����ꎞ�I��Target�ɕύX����
        renTex = _target;

        // Texture2D.ReadPixels()�ɂ��A�N�e�B�u�ȃ����_�[�e�N�X�`���̃s�N�Z�������e�N�X�`���Ɋi�[����
        var texture = new Texture2D(_target.width, _target.height);
        texture.ReadPixels(new Rect(0, 0, _target.width, _target.height), 0, 0);
        texture.Apply();

        // �s�N�Z�������擾����
        var color = texture.GetPixels();
        Debug.Log(color.ToString());

        // �A�N�e�B�u�ȃ����_�[�e�N�X�`�������ɖ߂�
        renTex = currentRT;

        
    }
}