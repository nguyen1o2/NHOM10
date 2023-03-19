using System;

namespace Tuan1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Chu vi HCN = "+((a + b) * 2));
            Console.WriteLine("Dien tich HCN = "+(a*b));
        }
    }
}
