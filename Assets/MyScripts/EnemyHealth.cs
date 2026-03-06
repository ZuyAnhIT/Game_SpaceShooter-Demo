using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount; // Biến lưu số lượng địch còn sống

    // Khi địch sinh ra, tăng biến đếm lên 1
    private void Awake()
    {
        LivingEnemyCount++;
    }

    // Khi địch chết, giảm biến đếm đi 1
    protected override void Die()
    {
        LivingEnemyCount--;
        base.Die();
    }
}