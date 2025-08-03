using UnityEngine;

public class Shape : MonoBehaviour
{

    // This class serves as a base class for different shapes
    // It contains common properties and methods for all shapes
    // Each shape has a point value, a name, and a color
    // The point value is used to determine how many points the player earns when clicking the shape
    [SerializeField] protected int pointValue = 1;
    [SerializeField] private float lifetime = 5f; // Serialized fields allow customization in the Unity Inspector

    protected string ShapeName;
    protected Color ShapeColor; // protected allows derived classes to access these properties

    private bool wasClicked = false;


    // Invoke is used to call the CheckMiss method after the shape's lifetime expires
    // This method is called when the script instance is being loaded
    protected virtual void Start()
    {
        Invoke(nameof(CheckMiss), lifetime);
    }

    // This method is called when the shape is clicked
    // It checks if the game is over, prevents double counting, and updates the score
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

    // This method is called when the shape's lifetime expires
    // It checks if the shape was clicked; if not, it registers a miss
    // and destroys the shape
    private void CheckMiss()
    {
        if (!wasClicked)
        {
            GameManager.Instance.RegisterMiss(); // Notify miss
            Destroy(gameObject);
        }
    }

    // This method is called when the shape is clicked
    // It displays a message in the console
    // Derived classes can override this method to provide specific behavior
    public virtual void DisplayText()
    {
        Debug.Log($"You clicked on the {ShapeName}!");
    }
}
