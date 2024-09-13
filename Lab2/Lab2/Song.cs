namespace Lab2
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
    
        // Input method to set properties based on user input
        public static Song Input()
        {
            Console.Write("Nhap danh sach: ");
            string typeList = Console.ReadLine();
    
            Console.Write("Nhap ten bai: ");
            string name = Console.ReadLine();
    
            Console.Write("Nhap thoi luong: ");
            string time = Console.ReadLine();
    
            return new Song(typeList, name, time);
        }
    
        // Display method to print song details
        public void DisplayName()
        {
            Console.WriteLine($"Ten bai: {Name}");
        }
    }
}
