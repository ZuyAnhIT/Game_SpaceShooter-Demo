using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab; // Hiệu ứng nổ
    public int defaultHealthPoint;     // Máu mặc định
    private int healthPoint;           // Máu hiện tại

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

    // Hàm chết (cho phép các con ghi đè - override)
    protected virtual void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f); // Xóa vụ nổ sau 1 giây
        }
        Destroy(gameObject); // Xóa bản thân
    }
}