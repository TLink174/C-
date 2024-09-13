namespace LAB3.BT3;

public class Student : People
{
    private int MaSV;
    private float DiemTB;
    public int StudentID
    {
        get { return MaSV; }
        set { MaSV = value; }
    }

    public float Mark
    {
        get { return DiemTB; }
        set { DiemTB = value; }
    }

    public Student(string name, string faculty, int studentID, float mark)
        : base(name, faculty)
    {
        StudentID = studentID;
        Mark = mark;
    }

    public void Show()
    {
        Console.WriteLine("MSSV:{0}", this.StudentID);
        Console.WriteLine("Ten SV:{0}", this.Name);
        Console.WriteLine("Khoa:{0}", this.Faculty);
        Console.WriteLine("Diem TB:{0}", this.Mark);
    }
}