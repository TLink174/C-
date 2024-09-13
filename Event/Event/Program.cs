using System;

// Định nghĩa event publisher
class EventPublisher
{
    public event EventHandler<string> EventOccured;

    public void DoSomething()
    {
        // Khi có sự kiện xảy ra, gọi event để thông báo cho các observer
        EventOccured?.Invoke(this, "Something happened");
    }
}

// Định nghĩa event subscriber
class EventSubscriber
{
    public EventSubscriber(EventPublisher publisher)
    {
        // Đăng ký để nhận thông báo từ event publisher
        publisher.EventOccured += HandleEvent;
    }

    void HandleEvent(object sender, string message)
    {
        Console.WriteLine("Received event message: " + message);
    }
}

// Sử dụng

class Program
{
    public static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber(publisher);
        publisher.DoSomething(); // Khi publisher thực hiện hành động, subscriber sẽ nhận thông báo
    }
}