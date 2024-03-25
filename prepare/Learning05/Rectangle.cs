using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle (string color, double length, double width) : base (color)
    {
        length = _length;
        width = _width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}