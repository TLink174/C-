namespace Lab2.Shape;

public class Line : Shape
{
    private int endX;
    private int endY;

    public Line(int x, int y, int endX, int endY) : base(x, y)
    {
        this.endX = endX;
        this.endY = endY;
    }

    public override void Show()
    {
        Console.WriteLine($"Duong thang {ToString()}, Diem ket thuc: ({endX}, {endY})");
    }
}