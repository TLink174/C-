namespace Lab2.Animal;

public abstract class Animal
{
    protected string Loai;

    public Animal(string loai)
    {
        Loai = loai;
    }

    public abstract string AmThanh();

    public abstract string ThongTin();
}