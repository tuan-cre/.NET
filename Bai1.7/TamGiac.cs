namespace Bai7
{
    class TamGiac
    {
        private int canh1;
        private int canh2;
        private int canh3;
        private int chuVi;
        private int loaiTamGiac;
        private float dienTich;

        //Hàm khởi tạo không có tham số
        public TamGiac()
        {
            canh1 = 2;
            canh2 = 3;
            canh3 = -5;
        }
        public TamGiac(int a, int b, int c)
        {
            canh1 = a;
            canh2 = b;
            canh3 = c;
        }
        public int TinhChuVi()
        {
            chuVi = canh1 + canh2 + canh3;
            return chuVi;
        }
        public float TinhDienTich()
        {
            float p = chuVi / 2;
            dienTich = (float)Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
            return dienTich;
        }

        //Các phương thức nhập/xuất dữ liệu
        public int XetLoaiTamGiac()
        {
            if (canh1 == canh2 && canh2 == canh3)
            {
                loaiTamGiac = 1;
            }
            else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
            {
                loaiTamGiac = 2;
            }
            else
            {
                loaiTamGiac = 3;
            }
            return loaiTamGiac;
        }

        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", canh1, canh2, canh3, chuVi, dienTich, loaiTamGiac);
        }
    }
}