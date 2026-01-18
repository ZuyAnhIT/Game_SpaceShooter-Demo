using UnityEngine;

public class Blinking : MonoBehaviour
{
    // Biến chứa component vẽ ảnh
    private SpriteRenderer mySprite;

    void Start()
    {
        // Tự động tìm component SpriteRenderer gắn trên cùng object này
        mySprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Nếu tìm thấy component thì mới làm việc
        if (mySprite != null)
        {
            // Đảo ngược trạng thái: Đang hiện -> Tắt, Đang tắt -> Hiện
            mySprite.enabled = !mySprite.enabled;
        }
    }
}