﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace employee
{
internal class Employee
    {
string Name;
    int Age;
    decimal Salary;

    public Employee(string name, int age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Age: " + Age);
        Console.WriteLine("Employee Salary: " + Salary);
    }
    static void Main(string[] args)
    {
        Employee e = new Employee("Mitali", 22, 60000);
        e.DisplayDetails();
        Console.ReadKey();
    }
}
}


