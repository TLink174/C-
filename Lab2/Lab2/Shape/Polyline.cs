namespace Lab2.Shape;

public class PolyLine : Shape
{
    public PolyLine(int x, int y) : base(x, y) { }

    public override void Show()
    {
        Console.WriteLine($"Da doan {ToString()}");
    }
}