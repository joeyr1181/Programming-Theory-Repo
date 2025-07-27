using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] protected int pointValue = 1;
    [SerializeField] private float lifetime = 5f;

    protected string ShapeName;
    protected Color ShapeColor;

    private bool wasClicked = false;

    protected virtual void Start()
    {
        Invoke(nameof(CheckMiss), lifetime);
    }

    private void OnMouseDown()
    {
        if (GameManager.Instance.IsGameOver())
            return;

        if (wasClicked) // Prevent double counting if somehow clicked twice
            return;

        wasClicked = true;

        DisplayText();
        ScoreManager.Instance.AddPoints(pointValue);
        Destroy(gameObject);
    }

    private void CheckMiss()
    {
        if (!wasClicked)
        {
            GameManager.Instance.RegisterMiss(); // Notify miss
            Destroy(gameObject);
        }
    }

    public virtual void DisplayText()
    {
        Debug.Log($"You clicked on the {ShapeName}!");
    }
}
