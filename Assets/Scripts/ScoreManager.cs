using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private int score = 0;

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private int winningScore = 10;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateScoreText();
    }

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

    private void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
