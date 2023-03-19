using System;

namespace Tuan1
{
    class Program
    {
        public static void Nhap(int []a,int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void Xuat(int []a,int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + "\t");
            }
        }
        public static void Sapxeptang(int []a,int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {   int []a;
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());         
            a = new int[n];
            Nhap(a, n);
            Console.WriteLine("Mang vua nhap la");
            Xuat(a, n);
            Sapxeptang(a, n);
            Console.WriteLine("\nMang sau khi sap xep la");
            Xuat(a, n);
            Console.ReadLine();
        }
    }
}
