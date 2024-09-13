namespace LAB4.EX3;

public class Student :IComparable<Student>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Student other)
    {
        return Name.CompareTo(other.Name);
    }
}