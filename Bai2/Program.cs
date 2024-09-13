using System;

class Program
{
    static void Main()
    {
        // Nhap vao cac he so a, b, c
        Console.Write("Nhap he so a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap he so b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap he so c: ");
        double c = double.Parse(Console.ReadLine());

        // Kiem tra gia tri cua a
        if (a == 0)
        {
            Console.WriteLine("Day khong phai la phuong trinh bac hai.");
        }
        else
        {
            // Tinh delta
            double delta = b * b - 4 * a * c;

            // Kiem tra cac truong hop cua delta
            if (delta > 0)
            {
                // Hai nghiem phan biet
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phuong trinh co hai nghiem phan biet: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                // Nghiem kep
                double x = -b / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep: x = {x}");
            }
            else
            {
                // Vo nghiem
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }
    }
}
