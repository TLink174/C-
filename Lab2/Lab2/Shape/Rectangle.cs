namespace Lab2.Shape;

public class Rectangle : Shape
{
    private int width;
    private int height;

    public Rectangle(int x, int y, int width, int height) : base(x, y)
    {
        this.width = width;
        this.height = height;
    }

    public override void Show()
    {
        Console.WriteLine($"Hinh chu nhat {ToString()}, Chieu rong: {width}, Chieu dai: {height}");
    }
}