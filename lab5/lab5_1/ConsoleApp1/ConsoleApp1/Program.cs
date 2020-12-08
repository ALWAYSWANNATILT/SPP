using System;

namespace ConsoleApp1
{
    class Program
    {
        public interface IBuilding
        {
            public void Show();
            public void Set(string name, int age, string director);
        }
        public abstract class PublicBuilding : IBuilding
        {
            public string Name { get; set; }
            public int Age { get; set; }
            protected PublicBuilding(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public virtual void Show()
            {
                Console.WriteLine("Название театра: " + Name + ", возраст здания: " + Age);
            }
            public abstract void Set(string name, int age, string director);
        }
        public class Theatre : PublicBuilding
        {
            public string Director { get; set; }
            public Theatre(string name, int age, string director) : base(name, age)
            {
                Director = director;
            }
            public override void Show()
            {
                Console.WriteLine("Название театра: " + Name + ", возраст здания: "  + Age + ", Имя директора: " + Director);
            }
            public override void Set(string name, int age, string director)
            {
                Name = name;
                Age = age;
                Director = director;
            }
        }
        static void Main()
        {
            Theatre student1 = new Theatre("Брестский", 130, "Генадий");
            student1.Show();
            Console.WriteLine("Изменим название театра, возраст, директора театра");
            student1.Set("Театральный", 90, "Василий");
            student1.Show();
            Console.ReadKey();
        }
    }
}
