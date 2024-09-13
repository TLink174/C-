using System.Collections;
using LAB3.BT1_2;
using LAB3.BT4;

class Run()
{
    public static void Main()
    { 
        //BT1+2+3
    //     Student[] DSSV;
    //     int n;
    //     Console.Write("Nhap so luong SV:");
    //     n = int.Parse(Console.ReadLine());
    //     DSSV = new Student[n]; //tao mang n phan tu
    //     Console.WriteLine("\n ====NHAP DS SINH VIEN====");
    //     for (int i = 0; i < n; i++) //Lap n lan nhap thong tin sv
    //     {
    //         DSSV[i] = new Student();
    //         Console.Write("Nhap MaSV {0}:",i+1);
    //         DSSV[i].StudentID =int.Parse(Console.ReadLine());
    //         Console.Write("Ho ten SV:");
    //         DSSV[i].Name = Console.ReadLine();
    //         Console.Write("Nhap khoa:");
    //         DSSV[i].Faculty = Console.ReadLine();
    //         Console.Write("Nhap Diem TB:");
    //         DSSV[i].Mark = float.Parse(Console.ReadLine());
    //     }
    // //Xuat DS Sinh vien
    //     Console.WriteLine("\n ====XUAT DS SINH VIEN====");
    //     foreach (Student sv in DSSV)
    //         sv.Show();
    //     Console.ReadLine();
        //BT2
    // List<Student> stds = new List<Student>();
    // NhapDS(stds);
    // XuatDS(stds);
        // BT3
        // List<Student> studentsList = new List<Student>();
        // NhapDS(studentsList);
        //
        //
        // Console.WriteLine("Danh sach sinh vien su dung List:");
        // XuatDS(studentsList);
        // Console.WriteLine("--------------");
        //
        // // Sử dụng ArrayList để lưu danh sách sinh viên
        // ArrayList studentsArrayList = new ArrayList();
        //
        // NhapDSAR(studentsArrayList);
        //
        // Console.WriteLine("\nDanh sach sinh vien su dung ArrayList:");
        //     XuatDSAR(studentsArrayList);
        //     Console.WriteLine("--------------");
        
            // BT4
            Institute institute = new Institute();

            // Nhập thông tin cho Scientist
            Console.WriteLine("Nhap thong tin Nha khoa hoc:");
            Scientist scientist = new Scientist();
            Console.Write("Ten: ");
            scientist.Name = Console.ReadLine();
            Console.Write("Nam sinh: ");
            scientist.YearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Bang cap: ");
            scientist.Degree = Console.ReadLine();
            Console.Write("Chuc vu: ");
            scientist.Position = Console.ReadLine();
            Console.Write("So bai bao da cong bo: ");
            scientist.PublishedArticles = int.Parse(Console.ReadLine());
            Console.Write("So ngay cong trong thang: ");
            scientist.WorkingDays = int.Parse(Console.ReadLine());
            Console.Write("Bac luong: ");
            scientist.SalaryLevel = int.Parse(Console.ReadLine());

            institute.AddEmployee(scientist);

            // Nhập thông tin cho Manager
            Console.WriteLine("Nhap thong tin Nha quan ly:");
            Manager manager = new Manager();
            Console.Write("Ten: ");
            manager.Name = Console.ReadLine();
            Console.Write("Nam sinh: ");
            manager.YearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Bang cap: ");
            manager.Degree = Console.ReadLine();
            Console.Write("Chuc vu: ");
            manager.Position = Console.ReadLine();
            Console.Write("So ngay cong trong thang: ");
            manager.WorkingDays = int.Parse(Console.ReadLine());
            Console.Write("Bac luong: ");
            manager.SalaryLevel = int.Parse(Console.ReadLine());

            institute.AddEmployee(manager);

            // Nhập thông tin cho Lab Worker
            Console.WriteLine("Nhap thong tin Nhan vien phong thi nghiem:");
            LabWorker labWorker = new LabWorker();
            Console.Write("Ten: ");
            labWorker.Name = Console.ReadLine();
            Console.Write("Nam sinh: ");
            labWorker.YearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("Bang cap: ");
            labWorker.Degree = Console.ReadLine();
            Console.Write("Luong theo thang: ");
            labWorker.MonthlySalary = int.Parse(Console.ReadLine());

            institute.AddEmployee(labWorker);

            // In tổng lương theo loại nhân viên
            institute.PrintTotalSalariesByType();
    }
    static void Nhap1SV(Student std)
    {
        Console.Write("Nhap MaSV: ");
        std.SetStudentID(int.Parse(Console.ReadLine()));
        Console.Write("Nhap Ten SV: ");
        std.SetName(Console.ReadLine());
        Console.Write("Nhap Khoa: ");
        std.SetFaculty(Console.ReadLine());
        Console.Write("Nhap Diem TB: ");
        std.SetMark(float.Parse(Console.ReadLine()));
    }
    static void NhapDS(List<Student> stds)
    {
        Console.Write("Nhap so luong SV: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Student std = new Student();
            Nhap1SV(std);
            stds.Add(std);
        }
    }
    static void XuatDS(List<Student> stds)
    {
        foreach (var std in stds)
        {
            std.Show();
        }
    }
    static void NhapDSAR(ArrayList stds)
    {
        Console.Write("Nhap so luong SV: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Student std = new Student();
            Nhap1SV(std);
            stds.Add(std);
        }
    }
    static void XuatDSAR(ArrayList stds)
    {
        foreach (var std in stds)
        {
            ((Student)std).Show();
        }
    }
}
