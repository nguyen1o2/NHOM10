using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan4
{
    class tuan4
    {
        public static void Main()
        {

            int[] arr1 = new int[100];
            int i, j, n, bien_dem = 0; //day la bien dem


            Console.Write("\nTim so phan tu giong nhau trong mot mang trong C#:\n");
            Console.Write("---------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu vao trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*Tim kiem cac phan tu giong nhau*/
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    /*Tang bien dem bien_dem khi tim thay phan tu giong nhau.*/
                    if (arr1[i] == arr1[j])
                    {
                        bien_dem++;
                        break;
                    }
                }
            }

            Console.Write("\nSo phan tu giong nhau trong mang la: {0}\n\n", bien_dem);

            Console.ReadKey();
        }
    }
}
