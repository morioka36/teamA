using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zyanp : MonoBehaviour
{
    public float jumpForce = 5f; // �W�����v�̋���
    private Rigidbody2D rb;    // Rigidbody�̎Q��

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D�R���|�[�l���g���擾
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // SPACE�L�[�������ꂽ��W�����v
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

}

