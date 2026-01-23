using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // 1. Biến để chứa cái Prefab viên đạn (Khuôn đúc)
    public GameObject bulletPrefab;

    // 2. Thời gian chờ giữa 2 phát bắn (0.2 giây bắn 1 phát)
    public float fireDelay = 0.2f;

    // Biến đếm ngược thời gian
    private float timer = 0;

    void Update()
    {
        // Giảm thời gian đếm ngược liên tục
        timer -= Time.deltaTime;

        // KHI 2 ĐIỀU KIỆN THỎA MÃN:
        // 1. Người chơi Giữ chuột trái (GetMouseButton - số 0)
        // 2. Thời gian chờ đã hết (timer <= 0)
        if (Input.GetMouseButton(0) && timer <= 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Tạo ra viên đạn từ Prefab tại vị trí của tàu
        // Quaternion.identity nghĩa là giữ nguyên góc xoay mặc định (không xoay)
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        // Reset lại đồng hồ đếm ngược
        timer = fireDelay;
    }
}