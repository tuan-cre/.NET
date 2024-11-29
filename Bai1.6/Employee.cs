namespace Bai6
{
    class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary = 10000;
        private double income;

        //Hàm khởi tạo không có tham số
        public Employee()
        {
            id = 0;
            name = "";
            yearOfBirth = 0;
            salaryLevel = 0;
            income = 0;
        }

        //Các phương thức Properties để get/set giá trị cho các thuộc tính
        public int GetId
        {
            get { return id; }
            set { id = value; }
        }
        public string GetName
        {
            get { return name; }
            set { name = value; }
        }
        public int GetYearOfBirth
        {
            get { return yearOfBirth; }
            set { yearOfBirth = value; }
        }
        public double _salaryLevel
        {
            get { return salaryLevel; }
            set { salaryLevel = value; }
        }
        public double _basicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
        public double _income
        {
            get { return income; }
            set { income = value; }
        }

        //Các phương thức nhập/xuất dữ liệu
        public void Input()
        {
            Console.Write(" \t -Nhap id:");
            id = int.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap ten:");
            name = Console.ReadLine();
            Console.Write(" \t -Nhap nam sinh:");
            yearOfBirth = int.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap luong:");
            salaryLevel = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", id, name, yearOfBirth,salaryLevel,basicSalary,income);
        }

    }
}