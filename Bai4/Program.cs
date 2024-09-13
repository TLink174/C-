using System;

class Program
{
    static void Main()
    {
        // Nhap vao mot so nguyen
        Console.Write("Nhap mot so nguyen n: ");
        int n = int.Parse(Console.ReadLine());

        // Kiem tra so nguyen to
        bool laSoNguyenTo = KiemTraSoNguyenTo(n);

        // In ket qua
        if (laSoNguyenTo)
        {
            Console.WriteLine($"{n} la so nguyen to.");
        }
        else
        {
            Console.WriteLine($"{n} khong phai la so nguyen to.");
        }
    }

    // Ham kiem tra so nguyen to
    static bool KiemTraSoNguyenTo(int n)
    {
        if (n < 2)
        {
            return false; // So nho hon 2 khong phai la so nguyen to
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false; // Neu chia het cho i thi khong phai la so nguyen to
            }
        }

        return true; // Neu khong co uoc nao chia het thi la so nguyen to
    }
}
