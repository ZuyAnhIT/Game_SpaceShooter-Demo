using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1; // Sát thương của đạn

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (transform.position.y > 12f) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tìm xem vật va chạm có máu không (EnemyHealth)
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage); // Trừ máu địch
            Destroy(gameObject);      // Xóa viên đạn
        }
    }
}