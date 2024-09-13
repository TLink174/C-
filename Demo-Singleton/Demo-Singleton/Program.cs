using Demo_Singleton;

class Program
{
    static void Main(string[] args)
    {
        OnScreenKeyboard k1 = OnScreenKeyboard.Instance;
        k1.Height = 15;
        k1.Width = 20;
        k1.Display();
        OnScreenKeyboard k2 = OnScreenKeyboard.Instance;
        k2.Display();
        k2.Height = 15;
        k2.Width = 30;
        k2.Display();
    }
}
