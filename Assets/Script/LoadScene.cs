using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void StartGame()
        {
            // เปลี่ยนไปยัง Scene ที่ชื่อว่า "GameScene" (เปลี่ยนชื่อให้ตรงกับ Scene ของคุณ)
            SceneManager.LoadScene("Scene2");
        }
}
