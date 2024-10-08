using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zyanp : MonoBehaviour
{
    public float jumpForce = 5f; // ジャンプの強さ
    private Rigidbody2D rb;    // Rigidbodyの参照

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2Dコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // SPACEキーが押されたらジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

}

