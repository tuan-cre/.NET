using Bai7;

class Program
{
    public static void Main()
    {
        int n;
        Console.Write(" Nhap so tam giac: ");
        n = int.Parse(Console.ReadLine());
        TamGiac[] _arrTamGiac = new TamGiac[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" Nhap tam giac thu: " + (i + 1).ToString());
            Console.Write(" Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write(" Nhap c: ");
            int c = int.Parse(Console.ReadLine());
            _arrTamGiac[i] = new TamGiac(a, b, c);
            _arrTamGiac[i].TinhChuVi();
            _arrTamGiac[i].TinhDienTich();
            _arrTamGiac[i].XetLoaiTamGiac();
        }

        Console.WriteLine(" Danh sach tam giac: ");
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "canh1", "canh2", "canh3", "chuVi", "dienTich", "loaiTamGiac");
        for (int i = 0; i < n; i++)
        {
            _arrTamGiac[i].xuat();
        }
        Console.ReadLine();
    }
}
