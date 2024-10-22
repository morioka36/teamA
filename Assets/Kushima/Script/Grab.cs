using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    // 持ち上げる位置を指定するTransform
    [SerializeField] private Transform grabPoint;
    // Raycastの開始位置を指定するTransform
    [SerializeField] private Transform rayPoint;
    private float rayDistance = 0.2f;
    // 持ち上げたオブジェクトを保持するための変数
    private GameObject grabObj;
    // Raycastの結果を保持する変数
    RaycastHit2D hit;

    // 毎フレーム呼ばれるメソッド
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (grabObj == null)
            {
                // Raycastを使ってプレイヤーの前方にあるオブジェクトを検知
                hit = Physics2D.Raycast(rayPoint.position, transform.right, rayDistance);

                if (hit.collider != null && hit.collider.tag == "Box")
                {
                    // 検知されたオブジェクトを grabObj に保持
                    grabObj = hit.collider.gameObject;

                    grabObj.GetComponent<Rigidbody2D>().isKinematic = true;
                    grabObj.transform.position = grabPoint.position;

                    // オブジェクトをプレイヤーの子オブジェクトに設定
                    grabObj.transform.SetParent(transform);
                }
            }
            
            else
            {
                // オブジェクトの物理演算を有効にし、親子関係を解除
                grabObj.GetComponent<Rigidbody2D>().isKinematic = false;
                grabObj.transform.SetParent(null);

                // オブジェクトを手放す
                grabObj = null;
            }
        }
    }
}