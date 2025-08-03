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
    }

    public override void DisplayText()
    {
        Debug.Log($"You clicked on the {ShapeName}!");
    }
}
