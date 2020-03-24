using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // number to arr lenght
            Console.WriteLine("helo world ");
            Console.WriteLine("enter your length the arr : ");
            int longer = Convert.ToInt32(Console.ReadLine());
            //number to *
            Console.WriteLine("enter your many to zoom : ");
            //convert string to int
            int zoom = Convert.ToInt32(Console.ReadLine());
            //make a arr
            int[] arr = new int[longer];
            Console.WriteLine($"number of lengh :{longer} , number of zoom : {zoom}");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * zoom;
                Console.Write(arr[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
