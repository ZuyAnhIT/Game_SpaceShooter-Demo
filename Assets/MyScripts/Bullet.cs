using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Tốc độ bay của đạn
    public float speed = 10f;

    void Update()
    {
        // 1. Làm cho viên đạn bay lên trên theo trục Y (Vector3.up)
        // Time.deltaTime giúp đạn bay đều trên mọi máy tính
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // 2. Tự hủy: Nếu đạn bay quá cao (ra khỏi màn hình) thì xóa đi cho nhẹ máy
        if (transform.position.y > 12f)
        {
            Destroy(gameObject);
        }
    }
}