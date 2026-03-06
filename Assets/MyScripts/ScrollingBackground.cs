using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer bgRenderer;
    public float speed;

    void Update()
    {
        // Lệnh này liên tục dịch chuyển tọa độ ảnh theo thời gian để tạo cảm giác trôi cuộn
        bgRenderer.material.mainTextureOffset = new Vector2(0, Time.time * speed);
    }
}