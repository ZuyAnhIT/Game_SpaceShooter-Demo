using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; // Hiệu ứng nổ
    public int defaultHealthPoint;     // Máu mặc định
    private int healthPoint;           // Máu hiện tại
    public System.Action onDead;       // Sự kiện thông báo khi chết

    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    // Hàm nhận sát thương
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    // Hàm chết (cho phép các class con ghi đè - override)
    protected virtual void Die()
    {
        // 1. Sinh ra hiệu ứng nổ (nếu có)
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); // Xóa vụ nổ sau 1 giây
        }

        // 2. Xóa bản thân (Tàu)
        Destroy(gameObject);

        // 3. Kích hoạt sự kiện onDead báo cho hệ thống biết ta đã chết!
        onDead?.Invoke();
    }
}