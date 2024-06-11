
using UnityChan;
using UnityEngine;
public class PlayerControll2:MonoBehaviour
{

    public Rigidbody rb;
    public Transform trans;

    private float Horizontal;                               //←・→、Aキー・Dキー
    private float Vertical;                                 //↑・↓、Wキー・Sキー

    private float dashSpeed;
    private Vector3 vec;

    public Color stuckcol;

    void Start()
    {
        // Rigidbodyコンポーネントを取得する 
        rb = GetComponent<Rigidbody>();
        trans= GetComponent<Transform>();
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

        //Horizontal = Input.GetAxisRaw("Horizontal");
        //Vertical = Input.GetAxisRaw("Vertical");

        //rb.velocity = new Vector3(Horizontal * dashSpeed, 0, Vertical * dashSpeed);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, Input.GetAxis("Horizontal") * 3.0f, 0));
        rb.velocity = new Vector3(0, rb.velocity.y, 0) + trans.forward * Input.GetAxis("Vertical") * (-3.0f);

    }
}

