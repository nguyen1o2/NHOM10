using System;

namespace TinhTienDien
{
    class Program
    {
        class TienDien
        {
            private int dauVao { get; set; }
            private int dauRa { get; set; }
            public TienDien()
            {
                dauVao = dauRa = 0;
            }
            public TienDien(int dauVao,int dauRa)
            {
                this.dauVao = dauVao;
                this.dauRa=dauRa;
            }
            public void nhap()
            {
                try
                {
                    Console.Write("Nhap dau vao: ");
                    dauVao = int.Parse(Console.ReadLine());
                    Console.Write("Nhap dau ra: ");
                    dauRa = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            public void xuat()
            {
                Console.WriteLine("Dau vao: "+dauVao);
                Console.WriteLine("Dau ra: "+dauRa);
            }
            public long TD()
            {
                int sodien = dauRa - dauVao;
                int tongtien = 0;
                if (sodien <= 100)
                {
                    tongtien = sodien * 2000;
                }
                else if (sodien <= 150)
                {
                    tongtien = 100 * 2000 + (sodien - 100) * 2500;
                }
                else if (sodien <= 200)
                {
                    tongtien = 100 * 2000 + 50 * 2500 + (sodien - 150) * 2800;
                }
                else
                {
                    tongtien = 100 * 2000 + 50 * 2500 + 50 * 2800 + (sodien - 200) * 3500;
                }
                return tongtien;
            }
        }
        static void Main(string[] args)
        {
            TienDien T = new TienDien();
            T.nhap();
            T.xuat();
            Console.WriteLine("Tien dien phai tra la: "+T.TD());
            Console.ReadLine();
        }
    }
}
