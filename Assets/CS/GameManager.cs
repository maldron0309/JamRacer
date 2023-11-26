using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private GameObject gameOverCanvas;

    private void Awake()
    {
        if (instance == null) instance = this;

        Time.timeScale = 1f;
    }

    private void Update()
    {
        // 게임 오버 상태에서도 연료가 감소하도록 UpdateUI 호출
        FuelController.instance.UpdateUI();
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}