using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
       

       static void MaxMin(int[]array)
        {
            int max = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine("Max number: " + max);
            int min = array[0];
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine("Min number: " + min);

            int result = max - min;

          Console.WriteLine("Difference between min and man number:" + result + "\n");
       }
     
  
        static void removeElement(int[]array)
        {
            int n = Convert.ToInt32(Console.ReadLine()); 
            int[] array2 = new int[11];
            Array.Copy(array, array2, 10);
            for (int i = n; i < 10; i++)
            {
                array[i] = array2[i + 1];
            } 

            foreach (int a in array)
            {
                Console.Write(a);
            }
            Console.WriteLine("\n");
        }

        static void RandomString()
        {
            Console.WriteLine("Enter size of string:");
            int length = int.Parse(Console.ReadLine());
            string s = "ç¼14∉∂ϖ4ÍheàΘΩqweartyomπϖfv∫";
            string fin = "";
            Random ran = new Random();
            for (int i = 0; i < length; i++)
            {
                int num = length;
                int a = ran.Next(0,28);
                fin +=  s.ElementAt(a);

            }
            Console.WriteLine("Random string: " + fin);
            fin = Regex.Replace(fin, @"[^\u0000-\u007F]+", string.Empty);
            Console.WriteLine("finite result: " + fin);
        }

    static void Main(string[] args)
        {

            Console.WriteLine("First task:");
            int[] array = new int[10];
            Console.WriteLine("Enter your 10 numbers:");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            MaxMin(array);
            Console.WriteLine("Second task:");
            Console.WriteLine("Write element which u want delete:");
            removeElement(array);
            RandomString();
            Console.ReadKey();
        }
    }
}
