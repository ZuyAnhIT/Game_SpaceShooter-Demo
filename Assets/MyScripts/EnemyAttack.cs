using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 1;      // Sát thương gây ra cho Player
    private EnemyHealth myHealth; // Máu của chính mình

    void Start()
    {
        myHealth = GetComponent<EnemyHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra nếu va vào Player
        var playerHealth = collision.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage); // Trừ máu Player
            myHealth.TakeDamage(1000);       // Tự kết liễu bản thân (trừ 1000 máu)
        }
    }
}