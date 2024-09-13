namespace Lab2;

public class Dice
{
    // Thuộc tính
    private int sides;
    public int Sides
    {
        get { return sides; }
        set
        {
            if (value > 0)
            {
                sides= value;
            }
            else
            {
                Console.WriteLine("So mat phai la so duong.");
                Environment.Exit(0);
            }
        }
    }

    // Đối tượng Random để sinh số ngẫu nhiên
    private Random random;

    // Constructor
    public Dice(int sides)
    {   
        Sides = sides;
        random = new Random();
    }

    // Phương thức để tung xúc xắc và sinh số ngẫu nhiên
    public int RollResult()
    {
        return random.Next(1, Sides + 1);
    }
}