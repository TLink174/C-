namespace LAB3.BT3;

public class People
{
    string TenSV;
    string Khoa;

    public People(string name, string faculty)
    {
        TenSV = name;
        Khoa = faculty;
    }

    public String Name
     {
         get { return TenSV; }
         set { TenSV = value; }
     }

     public String Faculty
     {
         get { return Khoa; }
         set { Khoa = value; }
     }
}