namespace Lab2.Shape;

public class Circle : Shape
{
    private int radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }

    public override void Show()
    {
        Console.WriteLine($"Hinh tron {ToString()}, Ban kinh: {radius}");
    }
}