using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int misses = 0;
    private const int maxMisses = 3;
    private bool gameOver = false;

    [Header("UI Panels")]
    public GameObject losePanel;
    public GameObject winPanel;
    public GameObject gameplayUI;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        // Initialize UI states
        if (losePanel != null) losePanel.SetActive(false);
        if (winPanel != null) winPanel.SetActive(false);
        if (gameplayUI != null) gameplayUI.SetActive(true);

        gameOver = false;
        misses = 0;
    }

    public bool IsGameOver()
    {
        return gameOver;
    }

    public void RegisterMiss()
    {
        if (gameOver) return;

        misses++;
        Debug.Log($"Misses: {misses}/{maxMisses}");

        if (misses >= maxMisses)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        gameOver = true;
        Debug.Log("GAME OVER");

        if (losePanel != null)
            losePanel.SetActive(true);

        if (gameplayUI != null)
            gameplayUI.SetActive(false);
    }

    public void WinGame()
    {
        if (gameOver) return;

        gameOver = true;
        Debug.Log("YOU WIN!");

        if (winPanel != null)
            winPanel.SetActive(true);

        if (gameplayUI != null)
            gameplayUI.SetActive(false);
    }

    // Optional: reset game state for restart
    public void ResetGame()
    {
        gameOver = false;
        misses = 0;

        if (losePanel != null)
            losePanel.SetActive(false);

        if (winPanel != null)
            winPanel.SetActive(false);

        if (gameplayUI != null)
            gameplayUI.SetActive(true);

        // Add any other reset logic here
    }
}
