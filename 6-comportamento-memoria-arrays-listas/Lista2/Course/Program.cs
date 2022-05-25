using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int qty = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < qty; i++)
            {
                Console.WriteLine($"Emplyoee #{i + 1}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee employee = employees.Find(x => x.Id == id);

                if (employee == null)
                {
                    employees.Add(new Employee(id, name, salary));
                }
                else
                {
                    Console.WriteLine("Id is already in use!");
                }
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int employeeId = int.Parse(Console.ReadLine());

            Employee foundEmp = employees.Find(x => x.Id == employeeId);

            if (foundEmp != null)
            {
                Console.Write("Enter the percentage: ");
                double increasePercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                foundEmp.IncreaseSalary(increasePercentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
