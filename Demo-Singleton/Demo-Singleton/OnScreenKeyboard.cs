namespace Demo_Singleton
{
    public class OnScreenKeyboard
    {
        private static OnScreenKeyboard instance = null;
        private double height;
        private double width;
        public double Height 
        { 
            get => height; 
            set =>height = value;
        }
        public double Width 
        { 
            get => width; 
            set => width = value;

        }

        public static OnScreenKeyboard Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OnScreenKeyboard();
                }
                return instance;
            }
        }

        private OnScreenKeyboard()
        {
            Console.WriteLine("A Keyboard");
        }

        public void Display()
        {
            Console.WriteLine($"Height: {Height}, Width: {Width}");
        }
    }
}