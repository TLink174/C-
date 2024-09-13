namespace Lab2.Animal;

public class Dog : Animal
{
    public string Ten { get; set; }
    public string Giong { get; set; }

    public Dog(string ten, string giong) : base("Dong vat co vu")
    {
        Ten = ten;
        Giong = giong;
    }

    public override string AmThanh()
    {
        return "Gau gau!";
    }

    public override string ThongTin()
    {
        return $"Cho: {Ten}, Loai: {Loai}, Giong: {Giong}";
    }
}