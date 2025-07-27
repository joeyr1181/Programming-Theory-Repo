using UnityEngine;

public class BlueShape : Shape
{
    private void Awake()
    {
        pointValue = 3;
    }

    private void Start()
    {
        base.Start();
        ShapeName = "Blue Shape";
        ShapeColor = Color.blue;
        GetComponent<Renderer>().material.color = ShapeColor;
        pointValue = 3; // Blue shapes are worth 3 points
    }

    public override void DisplayText()
    {
        Debug.Log($"You clicked on the {ShapeName}!");
    }
}
