namespace Lab2;

class Fraction
{
    private int tuSo;
    private int mauSo;

    public Fraction(int tuSo, int mauSo)
    {
        if (mauSo == 0)
        {
            throw new ArgumentException("Mau so khong the bang khong.");
        }

        this.tuSo = tuSo;
        this.mauSo = mauSo;
        ChuanHoa();
    }

    private void ChuanHoa()
    {
        int ucln = UCLN(Math.Abs(tuSo), Math.Abs(mauSo));
        tuSo /= ucln;
        mauSo /= ucln;

        if (mauSo < 0)
        {
            tuSo = -tuSo;
            mauSo = -mauSo;
        }
    }

    private int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static Fraction Cong(Fraction phanSo1, Fraction phanSo2)
    {
        int tuSoKetQua = phanSo1.tuSo * phanSo2.mauSo + phanSo2.tuSo * phanSo1.mauSo;
        int mauSoKetQua = phanSo1.mauSo * phanSo2.mauSo;
        return new Fraction(tuSoKetQua, mauSoKetQua);
    }

    public static Fraction Tru(Fraction phanSo1, Fraction phanSo2)
    {
        int tuSoKetQua = phanSo1.tuSo * phanSo2.mauSo - phanSo2.tuSo * phanSo1.mauSo;
        int mauSoKetQua = phanSo1.mauSo * phanSo2.mauSo;
        return new Fraction(tuSoKetQua, mauSoKetQua);
    }

    public static Fraction Nhan(Fraction phanSo1, Fraction phanSo2)
    {
        int tuSoKetQua = phanSo1.tuSo * phanSo2.tuSo;
        int mauSoKetQua = phanSo1.mauSo * phanSo2.mauSo;
        return new Fraction(tuSoKetQua, mauSoKetQua);
    }

    public static Fraction Chia(Fraction phanSo1, Fraction phanSo2)
    {
        if (phanSo2.tuSo == 0)
        {
            throw new DivideByZeroException("Khong the chia cho so khong.");
        }

        int tuSoKetQua = phanSo1.tuSo * phanSo2.mauSo;
        int mauSoKetQua = phanSo1.mauSo * phanSo2.tuSo;
        return new Fraction(tuSoKetQua, mauSoKetQua);
    }

    public override string ToString()
    {
        return $"({tuSo}/{mauSo})";
    }

    public void HienThiDangThapPhan()
    {
        double giaTriThapPhan = (double)tuSo / mauSo;
        Console.WriteLine(giaTriThapPhan);
    }
}
