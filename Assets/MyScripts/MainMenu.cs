using UnityEngine;
using UnityEngine.SceneManagement; // Dòng này cực kỳ quan trọng, nó là chìa khóa để chuyển cảnh!

public class MainMenu : MonoBehaviour
{
    // Hàm này sẽ được gọi khi bấm nút PLAY GAME
    public void OnPlayButtonClicked()
    {
        // CHÚ Ý: Chữ "Battle" bên dưới phải khớp 100% với tên file Scene bắn nhau của bạn (Có thể của bạn tên là "SampleScene" hoặc "Main")
        SceneManager.LoadScene("Battle");
    }

    // Hàm này dành cho nút Return ở màn Game Over (ta viết sẵn luôn)
    public void OnReturnButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}