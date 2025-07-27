using UnityEngine;

public class RedShape : Shape
{
    private void Awake()
    {
        pointValue = 1;
    }

    private void Start()
    {
        base.Start();
        ShapeName = "Red Shape";
        ShapeColor = Color.red;
        GetComponent<Renderer>().material.color = ShapeColor;
        pointValue = 1; // Red shapes are worth 1 point
    }

    public override void DisplayText()
    {
        Debug.Log($"You clicked on the {ShapeName}!");
    }
}
