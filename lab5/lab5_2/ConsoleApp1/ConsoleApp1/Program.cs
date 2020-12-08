using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        abstract class СompanyEmployee
        {
            protected int money = 0;
            protected int zp;
            public СompanyEmployee()
            {

            }
            public abstract void SetZp(int zp);
            public abstract void GiveZp();
            public abstract void ShowMoney();
        }

        class Manager : СompanyEmployee
        {
            public override void SetZp(int zp)
            {
                this.zp = zp;
            }
            public override void GiveZp()
            {
                money += zp;
            }
            public override void ShowMoney()
            {
                Console.WriteLine($"Общая сумма начислений:{money}, Зарплата:{zp}");
            }
        }
        class Analyst : СompanyEmployee
        {
            public override void SetZp(int zp)
            {
                this.zp = zp;
            }
            public override void GiveZp()
            {
                money += zp;
            }
            public override void ShowMoney()
            {
                Console.WriteLine($"Общая сумма начислений:{money}, Зарплата:{zp}");
            }
        }
        class Programmer : СompanyEmployee
        {
            public override void SetZp(int zp)
            {
                this.zp = zp;
            }
            public override void GiveZp()
            {
                money += zp;
            }
            public override void ShowMoney()
            {
                Console.WriteLine($"Общая сумма начислений:{money}, Зарплата:{zp}");
            }
        }
        class Tester : СompanyEmployee
        {
            public override void SetZp(int zp)
            {
                this.zp = zp;
            }
            public override void GiveZp()
            {
                money += zp;
            }
            public override void ShowMoney()
            {
                Console.WriteLine($"Общая сумма начислений:{money}, Зарплата:{zp}");
            }
        }
        class Designer : СompanyEmployee
        {
            public override void SetZp(int zp)
            {
                this.zp = zp;
            }
            public override void GiveZp()
            {
                money += zp;
            }
            public override void ShowMoney()
            {
                Console.WriteLine($"Общая сумма начислений:{money}, Зарплата:{zp}");
            }
        }
        class Accountant : СompanyEmployee
        {
            public override void SetZp(int zp)
            {
                this.zp = zp;
            }
            public override void GiveZp()
            {
                money += zp;
            }
            public override void ShowMoney()
            {
                Console.WriteLine($"Общая сумма начислений:{money}, Зарплата:{zp}");
            }
        }

        static void Main(string[] args)
        {
            List<СompanyEmployee> list = new List<СompanyEmployee>();

            СompanyEmployee tester = new Tester();
            tester.SetZp(500);
            list.Add(tester);

            СompanyEmployee accountant = new Accountant();
            accountant.SetZp(300);
            list.Add(accountant);

            СompanyEmployee designer = new Designer();
            designer.SetZp(200);
            list.Add(designer);

            СompanyEmployee programmer = new Programmer();
            programmer.SetZp(100);
            list.Add(programmer);

            Console.WriteLine("До выдачи зарплаты:");
            foreach (СompanyEmployee emp in list)
            {
                emp.ShowMoney();
            }


            foreach (СompanyEmployee emp in list)
            {
                emp.GiveZp();
            }
            Console.WriteLine("После выдачи зарплаты:");
            foreach (СompanyEmployee emp in list)
            {
                emp.ShowMoney();
            }

            foreach (СompanyEmployee emp in list)
            {
                emp.GiveZp();
            }
            Console.WriteLine("После ещё одной выдачи зарплаты:");
            foreach (СompanyEmployee emp in list)
            {
                emp.ShowMoney();
            }
            Console.ReadKey();
        }
    }
}
