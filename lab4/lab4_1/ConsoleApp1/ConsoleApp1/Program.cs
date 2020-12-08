using System;
using System.Collections.Generic;

public class Department
{
    private String name;
    private int count;
    private class Position
    {
       public String title;
       public int salary;
        public override string ToString()
           {
                return "Position: " + title + "\nSalary: " + salary + "$\n";
           }
    }
    private class Employee
    {
        public String name;
        public String surname;
        public int age;
        public String employeePosition;
        public int employeeSalary;
        public override string ToString()
        {
            return "Name" + name + "\nSurname: " + surname + "\nAge: " + age + "\nPosition: " + employeePosition + "\nSalary: " + employeeSalary + "\n";
        }
    }   
    List<Position> positions = new List<Position>();
    public void AddPosition(String _title, int _salary)
    {
        Position pos = new Position();
        pos.title = _title;
        pos.salary = _salary;
        positions.Add(pos);
    }

    public void show()
    {
        Console.WriteLine("ALL positions: ");
        Console.WriteLine();
        foreach(Position pos in positions)
        {
            Console.WriteLine($"{pos.ToString()}");
        }
        Console.WriteLine("ALL employees: ");
        Console.WriteLine();

        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.ToString()}");
        }
    }
    List<Employee> employees = new List<Employee>();
    public void AddEmployee (String _name, String _surname, int _age, string _employeePosition)
    {
        foreach(Position pos in positions)
        {
            if (pos.title == _employeePosition)
            {
                Employee employee = new Employee();
                employee.name = _name;
                employee.surname = _surname;
                employee.age = _age;
                employee.employeePosition = _employeePosition;
                employee.employeeSalary = pos.salary;
                employees.Add(employee);
            }
        }
    }

}



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.AddPosition("student", 2000);
            department.AddPosition("seller", 5000);
            department.AddEmployee("Artyom", "Novikevich", 20, "student");
            department.AddEmployee("Gena", "Bukin", 43, "seller");
            department.show();
        }
    }
}
