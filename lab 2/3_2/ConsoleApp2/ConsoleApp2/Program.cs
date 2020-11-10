using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom.Compiler;
using System.Diagnostics.PerformanceData;
using System.Runtime.CompilerServices;

namespace secondTSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory1 = Directory.GetCurrentDirectory() + @"\";
            string directory2 = @"D:\";
            string firstFile = "";
            string secondFile = "";
            Console.WriteLine("Введите команду:");
            string[] command = Console.ReadLine().Split(' ');
            bool fCheck = false, iCheck = false, nCheck = false;
            if (command.Length < 3)
                return;
            for (int i = 0; i < command.Length; i++)
            {
                if (i == 0)
                    if (command[i] != "cp")
                        return;
                if (command[i] == "-n")
                    nCheck = true;
                if (command[i] == "-f")
                    fCheck = true;
                if (command[i] == "-i")
                    iCheck = true;
                if (iCheck == true && nCheck == true)
                    iCheck = false;
                if (i == command.Length - 1)
                    secondFile += command[i];
                if (i == command.Length - 2)
                    firstFile += command[i];
            }
            FileInfo fileInf = new FileInfo(directory1 + firstFile);
            bool rewrite = true;
            string temp = "";
            if (fCheck)
            {
                if (nCheck)
                {
                    Console.WriteLine("Перезаписать файл(Y(англ)=да)");
                    temp = Console.ReadLine();
                    rewrite = false;
                }
                else
                {
                    if (iCheck)
                    {
                        Console.WriteLine("Перезаписать файл(Y(англ)=да)");
                        temp = Console.ReadLine();
                        if (temp == "Y")
                            rewrite = true;
                        else
                            rewrite = false;
                    }
                    else
                    {
                        rewrite = true;
                    }
                }
                try
                {
                    fileInf.CopyTo(directory2 + secondFile, rewrite);
                }
                catch (Exception ex)
                {
                    File.Delete(directory2 + secondFile);
                    fileInf.CopyTo(directory2 + secondFile, true);
                }
            }
            else
            {
                if (nCheck)
                {
                    Console.WriteLine("Перезаписать файл(Y(англ)=да)");
                    temp = Console.ReadLine();
                    rewrite = false;
                }
                else
                {
                    if (iCheck)
                    {
                        Console.WriteLine("Перезаписать файл(Y(англ)=да)");
                        temp = Console.ReadLine();
                        if (temp == "Y")
                            rewrite = true;
                        else
                            rewrite = false;
                    }
                    else
                    {
                        rewrite = true;
                    }
                }
                fileInf.CopyTo(directory2 + secondFile, rewrite);
            }
        }
    }
}
