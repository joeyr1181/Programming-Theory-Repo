using UnityEngine;

public class RedShape : Shape
{
    // Awake is called when the script instance is being loaded
    // This is where the point value for the red shape is set
    private void Awake()
    {
        pointValue = 1;
    }

    // Start is called before the first frame update
    // This is where the shape's name and color are set
    // The red shape is initialized with a point value of 1
    protected override void Start()
    {
        base.Start();
        ShapeName = "Red Shape";
        ShapeColor = Color.red;
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    // This method is called when the shape is clicked
    // It displays a message in the console
    public override void DisplayText()
    {
        Debug.Log($"You clicked on the {ShapeName}!");
    }
}
