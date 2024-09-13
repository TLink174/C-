using System;

// Khai báo delegate
delegate void DisplayMessage(string message);

class Program
{
    static void Main(string[] args)
    {
        // Khai báo các hàm để thực hiện
        DisplayMessage message1 = MessageMethod1;
        DisplayMessage message2 = MessageMethod2;

        // Gán nhiều hàm vào một delegate
        DisplayMessage allMessages = message1 + message2;

        // Gọi delegate
        allMessages("Chao, day la mot tin nhan tong hop");

        // Xóa một hàm khỏi delegate
        allMessages -= message2;

        // Gọi delegate sau khi xóa
        allMessages("Chao, day la tin nhan");
    }

    static void MessageMethod1(string message)
    {
        Console.WriteLine("Method 1: " + message);
    }

    static void MessageMethod2(string message)
    {
        Console.WriteLine("Method 2: " + message);
    }
}