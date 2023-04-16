using System;

namespace VietJackCsharp
{
    class tuan5
    {
        public static void Main()
        {

            int[] arr1 = new int[10];

            int n, i, j, tmp; //tmp la bien tam (bien trung gian)


            Console.Write("\nSap xep mang theo thu tu giam dan trong C#:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        //cach trao doi gia tri
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            Console.Write("\nIn cac phan tu mang theo thu tu giam dan:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}