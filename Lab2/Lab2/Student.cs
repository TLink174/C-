using System;

namespace Lab2
{
    public class Student : Person
    {
        private double gpa;

        public double Gpa
        {
            get { return gpa; }
            set
            {
                while (value < 0 && value > 4)
                {
                    Console.WriteLine("Gia tri phai lon hon 0! Nhap lai.");
                    Console.Write("Nhap diem trung binh: ");
                    if (double.TryParse(Console.ReadLine(), out double newGpa))
                    {
                        value = newGpa;
                    }
                }

                gpa = value;
            }
        }


        // DisplayStudent method to print student information
        public void DisplayStudent()
        {
            Console.WriteLine($"{ToString()}, GPA: {Gpa}");
        }

        // Input method to get input for student GPA
        public new void Input()
        {
            base.Input(); // Call the base class's Input method for common input
            try
            {
                Console.Write("Nhap diem trung binh: ");
                double diemTrungBinh = Convert.ToDouble(Console.ReadLine());
                Gpa = diemTrungBinh; // Update the StudentGpa property
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
        // Constructor with parameters
        public Student(double gpa, string name, int age) :base(age, name)
        {
            Gpa = gpa;
        }
        // Additional constructor overload with no parameters
        public Student() : base()
        {
            Gpa = 0.0;
        }

        
    }
}