using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public bool isActive = false;
    public float speed;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive || player == null) return;

        Vector3 playerPosition = player.transform.position;
        Vector3 direction = playerPosition - transform.position;

        spriteRenderer.flipX = direction.x > 0;//絵の向きの変更
        transform.Translate(direction.normalized * speed * Time.deltaTime);//移動する方向の変更


    }
    void OnTriggerStay2D(Collider2D other)//playerが一定距離に入ったかの確認
    {
        if (other.CompareTag("Player"))
        {
            isActive = true;
            player = other.gameObject; // プレイヤーのリファレンスを保存
        }
    }
    void OnTriggerExit2D(Collider2D other)//playerが一定距離から出たかの確認
    {
        if (other.CompareTag("Player"))
        {
            isActive = false;
            player = null; // プレイヤーのリファレンスをクリア
        }
    }
}
