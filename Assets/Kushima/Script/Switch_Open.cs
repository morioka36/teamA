using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Open : MonoBehaviour
{
    public Door door; // 参照するドア
    private bool isPressed = false; // スイッチが押されているかどうか

    //sStart is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Box")) // ボックスが押されたら
        {
            isPressed = true; // スイッチが押されたら
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         if (collision.gameObject.tag == ("Box")) // ボックスが離れたら
            {
                isPressed = false; // スイッチから離れた
            }
        
    }

    //private void OnCollisonEnter2D(Collider2D collision)
    //{

    //}


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            door.Open(); // スイッチが押されている間、ドアを開く
        }
        else
        {
            door.Close(); // スイッチが離されたら、ドアを閉じる
        }
    }
    
}
