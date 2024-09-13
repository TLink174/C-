using System;

class Program
{
    static void Main()
    {
        // Nhập vào họ tên học sinh
        Console.Write("Nhap ho va ten hoc sinh: ");
        string hoTen = Console.ReadLine();

        // Nhập vào điểm thi cuối kỳ
        Console.Write("Nhap diem thi cuoi ky: ");
        double diem = double.Parse(Console.ReadLine());

        // Chuyển họ tên thành chữ IN HOA
        hoTen = hoTen.ToUpper();

        // Xác định xếp loại
        string xepLoai;
        if (diem >= 8)
        {
            xepLoai = "Gioi";
        }
        else if (diem >= 6.5)
        {
            xepLoai = "Kha";
        }
        else if (diem >= 5)
        {
            xepLoai = "Trung binh";
        }
        else
        {
            xepLoai = "Yeu";
        }

        // In kết quả
        Console.WriteLine($"Hoc sinh: {hoTen}");
        Console.WriteLine($"Xep loai: {xepLoai}");
    }
}
