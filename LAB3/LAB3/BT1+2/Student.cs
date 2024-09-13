namespace LAB3.BT1_2;

class Student
{
    private int SID;
    private string TenSV;
    private string Khoa;
    private float DiemTB;

    public Student() // Default constructor
    {
        SID = 1;
        TenSV = "Nguyen Van Nam";
        Khoa = "CNTT";
        DiemTB = 7;
    }

    public Student(Student stu) // Copy constructor
    {
        SID = stu.SID;
        TenSV = stu.TenSV;
        Khoa = stu.Khoa;
        DiemTB = stu.DiemTB;
    }

    // Parameterized constructor
    public Student(int id, string ten, string kh, float dtb)
    {
        SID = id;
        TenSV = ten;
        Khoa = kh;
        DiemTB = dtb;
    }

    // Getter and setter methods for SID
    public int GetStudentID()
    {
        return SID;
    }

    public void SetStudentID(int id)
    {
        SID = id;
    }

    // Getter and setter methods for TenSV
    public string GetName()
    {
        return TenSV;
    }

    public void SetName(string name)
    {
        TenSV = name;
    }

    // Getter and setter methods for Khoa
    public string GetFaculty()
    {
        return Khoa;
    }

    public void SetFaculty(string faculty)
    {
        Khoa = faculty;
    }

    // Getter and setter methods for DiemTB
    public float GetMark()
    {
        return DiemTB;
    }

    public void SetMark(float mark)
    {
        DiemTB = mark;
    }

    // Display method
    public void Show()
    {
        Console.WriteLine("MSSV:{0}", this.GetStudentID());
        Console.WriteLine("Ten SV:{0}", this.GetName());
        Console.WriteLine("Khoa:{0}", this.GetFaculty());
        Console.WriteLine("Diem TB:{0}", this.GetMark());
    }
}
// class Student
// {
//     private int SID;
//     private string TenSV;
//     private string Khoa;
//     private float DiemTB;
//
//     public Student() //Constructor mac dinh
//     {
//         SID = 1;
//         TenSV = "Nguyen Van Nam";
//         Khoa = "CNTT";
//         DiemTB = 7;
//     }
//
//     public Student(Student stu) //Constructor sao chep
//     {
//         SID = stu.SID;
//         TenSV = stu.TenSV;
//         Khoa = stu.Khoa;
//         DiemTB = stu.DiemTB;
//     }
//
//     //Constructor tham so
//     public Student(int id, string ten, string kh, float dtb)
//     {
//         SID = id;
//         TenSV = ten;
//         Khoa = kh;
//         DiemTB = dtb;
//     }
//
//     //Cac Property cho tung thuoc tinh cua lop
//     public int StudentID //Property dai dien cho thuoc tinh SID
//     {
//         get { return SID; } //Lay du lieu
//         set { SID = value; } //Gan du lieu
//     }
//
//     public String Name
//     {
//         get { return TenSV; }
//         set { TenSV = value; }
//     }
//
//     public String Faculty
//     {
//         get { return Khoa; }
//         set { Khoa = value; }
//     }
//
//     public float Mark
//     {
//         get { return DiemTB; }
//         set { DiemTB = value; }
//     }
//
//     //Phuong thuc hien thi du lieu
//     public void Show()
//     {
//         Console.WriteLine("MSSV:{0}", this.SID);
//         Console.WriteLine("Ten SV:{0}", this.TenSV);
//         Console.WriteLine("Khoa:{0}", this.Khoa);
//         Console.WriteLine("Diem TB:{0}", this.DiemTB);
//     }
// }