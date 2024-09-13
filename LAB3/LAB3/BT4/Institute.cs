namespace LAB3.BT4;

public class Institute
{
    private List<IEmployee> employees = new List<IEmployee>();

    public void AddEmployee(IEmployee employee)
    {
        employees.Add(employee);
    }

    public void PrintTotalSalariesByType()
    {
        double totalSalaryScientist = 0;
        double totalSalaryManager = 0;
        double totalSalaryLabWorker = 0;

        foreach (var employee in employees)
        {
            if (employee is Scientist)
            {
                totalSalaryScientist += employee.CalculateSalary();
            }
            else if (employee is Manager)
            {
                totalSalaryManager += employee.CalculateSalary();
            }
            else if (employee is LabWorker)
            {
                totalSalaryLabWorker += employee.CalculateSalary();
            }
        }

        Console.WriteLine($"Total Salary for Scientists: {totalSalaryScientist}");
        Console.WriteLine($"Total Salary for Managers: {totalSalaryManager}");
        Console.WriteLine($"Total Salary for Lab Workers: {totalSalaryLabWorker}");
    }
}
