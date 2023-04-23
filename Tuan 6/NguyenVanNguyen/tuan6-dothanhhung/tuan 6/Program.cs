using System;

namespace tuan6
{
    class tuan6
    {
        static void Main(string[] args)
        {
            string str1; //khai bao mot chuoi
            int i, l;

            Console.Write("\nSao chep chuoi trong C#:\n");
            Console.Write("------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str1 = Console.ReadLine();

            l = str1.Length;
            string[] str2 = new string[l]; //khai bao mot chuoi khac

            /* sao chep tung ky tu tu chuoi str1 sang chuoi str2*/
            i = 0;
            while (i < l)
            {
                string tmp = str1[i].ToString();
                str2[i] = tmp;
                i++;
            }
            Console.Write("\nIn chuoi ban dau: {0}\n", str1);
            Console.Write("In chuoi sao: {0}\n", string.Join("", str2));
            Console.Write("So ky tu da duoc sao chep: {0}\n\n", i);

            Console.ReadKey();
        }
    }
}