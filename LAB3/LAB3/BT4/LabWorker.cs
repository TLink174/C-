namespace LAB3.BT4;

public class LabWorker : IEmployee
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
    public string Degree { get; set; }
    public double MonthlySalary { get; set; }

    public double CalculateSalary()
    {
        return MonthlySalary;
    }
}