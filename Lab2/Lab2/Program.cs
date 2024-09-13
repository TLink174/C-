using Lab2;
using System;
using Lab2.Shape;
using Lab2.Animal;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. XucXac");
            Console.WriteLine("2. DiemTB");
            Console.WriteLine("3. BaiHat");
            Console.WriteLine("4. PhanSo");
            Console.WriteLine("5. HinhHoc");
            Console.WriteLine("6. DongVat");
            Console.Write("Chon bai: ");
            int bai = Convert.ToInt32(Console.ReadLine());
    
            switch (bai)
            {
                case 1: // Use integers in the case conditions instead of characters
                    Console.Write("Nhap so mat cua xuc xac: ");
                    if (int.TryParse(Console.ReadLine(), out int sides))
                    {
                        // Tạo một đối tượng của lớp XucXac
                        Dice dice = new Dice(sides);
    
                        // Tung xúc xắc và hiển thị kết quả
                        int ketQua = dice.RollResult();
                        Console.WriteLine($"Ket qua sau khi tung xuc xac co {sides} mat la: {ketQua}");
                    }
                    else
                    {
                        Console.WriteLine("Nhap khong hop le. Vui long nhap so nguyen duong cho so mat");
                    }
                    break;
    
                case 2:
                    Student std = new Student();
                    std.Input();
                    std.DisplayStudent();
                    break;
                case 3:
                    Console.Write("Nhap so bai hat: ");
                    int numberOfSongs = int.Parse(Console.ReadLine());

                    List<Song> songs = new List<Song>();

                    for (int i = 0; i < numberOfSongs; i++)
                    {
                        Console.WriteLine($"Nhap bai hat {i + 1}:");
                        Song song = Song.Input();
                        songs.Add(song);
                    }

                    Console.WriteLine("Nhap danh sach (hoac 'all' de hien thi tat ca bai hat): ");
                    string requestedTypeList = Console.ReadLine();

                    if (requestedTypeList == "all")
                    {
                        foreach (var song in songs)
                        {
                            song.DisplayName();
                        }
                    }
                    else
                    {
                        foreach (var song in songs.Where(s => s.TypeList == requestedTypeList))
                        {
                            song.DisplayName();
                        }
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Nhap phan so thu nhat:");
                        Fraction phanSo1 = NhapPhanSo();

                        Console.WriteLine("Nhap phan so thu hai:");
                        Fraction phanSo2 = NhapPhanSo();

                        Console.WriteLine($"Tong: {Fraction.Cong(phanSo1, phanSo2)}");
                        Console.WriteLine($"Hieu: {Fraction.Tru(phanSo1, phanSo2)}");
                        Console.WriteLine($"Tich: {Fraction.Nhan(phanSo1, phanSo2)}");

                        try
                        {
                            Console.WriteLine($"Thuong: {Fraction.Chia(phanSo1, phanSo2)}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine($"Loi: {ex.Message}");
                        }

                        Console.WriteLine($"Gia tri thap phan cua phan so thu nhat:");
                        phanSo1.HienThiDangThapPhan();
                        phanSo2.HienThiDangThapPhan();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Loi: {ex.Message}");
                    }
                    static Fraction NhapPhanSo()
                    {
                        Console.Write("Nhap tu so: ");
                        int tuSo = int.Parse(Console.ReadLine());

                        Console.Write("Nhap mau so: ");
                        int mauSo = int.Parse(Console.ReadLine());

                        return new Fraction(tuSo, mauSo);
                    }
                    break;
                case 5:
                    Line line = new Line(1, 2, 4, 6);
                    Circle circle = new Circle(5, 5, 3);
                    Rectangle rectangle = new Rectangle(0, 0, 8, 4);
                    PolyLine polyLine = new PolyLine(3, 3);

                    line.Show();
                    circle.Show();
                    rectangle.Show();
                    polyLine.Show();

                    line.Move(2, 2);
                    circle.Move(7, 7);
                    rectangle.Move(1, 1);
                    polyLine.Move(4, 4);

                    Console.WriteLine(line.ToString());
                    Console.WriteLine(circle.ToString());
                    Console.WriteLine(rectangle.ToString());
                    Console.WriteLine(polyLine.ToString());
                    break;
                case 6:
                    Dog choCuaToi = new Dog("Buddy", "Spaniel");
                    Cat meoCuaToi = new Cat("Whiskers");
                    Duck vitCuaToi = new Duck("Daffy");

                    Console.WriteLine(choCuaToi.AmThanh());
                    Console.WriteLine(choCuaToi.ThongTin());

                    Console.WriteLine(meoCuaToi.AmThanh());
                    Console.WriteLine(meoCuaToi.Leo("cây"));
                    Console.WriteLine(meoCuaToi.ThongTin());

                    Console.WriteLine(vitCuaToi.AmThanh());
                    Console.WriteLine(vitCuaToi.Boi("ao"));
                    Console.WriteLine(vitCuaToi.ThongTin());
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