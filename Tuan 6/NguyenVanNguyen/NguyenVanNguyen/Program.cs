using System;

namespace NguyenVanNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2; //khai bao hai chuoi
            int flg = 0;
            int i = 0, l1, l2, yn = 0;

            Console.Write("\nSo sanh hai chuoi trong C#:\n");
            Console.Write("----------------------------------\n");
            Console.Write("Nhap chuoi thu nhat: ");
            str1 = Console.ReadLine();

            Console.Write("Nhap chuoi thu hai: ");
            str2 = Console.ReadLine();

            l1 = str1.Length;
            l2 = str2.Length;
            /*so sanh xem hai chuoi co do dai bang nhau khong*/
            if (l1 == l2)
            {
                for (i = 0; i < l1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        yn = 1;
                        i = l1;

                    }
                }
            }
            /*khoi tao bien flg khi hai chuoi co do dai la bang, ngan hon, hay dai hon*/
            if (l1 == l2)
                flg = 0;
            else if (l1 > l2)
                flg = 1;
            else if (l1 < l2)
                flg = -1;
            /*hien thi thong bao tuong ung khi hai chuoi co do dai la bang, ngan hon, hay dai hon*/
            if (flg == 0)
            {
                if (yn == 0)
                    Console.Write("\nHai chuoi co do dai bang nhau \nva hai chuoi cung giong nhau.\n\n");
                else
                    Console.Write("\nHai chuoi co do dai bang nhau \nnhung hai chuoi la khong giong nhau.\n\n");
            }
            else if (flg == -1)
            {
                Console.Write("\nChuoi thu nhat ngan hon chuoi thu hai.\n\n");
            }
            else
            {
                Console.Write("\nChuoi thu nhat dai hon chuoi thu hai.\n\n");
            }

            Console.ReadKey();
        }
    }
}
