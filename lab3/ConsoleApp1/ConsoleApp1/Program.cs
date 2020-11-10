using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
   
        {
            Mnoj first = new Mnoj();
            Mnoj second = new Mnoj();

            Console.WriteLine(first.Equals(second));
            first.Equals(second);
            first.Add(2);
            first.Connect(second);
            first.Search(1);
            first.Show();

            Console.ReadKey();
        }
    }
    public class Mnoj
    { 
        public int[] mnojestvo;
 
        public Mnoj()
        { 
            mnojestvo = new int[0];
            Console.WriteLine("Enter number/ q to stop: ");
            string temp = "";
            int Temp, size = 0;
            while (true)
            {
                temp = Console.ReadLine();
                bool check = int.TryParse(temp, out Temp);
                if (check)
                {
               
                    Array.Resize(ref mnojestvo, ++size);
                    mnojestvo[size-1] = Temp;
                }
                if (temp == "q") break;

            }
        }


        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            Mnoj temp = obj as Mnoj;//проверка на принадлежность классу Equila
            if (mnojestvo.Length != temp.mnojestvo.Length)
                return false;
            for (int i = 0; i < mnojestvo.Length; i++)
            {
                if (mnojestvo[i] != temp.mnojestvo[i])
                    return false;
            }
            return true;
        }


        public void Show()
        {
            for (int i = 0; i < mnojestvo.Length; i++)
            {
                Console.WriteLine($"{mnojestvo[i]}");
            }
        }

        public void Add(int num)
        {
            for (int i = 0; i < mnojestvo.Length; i++)
            {
                if(mnojestvo[i] == num)
                {
                    Console.WriteLine("Данное число есть в множестве");
                    return;
                }
                
            }
            Array.Resize(ref mnojestvo, mnojestvo.Length + 1);
            mnojestvo[mnojestvo.Length - 1] = num;

        }

        public void Delete(int number)
        {
            List<int> list = mnojestvo.ToList<int>();
            list.RemoveAt(number - 1);
            mnojestvo = list.ToArray();
        }

        public void Connect(Mnoj mnoj)
        {
            bool check;    
            int[] arr = mnojestvo;
            for (int i = 0; i < mnoj.mnojestvo.Length; i++)
            {   
                check = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (mnoj.mnojestvo[i] == arr[j])
                        check = false;
                }
                if (check) 
                { 
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = mnoj.mnojestvo[i];
                }

            }
            Array.Sort(arr);
            mnojestvo = arr;
        } 

        public void Search(int number)
        {
            bool check = false;
            for (int i = 0; i < mnojestvo.Length; i++)
            {
               if(mnojestvo[i] == number)    
                {
                    check = true; break;
                }
               
            }
            if (check) Console.WriteLine("сИМВОЛ ЕСТЬ!!!!");
            else Console.WriteLine("СИМВОЛА НЕТ((");
        }

    }

}
