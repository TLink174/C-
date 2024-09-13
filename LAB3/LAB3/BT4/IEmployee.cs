namespace LAB3.BT4;

public interface IEmployee
{
    string Name { get; set; }
    int YearOfBirth { get; set; }
    string Degree { get; set; }

    double CalculateSalary();
}