using UnityEngine;
using UnityEngine.SceneManagement; // Thêm thư viện này để chuyển scene

public class BattleFlow : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameWinUI; // Thêm ô kéo Canvas Win
    public PlayerHealth playerHealth;
    public GameObject bgMusic;

    private void Start()
    {
        gameOverUI.SetActive(false); // Giấu chữ Game Over
        gameWinUI.SetActive(false);  // Giấu chữ Win

        // Đăng ký nhận thông báo: Khi nào Player chết (onDead) thì chạy hàm OnGameOver
        playerHealth.onDead += OnGameOver;
    }

    private void Update()
    {
        // Liên tục kiểm tra, nếu địch bị tiêu diệt hết (<= 0) thì gọi hàm Thắng
        if (EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();
        }
    }

    private void OnGameWin()
    {
        gameWinUI.SetActive(true); // Bật chữ Win
        bgMusic.SetActive(false); // Tắt nhạc
        playerHealth.gameObject.SetActive(false); // Cho tàu Player biến mất đi cho ngầu
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true); // Bật chữ Game Over lên
        bgMusic.SetActive(false);   // Tắt nhạc nền đi
    }

    // Hàm này để gắn vào các nút bấm "Return to Main Menu"
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}