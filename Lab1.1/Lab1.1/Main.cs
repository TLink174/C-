using Lab1._1;

namespace Lab1._1
{
    using System;
}

public class  Run
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("EX1: Caculator");
            Console.WriteLine("EX2: Quadratic Equatio");
            Console.WriteLine("EX3: Prime Number Checker");
            Console.WriteLine("EX4: Lucky Number");
            // Nhap a
            Console.Write("Nhap EX: ");
            char ex = Convert.ToChar(Console.ReadLine());
            
            // Tinh toan theo tung toan tu
            switch (ex)
            {
                case '1':
                    // Nhap x
                    Console.Write("Nhap so nguyen (x): ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    // Nhap y
                    Console.Write("Nhap so nguyen (y): ");
                    int y = Convert.ToInt32(Console.ReadLine());
                    // Nhap toan tu
                    Console.Write("Nhap toan tu (+, -, *, /): ");
                    char op = Convert.ToChar(Console.ReadLine());
    
                    Caculator equation = new Caculator(x, y, op);
                    equation.Solve();
                    break;
                case '2':
                    Console.Write("Nhap a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap c: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    QuadraticEquation value = new QuadraticEquation(a, b, c);
                    value.Solve();
                    break;
                case '3':
                    Console.Write("Nhap so nguyen (n >= 2): ");
                    int n;
                    do
                    {
                        while (!int.TryParse(Console.ReadLine(), out n))
                        {
                            Console.Write("So khong hop le, vui long nhap lai: ");
                        }

                        if (n < 2)
                        {
                            Console.WriteLine("Vui long nhap so lon hon hoac bang 2.");
                        }

                    } while (n < 2);
                    PrimeNumberChecker checker = new PrimeNumberChecker(n);
                    checker.Check();
                    break;
                case '4':
                    LuckyNumber newgame = new LuckyNumber();
                    newgame.play();
                    break;
            }
            Console.Write("Ban co muon tiep tuc? (c/k): ");
            char ops = Convert.ToChar(Console.ReadLine());

            if (ops != 'c' && ops != 'C')
            {
                break;
            }
        }
    }
}