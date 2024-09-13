using System;

class Program
{
    static void Main()
    {
        // Nhap vao mot so nguyen duong n
        Console.Write("Nhap mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        // Kiem tra dieu kien n > 0
        if (n <= 0)
        {
            Console.WriteLine("Vui long nhap mot so nguyen duong lon hon 0.");
            return;
        }

        // Tinh tong S1
        double S1 = 0;
        for (int i = 1; i <= n; i++)
        {
            S1 += 1.0 / i;
        }

        // In ket qua
        Console.WriteLine($"Tong S1 = 1 + 1/2 + 1/3 + ... + 1/{n} = {S1}");
    }
}
