using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Singleton instance for easy access
    // This allows other scripts to access the GameManager without needing a reference
    // It manages the game state, including tracking misses and handling game over conditions
    // It also manages the UI panels for win and lose states
    public static GameManager Instance;

    private int misses = 0;
    private const int maxMisses = 3;
    private bool gameOver = false;

    // UI Panels for win and lose states
    // These panels are activated when the game is won or lost
    [Header("UI Panels")]
    public GameObject losePanel;
    public GameObject winPanel;
    public GameObject gameplayUI;

    // Awake is called when the script instance is being loaded
    // This is where the singleton instance is set up
    // It also initializes the UI states
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

    // Public methods to access game state
    // These methods allow other scripts to check if the game is over or to register misses
    // They also provide methods to handle winning and losing the game
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

    // This method is called when the game is over
    // It sets the game over state, activates the lose panel, and deactivates the gameplay UI
    // It also logs a message to the console
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

    // This method resets the game state
    // It sets the game over state to false, resets misses, and reactivates the
    // gameplay UI while deactivating the win and lose panels
    // It can be called to restart the game without reloading the scene
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
    }
}
