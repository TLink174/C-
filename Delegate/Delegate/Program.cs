using System;

// Khai báo delegate
public delegate int MathOperation(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        // Khai báo một hàm có kiểu dữ liệu là MathOperation
        MathOperation addition = AddNumbers;
        MathOperation subtraction = SubtractNumbers;

        // Gọi delegate
        int result1 = addition(5, 3); // Kết quả: 8
        int result2 = subtraction(5, 3); // Kết quả: 2

        Console.WriteLine("Ket qua phep cong: " + result1);
        Console.WriteLine("Ket qua phep tru: " + result2);
    }

    // Hàm thực hiện phép cộng
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    // Hàm thực hiện phép trừ
    static int SubtractNumbers(int a, int b)
    {
        return a - b;
    }
}