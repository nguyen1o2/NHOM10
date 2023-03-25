using System;
using System.Collections.Generic;
namespace Tuan2
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

        public static void TimMAX(int []a,int n)
        {
            int max = a[0];
            for(int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }

            Console.WriteLine("\nMAX = " + max);
        }

        public static void TimMIN(int[] a, int n)
        {
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }

            Console.WriteLine("MIN = " + min);
        }

        public static void SAPXEPTANG(int []a,int n)
        {
            for(int i = 0; i < n-1; i++)
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

        public static void SAPXEPGIAM(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public static void chen(int []a,int n,int vt,int gt)
        {
            for(int i = n; i > vt-1; i--)
            {
                a[i - 1] = a[i];
            }
            a[vt] = gt;
            n++;
        }

        public static void xoa(int []a,int n,int vt)
        {
            for(int i = vt; i < n ; i++)
            {
                a[i + 1] = a[i];
            }
            n--;
        }

        static void Main(string[] args)
        {
            int []a;
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            Nhap(a, n);
            Console.WriteLine("Mang vua nhap la");
            Xuat(a,n);
            TimMAX(a, n);
            TimMIN(a, n);
            SAPXEPTANG(a, n);
            Console.WriteLine("\nMang vua sap xep tang la");
            Xuat(a, n);
            SAPXEPGIAM(a, n);
            Console.WriteLine("\nMang vua sap xep giam la");
            Xuat(a, n);
            xoa(a, n, 3);
            Console.WriteLine("\nMang vua xoa la");
            Xuat(a, n);
            chen(a, n, 5, 3);
            Console.WriteLine("\nMang vua chen la");
            Xuat(a, n);
        }
    }
}
