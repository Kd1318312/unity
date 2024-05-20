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
        // アクティブなレンダーテクスチャをキャッシュしておく
        var currentRT = renTex;

        // アクティブなレンダーテクスチャを一時的にTargetに変更する
        renTex = _target;

        // Texture2D.ReadPixels()によりアクティブなレンダーテクスチャのピクセル情報をテクスチャに格納する
        var texture = new Texture2D(_target.width, _target.height);
        texture.ReadPixels(new Rect(0, 0, _target.width, _target.height), 0, 0);
        texture.Apply();

        // ピクセル情報を取得する
        col = texture.GetPixels();


        // アクティブなレンダーテクスチャを元に戻す
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

        // アクティブなレンダーテクスチャをキャッシュしておく
        var currentRT = renTex;

        // アクティブなレンダーテクスチャを一時的にTargetに変更する
        renTex = _target;

        // Texture2D.ReadPixels()によりアクティブなレンダーテクスチャのピクセル情報をテクスチャに格納する
        var texture = new Texture2D(_target.width, _target.height);
        texture.ReadPixels(new Rect(0, 0, _target.width, _target.height), 0, 0);
        texture.Apply();

        // ピクセル情報を取得する
        var color = texture.GetPixels();
        Debug.Log(color.ToString());

        // アクティブなレンダーテクスチャを元に戻す
        renTex = currentRT;

        
    }
}