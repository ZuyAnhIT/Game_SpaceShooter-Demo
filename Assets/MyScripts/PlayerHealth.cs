using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die(); // Gọi hàm chết của cha (nổ + xóa)
        Debug.Log("Player died"); // Ghi thêm log
    }
}