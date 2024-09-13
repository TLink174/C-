namespace Lab2.Animal;

public class Duck : Animal
{
    public string Ten { get; set; }

    public Duck(string ten) : base("Chim")
    {
        Ten = ten;
    }

    public override string AmThanh()
    {
        return "Quack quack!";
    }

    public string Boi(string diaDiem)
    {
        return $"{Ten} dang boi trong {diaDiem}.";
    }

    public override string ThongTin()
    {
        return $"Vit: {Ten}, Loai: {Loai}";
    }
}