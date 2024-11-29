namespace Bai8
{
    class PTBacHai
    {
        private int Soa;
        private int Sob;
        private int Soc;

        //Hàm khởi tạo không có tham số
        public PTBacHai()
        {
            Soa = 1;
            Sob = 1;
            Soc = 1;
        }
        public PTBacHai(int a, int b, int c)
        {
            Soa = a;
            Sob = b;
            Soc = c;
        }
        public int _Soa
        {
            get { return Soa; }
             set { Soa = value; }
        }
        public int _Sob
        {
            get { return Sob; }
            set { Sob = value; }
        }
        public int _Soc
        {
            get { return Soc; }
            set { Soc = value; }
        }
        public void GiaiPT()
        {
            if (Soa == 0)
            {
                if (Sob == 0)
                {
                    if (Soc == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem x = {0}", -Soc / Sob);
                }
            }
            else
            {
                int delta = Sob * Sob - 4 * Soa * Soc;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", -Sob / (2 * Soa));
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", (-Sob + Math.Sqrt(delta)) / (2 * Soa));
                    Console.WriteLine("x2 = {0}", (-Sob - Math.Sqrt(delta)) / (2 * Soa));
                }
            }
        }
        public void XuatNghiem()
        {
            Console.WriteLine("Phuong trinh bac 2: {0}x^2 + {1}x + {2} = 0", Soa, Sob, Soc);
            GiaiPT();
        }
    }
}