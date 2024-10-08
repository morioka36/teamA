using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainScene_GameOver_GameOver : MonoBehaviour
{

    public float speed = 3f;
    private float playerSpeed;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // ���L�[���������獶�����֐i��
        if (Input.GetKey(KeyCode.LeftArrow)) playerSpeed = -speed;
        // �E�L�[����������E�����֐i��
        else if (Input.GetKey(KeyCode.RightArrow)) playerSpeed = speed;
        // ���������Ȃ�������~�܂�
        else playerSpeed = 0;
        rb.velocity = new Vector2(playerSpeed, rb.velocity.y);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            

        if (collision.gameObject.tag == "a")
        {
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.tag == "b")
        {
            SceneManager.LoadScene("GameCler");
        }
    }
}
