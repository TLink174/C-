using System;

class Program
{
    static void Main()
    {
        int so;

        do
        {
            // Nhap vao mot so nguyen
            Console.Write("Nhap mot so nguyen: ");
            so = int.Parse(Console.ReadLine());

            // Kiem tra neu so nguyen am thi thong bao
            if (so <= 0)
            {
                Console.WriteLine("Vui long nhap mot so nguyen duong.");
            }

        } while (so <= 0); // Lap lai cho den khi nhap vao so nguyen duong

        // Thong bao so nguyen duong hop le
        Console.WriteLine($"Ban da nhap so nguyen duong: {so}");
    }
}
