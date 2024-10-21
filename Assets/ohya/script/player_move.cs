using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float junptime = 2;
    private bool isGrounded = false;
    Rigidbody2D rbody2D;


    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //移動処理
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        // プレイヤーの位置を更新
        transform.Translate(new Vector2(moveX,0));


        //ジャンプ処理
        if (Input.GetKeyDown("w") && isGrounded) 
        {
            Jump();
            isGrounded = false;
        }

        void Jump()
        {
            // 上方向に力を加える事でジャンプする
            rbody2D.AddForce(Vector2.up * 300);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }

}
