using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    // This class manages the player's score
    // It keeps track of the score, updates the UI, and checks for winning conditions
    // Singleton instance for easy access
    // This allows other scripts to access the ScoreManager without needing a reference
    public static ScoreManager Instance;

    private int score = 0;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int winningScore = 10;


    // Awake is called when the script instance is being loaded
    // This is where the singleton instance is set up
    // It also initializes the score text
    // The score starts at 0 and the score text is updated accordingly
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    // This is where the score text is initialized
    private void Start()
    {
        UpdateScoreText();
    }


    // This method adds points to the score
    // It checks if the game is over before adding points
    public void AddPoints(int points)
    {
        if (GameManager.Instance.IsGameOver()) return;

        score += points;
        UpdateScoreText();

        if (score >= winningScore)
        {
            GameManager.Instance.WinGame(); // Let GameManager handle win
        }
    }

    // This method resets the score to 0
    // It is useful for restarting the game or level
    private void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
