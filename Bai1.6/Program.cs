using Bai6;

class Program
{
    public static void Main()
    {
        int n;
        Console.Write(" Nhap so nhan vien: ");
        n = int.Parse(Console.ReadLine());
        Employee[] _arrEmployee = new Employee[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" Nhap thong tin sinh vien thu: " + (i + 1).ToString());
            _arrEmployee[i] = new Employee();
            _arrEmployee[i].Input();
        }

        Console.Write(" Nhap luong co ban: ");
        double basicSalary = double.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            _arrEmployee[i]._basicSalary = basicSalary;
            _arrEmployee[i]._income = _arrEmployee[i]._basicSalary * _arrEmployee[i]._salaryLevel;
        }

        Console.WriteLine(" Danh sach nhan vien: ");
        Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "id", "name", "yearOfBirth", "salaryLevel", " basicSalary", " income");
        for (int i = 0; i < n; i++)
        {
            _arrEmployee[i].xuat();
        }
        Console.ReadLine();
    }
}
