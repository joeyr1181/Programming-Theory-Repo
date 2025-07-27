using UnityEngine;

public class GreenShape : Shape
{
    private void Awake()
    {
        pointValue = 2;
    }

    private void Start()
    {
        base.Start();
        ShapeName = "Green Shape";
        ShapeColor = Color.green;
        GetComponent<Renderer>().material.color = ShapeColor;
        pointValue = 2; // Green shapes are worth 2 points
    }

    public override void DisplayText()
    {
        Debug.Log($"You clicked on the {ShapeName}!");
    }
}
