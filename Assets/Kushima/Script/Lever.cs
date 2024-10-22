using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{

    public GameObject door; // 開くドアの参照
    private bool isPulled = false; // レバーが引かれたかどうか

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // プレイヤーがレバーに当たったとき
        if (other.CompareTag("Player") && !isPulled)
        {
            PullLever();
        }
    }

    private void PullLever()
    {
        isPulled = true;

        // レバーを前に倒す処理（例: 回転）
        transform.rotation = Quaternion.Euler(0, 0, -45); // 45度傾ける

        // ドアを開ける処理
        if (door != null)
        {
            door.GetComponent<Door>().OpenDoor();
        }
    }


}
