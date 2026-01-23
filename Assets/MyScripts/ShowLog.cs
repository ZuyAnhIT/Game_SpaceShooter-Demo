using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLog : MonoBehaviour
{
    // Start được gọi 1 lần duy nhất khi game bắt đầu
    void Start()
    {
        Debug.Log("Hello World - Game Start !");
    }

    // Update được gọi liên tục mỗi khung hình (khoảng 60 lần/giây)
    void Update()
    {
        Debug.Log("Frame count: " + Time.frameCount);
    }
}