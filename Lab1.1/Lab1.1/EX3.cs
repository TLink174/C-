namespace Lab1._1;

public class PrimeNumberChecker
{
    private int n;

    public PrimeNumberChecker(int n)
    {
        this.n = n;
    }

    public void Check()
    {
        if (IsPrime(n))
        {
            Console.WriteLine($"{n} la so nguyen to.");
        }
        else
        {
            Console.WriteLine($"{n} khong phai la so nguyen to.");
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}