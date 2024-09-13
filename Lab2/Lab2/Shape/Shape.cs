namespace Lab2.Shape;

public abstract class Shape
{
    protected int x;
    protected int y;

    public Shape(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(int newX, int newY)
    {
        x = newX;
        y = newY;
    }

    public abstract void Show();

    public override string ToString()
    {
        return $"Vi tri: ({x}, {y})";
    }
}
