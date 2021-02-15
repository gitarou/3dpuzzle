using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kari_cam_con : MonoBehaviour
{
    public GameObject targetObj;
    public float speed;
    Vector3 targetPos;
    
    void Start () {
        //targetObj = GameObject.Find("TargetGameObject");
        targetPos = targetObj.transform.position;
    }
    
    void Update() {
        // targetの移動量分、自分（カメラ）も移動する
        transform.position += targetObj.transform.position - targetPos;
        targetPos = targetObj.transform.position;
    
        
        if (Input.GetMouseButton(1)) {
        // マウスの移動量
        float mouseInputX = Input.GetAxis("Mouse X");
        float mouseInputY = Input.GetAxis("Mouse Y");
        // targetの位置のY軸を中心に、回転（公転）する
        transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200f * speed);
        // カメラの垂直移動（※角度制限なし、必要が無ければコメントアウト）
        //transform.RotateAround(targetPos, transform.right, mouseInputY * Time.deltaTime * 200f * speed);
        //参考ページhttps://tech.pjin.jp/blog/2016/11/04/unity_skill_5/
    }
    
    }
}