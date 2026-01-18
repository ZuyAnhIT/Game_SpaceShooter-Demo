using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        // 1. Lấy vị trí con trỏ chuột trên màn hình (đơn vị pixel)
        Vector3 mousePos = Input.mousePosition;

        // 2. Xử lý độ sâu (Z)
        // Camera nằm ở Z = -10, Tàu ở Z = 0 -> Khoảng cách là 10.
        // Cần đặt z = 10 để hàm chuyển đổi tính toán đúng vị trí mặt phẳng của tàu.
        mousePos.z = 10f;

        // 3. Chuyển đổi từ Tọa độ màn hình (Screen) sang Tọa độ trong game (World)
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

        // 4. Gán vị trí mới cho tàu
        transform.position = worldPosition;
    }
}