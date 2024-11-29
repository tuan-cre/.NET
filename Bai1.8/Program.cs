using Bai8;

class Program
{
    public static void Main()
    {
        PTBacHai pt = new PTBacHai();
        Console.WriteLine(" Nhap he so pt bac 2: ");
        Console.Write(" Nhap a: ");
        pt._Soa = int.Parse(Console.ReadLine());
        Console.Write(" Nhap b: ");
        pt._Sob = int.Parse(Console.ReadLine());
        Console.Write(" Nhap c: ");
        pt._Soc = int.Parse(Console.ReadLine());
        pt.XuatNghiem();
    }
}
