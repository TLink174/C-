namespace LAB3.BT4;

public class Scientist : IEmployee
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
    public string Degree { get; set; }
    public string Position { get; set; }
    public int PublishedArticles { get; set; }
    public int WorkingDays { get; set; }
    public int SalaryLevel { get; set; }

    public double CalculateSalary()
    {
        return WorkingDays * SalaryLevel;
    }
}
