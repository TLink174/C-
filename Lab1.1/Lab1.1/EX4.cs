namespace Lab1._1;

public class LuckyNumber
{
    public void play()
    {
        Console.WriteLine("Chao mung den voi Tro Choi Doan So!");
        
        // Tạo số ngẫu nhiên từ 1 đến 100
        Random random = new Random();
        int soNgauNhien = random.Next(1, 101);

        int soLanDoan = 7;

        while (soLanDoan > 0)
        {
            Console.Write("Nhap mot so (tu 1 den 100): ");
            int soDuDoan;

            // Kiểm tra đầu vào người dùng
            while (!int.TryParse(Console.ReadLine(), out soDuDoan) || soDuDoan < 1 || soDuDoan > 100)
            {
                Console.Write("So nhap khong hop le. Vui long nhap lai: ");
            }

            // Kiểm tra kết quả
            if (soDuDoan == soNgauNhien)
            {
                Console.WriteLine("Chuc mung! Ban da doan dung!");
                break;
            }
            else
            {
                Console.WriteLine($"So ban nhap {(soDuDoan < soNgauNhien ? "nho" : "lon")} hon so can doan.");
                soLanDoan--;
                Console.WriteLine($"So lan con lai: {soLanDoan}");
            }
        }

        if (soLanDoan == 0)
        {
            Console.WriteLine($"Ban da het luot doan. So can doan la: {soNgauNhien}");
        }
    }
}