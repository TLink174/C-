using System;

class Program
{
    static void Main()
    {
        // Nhap vao mot so nguyen duong n chi nam duong lich
        Console.Write("Nhap mot nam duong lich: ");
        int n = int.Parse(Console.ReadLine());

        // Kiem tra nam nhuan
        bool laNamNhuan = KiemTraNamNhuan(n);

        // In ket qua
        if (laNamNhuan)
        {
            Console.WriteLine($"{n} la nam nhuan.");
        }
        else
        {
            Console.WriteLine($"{n} khong phai la nam nhuan.");
        }
    }

    // Ham kiem tra nam nhuan
    static bool KiemTraNamNhuan(int n)
    {
        // Nam nhuan la nam chia het cho 4 va khong chia het cho 100, hoac chia het cho 400
        return (n % 4 == 0 && n % 100 != 0) || (n % 400 == 0);
    }
}
