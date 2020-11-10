using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;


namespace secondPart
{
    class Program
    {
        static void Main(string[] args)
        {
            Disk disk = new Disk();
            disk.Add(new File(100000, "asd", "txt"));
            disk.Add(new File(100000, "zxc", "txt"));
            disk.Add(new File(500000, "xcv", "txt"));
            disk.Add(new File(200000, "cvb", "txt"));
            disk.Show();
            disk.Delete("asd");
            disk.Delete("xcv");
            disk.Add(new File(400000, "xvcb", "txt"));
            disk.Show();
        }
    }
    public class Disk
    {
        List<File> Files = new List<File>();
        const int Size = 1440000;

        public Disk() { } 
        public void Delete(string _name)
        {
            for(int i = 0; i < Files.Count; i++)
            {
                if (Files[i].name == _name) Files.RemoveAt(i);
            }
        }
        public void Show()
        {
            foreach(File file in Files)
            {
                Console.WriteLine($" Имя Файла {file.name}| РАзмер {file.size}| Расширениe {file.exp}| НАчало и Конец {file.Psize} {file.Nsize}");
            }
        }
        public void Add(File file)
        {
            int size = file.size;
            int temp = 0;
            if(Files.Count == 0)
            {
                file.Psize = 0;
                file.Nsize = file.Psize + file.size;
                Files.Add(file);
                Console.WriteLine("Файл успешно создан");
                return;
            }
            temp = Files[0].Psize;
            for (int i = 0; i < Files.Count; i++)
            {
                if (i == Files.Count - 1)
                {
                    if (Files[i].Psize - temp > size) 
                    {
                       
                        file.Psize = temp;
                        file.Nsize = temp + file.size;
                
                        Files.Insert(i, file);

                        Console.WriteLine("Файл успешно создан");
                        return;
                    } 
                    int TempSize = Size - Files[i].Nsize;
                    if (file.size < TempSize)
                   {
                        file.Psize = Files[i].Nsize + 1;
                        file.Nsize = file.Psize + file.size;
                        Files.Add(file);
                        Console.WriteLine("Файл успешно создан");
                                           
                    }
                    else Console.WriteLine("Нет места дял файла");
                    return;
                }
                if (Files[i].Psize == temp)
                {
                    temp = Files[i].Nsize + 1;
                    continue;
                }
                else
                {
                    if (Files[i].Psize - temp > size)
                    {
                        //file.Psize = Files[i].Nsize;
                        file.Psize = temp;
                        file.Nsize = temp + file.size;
                        // file.Nsize = file.Psize + file.size;
                        Files.Insert(i , file);

                        Console.WriteLine("Файл успешно создан");
                        return;
                    }
                    
                    else
                    {
                        temp = Files[i].Nsize + 1;
                    }
                }             
            }
      
        }
        public void SizeCheck()
        {
            int curSize = 0;
            foreach (File file in Files)
            {
                curSize += file.GetSize();
                if (curSize > Size) Console.WriteLine("Нет места");
            }
        }
    }
    public class File
    {
        public string name;
        public string exp;
        public int size;
        public int Psize;
        public int Nsize;
        public File(int size, string name, string exp) 
        { 
            this.size = size;
            this.name = name;
            this.exp = exp;
        }
        public int GetSize()
        {
            return size;
        }
       
    }

}



// SPS ZA LABU PAPAWA