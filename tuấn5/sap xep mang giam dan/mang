using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMaxAndMinMatrix2D
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 3, y = 5;
            int min, max;
            int[,] arr = new int[x, y] { 
                { 10, 50, 13, 80, 40 }, 
                { 1, 250, 65, 28, 15 }, 
                { 12, 17, 45, 20, 6 }
            };

            //Declare two variables max and min to store maximum and minimum. 
            //Assume first array element as maximum and minimum both, say max = arr[0,0] and min = arr[0,0]
            min = arr[0, 0];
            max = arr[0, 0];

            // Iterate through array to find maximum and minimum element in array.
            //Inside loop for each array element check for maximum and minimum.
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //Assign current array element to max, if (arr[i,j] > max)
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }

                    //Assign current array element to min if if (arr[i,j] < min)
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            //Print Array Elements
            Console.Write("Array Elements\n");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(arr[i, j] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Print max and min number
            Console.WriteLine("Maximum element:" + max);
            Console.WriteLine("Minimum element:" + min);
            Console.ReadLine();
        }
    }
}
