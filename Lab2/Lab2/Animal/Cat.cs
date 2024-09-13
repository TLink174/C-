namespace Lab2.Animal;

public class Cat : Animal
{
    public string Ten { get; set; }

    public Cat(string ten) : base("Dong vat co vu")
    {
        Ten = ten;
    }

    public override string AmThanh()
    {
        return "Meo meo!";
    }

    public string Leo(string mucTieu)
    {
        return $"{Ten} Dang leo len {mucTieu}.";
    }

    public override string ThongTin()
    {
        return $"Meo: {Ten}, Loai: {Loai}";
    }
}