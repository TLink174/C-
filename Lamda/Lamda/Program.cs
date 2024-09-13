using System;

class Program
{
    delegate int MathOperation(int a, int b);

    static void Main(string[] args)
    {
        // Sử dụng biểu thức Lambda để khai báo delegate
        MathOperation addition = (a, b) => a + b;
        MathOperation subtraction = (a, b) => a - b;

        // Gọi delegate
        int result1 = addition(5, 3); // Kết quả: 8
        int result2 = subtraction(5, 3); // Kết quả: 2

        Console.WriteLine("Ket qua phep cong: " + result1);
        Console.WriteLine("Ket qua phep tru: " + result2);
    }
}