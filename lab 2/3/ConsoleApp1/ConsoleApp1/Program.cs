using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom.Compiler;
using System.Diagnostics.PerformanceData;

namespace firstTSK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] symbolCount = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,15,16,17 };
            int[] wordCount = new int[symbolCount.Length];
            string directory = Directory.GetCurrentDirectory() + "/";
            string fileName = "file.txt";
            using (StreamReader fs = new StreamReader($"{directory}{fileName}"))
            {
                while (!fs.EndOfStream)
                {
                    string[] temp = fs.ReadLine().Split(' ');
                    for (int i = 0; i < temp.Length; i++)
                    {
                        int count = temp[i].Count();
                        Console.WriteLine($"{temp[i]} : {count}");
                        for (int j = 0; j < symbolCount.Length; j++)
                            if (count == symbolCount[j])
                                wordCount[j]++;
                    }
                }
            }
            for (int i = 0; i < symbolCount.Length; i++)
            {
                Console.WriteLine($"{i + 1} буквенных : {wordCount[i]}");
            }
            Console.ReadKey();
        }
    }
}
