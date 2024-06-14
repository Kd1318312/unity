
using UnityChan;
using UnityEngine;
public class PlayerControll2:MonoBehaviour
{

    public Rigidbody rb;
    public Animator anime;

    private float Horizontal;                               //←・→、Aキー・Dキー
    private float Vertical;                                 //↑・↓、Wキー・Sキー

    private float dashSpeed;
    private Vector3 vec;
    private Vector3 input;

    public Color stuckcol;

    void Start()
    {
        // Rigidbodyコンポーネントを取得する 
        rb = GetComponent<Rigidbody>();
        stuckcol=Color.white;
    }
    

    void Update()
    {
        //カメラ上にあるマウスの位置に飛ばすレイを作成する
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //レイがコライダーに当たった場合に情報を格納する
        RaycastHit hit = new RaycastHit();

        //作成したレイを投げる。コライダーに当たった場合はtrueが返る
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
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * Vertical + Camera.main.transform.right * Horizontal;

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rb.velocity = moveForward * dashSpeed + new Vector3(0, rb.velocity.y, 0);

        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }

    }
}

