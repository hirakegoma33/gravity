using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int power;
    Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

        // playerRb.AddForce(Vector3.forward * power);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))  //右矢印が押されたら
        {
            playerRb.AddForce(Vector3.right); //右方向の力を加える
        }

        if (Input.GetKey(KeyCode.LeftArrow))  //左矢印が押されたら
        {
            playerRb.AddForce(Vector3.left); //左方向の力を加える
        }
        if (Input.GetKey(KeyCode.UpArrow))  //前矢印が押されたら
        {
            playerRb.AddForce(Vector3.forward); //前方向の力を加える
        }
        if (Input.GetKey(KeyCode.DownArrow))  //後ろ矢印が押されたら
        {
            playerRb.AddForce(Vector3.back); //後ろ方向の力を加える
        }
        if (Input.GetKeyDown(KeyCode.Space))  //スペースが押されたら
        {
            playerRb.AddForce(Vector3.up*power); //ジャンプろ方向の力を加える
        }


    }
}
