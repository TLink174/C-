namespace Lab2
{
    public class Person
    {
        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Tuoi phai lon hon 0! Nhap lai.");
                    Console.Write("Nhap tuoi: ");
                    if (int.TryParse(Console.ReadLine(), out int newAge))
                    {
                        value = newAge;
                    }
                }

                age = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                while (string.IsNullOrEmpty(value) || value.Any(c => !char.IsLetter(c)))
                {
                    Console.WriteLine("Ten khong hop le! Nhap lai.");
                    Console.Write("Nhap Ho ten: ");
                    value = Convert.ToString(Console.ReadLine());
                }

                name = value;
            }
        }
        
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        
        public Person() : this(0, "a") { }
        
        public override string ToString()
        {
            return $"HoTen: {Name}, Tuoi: {Age}";
        }

        public void DisplayPerson()
        {
            Console.WriteLine(ToString());
        }

        public void Input()
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhap Ho ten: ");
                    string ten = Convert.ToString(Console.ReadLine());
                    Name = ten; // Update the Name property
                    break;      // Exit the loop if the name is valid
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Loi: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Loi: {ex.Message}");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhap tuoi: ");
                    int tuoi = Convert.ToInt32(Console.ReadLine());
                    Age = tuoi; // Update the Age property
                    break;      // Exit the loop if the age is valid
                }
                catch (FormatException)
                {
                    Console.WriteLine("Loi nhap lieu! Vui long nhap dung dinh dang.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Loi: {ex.Message}");
                }
            }
        }

    }
}
