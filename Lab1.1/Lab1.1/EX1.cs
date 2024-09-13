namespace Lab1._1;

using System;

public class  Caculator
{
    private int a, b;
    private char op;

    public string Name { get; set; }

    public Caculator(int a, int b, char op)
    {
        this.a = a;
        this.b = b;
        this.op = op;
    }
    public void Solve()
    {
        int result = 0;
        
        // Tinh toan theo tung toan tu
        switch (op)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                // kiem tra mau
                if (b==0)
                {
                    Console.WriteLine("Loi: b phai khac 0");
                    return;
                }
                result = a / b;
                break;
            default:
                Console.WriteLine("Loi: Toan tu khong ton tai!!!");
                return;
        }
        // Hien thi ket qua
        Console.WriteLine($"Ket qua cua {a} {op} {b} = {result}");
    }
}