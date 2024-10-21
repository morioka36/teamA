using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen = false; // ドアが開いているかどうか
    private bool isOpen2 = false;

    public void Open()
     {
         if (!isOpen)
         {
            isOpen = true;
            // ドアを開く処理（例: Y軸で移動）
            transform.position += new Vector3(0, 5, 0); // 上に移動
         }
     }

    public void OpenDoor()
    {
        if (!isOpen2)
        {
            isOpen2 = true;
            // ドアを開ける処理（例: スライド）
            transform.position += new Vector3(1, 0, 0); // 右に1ユニット移動
        }
    }

   

    public void Close()
    {
        if (isOpen)
        {
            isOpen = false;
            // ドアを閉じる処理（例: Y軸で元の位置に戻す）
            transform.position -= new Vector3(0, 5, 0); // 元の位置に戻す

        }
        if (!isOpen2)
        {
            isOpen2 = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
