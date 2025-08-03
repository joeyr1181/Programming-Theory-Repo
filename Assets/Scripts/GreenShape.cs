using UnityEngine;

public class GreenShape : Shape
{

    // Awake is called when the script instance is being loaded
    // This is where the point value for the green shape is set
    private void Awake()
    {
        pointValue = 2;
    }

    // Start is called before the first frame update
    // This is where the shape's name and color are set
    protected override void Start()
    {
        base.Start();
        ShapeName = "Green Shape";
        ShapeColor = Color.green;
        GetComponent<Renderer>().material.color = ShapeColor;
    }

    // This method is called when the shape is clicked
    // It displays a message in the console
    public override void DisplayText()
    {
        Debug.Log($"You clicked on the {ShapeName}!");
    }
}
