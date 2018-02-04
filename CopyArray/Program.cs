using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //a program in C# Sharp to copy the elements one array into another array. 

            int i, n;
            int[] a = new int[100];
            int[] b = new int[100];
            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                b[i] = a[i];
            }
            Console.Write("Second array after first array is copied: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", b[i]);
            }
            Console.ReadLine();
        }
    }
}
