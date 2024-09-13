namespace Lab1._1;

public class QuadraticEquation
{
    private double a, b, c;

    public QuadraticEquation(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void Solve()
    {
        double discriminant = b * b - 4 * a * c;
        
        if (discriminant > 0)
        {
            // Hai nghiem phan biet
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine($"Hai nghiem phan biet la: ");
            Console.WriteLine($"Nghiem 1: {root1}");
            Console.WriteLine($"Nghiem 2: {root2}");
        }
        else if (discriminant == 0)
        {
            // Nghiem kep
            double root = -b / (2 * a);

            Console.WriteLine($"Nghiem kep la:");
            Console.WriteLine($"Nghiem: {root}");
        }
        else
        {
            // Nghiem phuc
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

            Console.WriteLine($"Nghiem phuc la:");
            Console.WriteLine($"Nghiem 1: {realPart} + {imaginaryPart}i");
            Console.WriteLine($"Nghiem 2: {realPart} - {imaginaryPart}i");
        }
    }
}