using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    class Program
    {
        
        static void giaiPTBac2(float a, float b, float c)
        {
            // kiem tra cac he so
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.Write("Phuong trinh vo nghiem!");
                }
                else
                {
                    Console.Write("Phuong trinh co mot nghiem: x = {0}", (-c / b));
                }
                return;
            }
            // tinh delta
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            // tinh nghiem
            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem!");
            }
        }
        /**
        * Ham main
        */
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Nhap he so bac 2, a = ");
            String valA = Console.ReadLine();
            a = Convert.ToInt32(valA);
            Console.Write("Nhap he so bac 1, b = ");
            String valB = Console.ReadLine();
            b = Convert.ToInt32(valB);
            Console.Write("Nhap he so bac 0, c = ");
            String valC = Console.ReadLine();
            c = Convert.ToInt32(valC);
            giaiPTBac2(a, b, c);
        }
    }
}