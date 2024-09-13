// using System;
// using System.Collections.Generic;
// using LAB4.EX1;
// using LAB4.EX2;
// using LAB4.EX3;
//
// class Program
// {
//     static void Main()
//     {
//         /*EX1
//         List<double> numbers = new List<double> { 3.1, 3.1, 5.5, 2.2, 2.2, 2.2, 4.4 };
//         Sum.sum(numbers);
//         foreach (var num in numbers)
//         {
//             Console.Write(num + ", ");
//         }*/
//         
//         /*EX2
//         List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//         int sum = SumInOrder.sumInOrder(nums);
//         Console.WriteLine("Sum: " + sum);*/
//         
//         /*EX3
//         List<Student> students = new List<Student>
//         {
//             new Student { ID = 1, Name = "Nam", Age = 20 },
//             new Student { ID = 2, Name = "Linh", Age = 22 },
//             new Student { ID = 3, Name = "An", Age = 21 }
//         };
//
//         students.Sort();
//         
//         Console.WriteLine("Sorted list of students by name:");
//         foreach (var student in students)
//         {
//             Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
//         }*/
//     }
// }

using System;
using System.Collections.Generic;

namespace Cars
{
    public interface ICar
    {
        string Make { get; }
        string Color { get; }
        string Start();
        string Stop();
    }

    public class Seat : ICar
    {
        public string Make { get; }
        public string Color { get; }

        public Seat(string make, string color)
        {
            Make = make;
            Color = color;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Seat {Make}\nStart: {Start()}\nStop: {Stop()}";
        }
    }

    public class Tesla : ICar
    {
        public string Make { get; }
        public string Color { get; }
        public int Batteries { get; }

        public Tesla(string make, string color, int batteries)
        {
            Make = make;
            Color = color;
            Batteries = batteries;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} Tesla {Make} with {Batteries} Batteries\nStart: {Start()}\nStop: {Stop()}";
        }
    }

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>
            {
                new Seat("Leon", "Grey"),
                new Tesla("Model 3", "Red", 2)
            };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
