using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE: Print the Sum of numbers
            Console.WriteLine("Sum of numbers: ");
            Console.WriteLine(numbers.Sum());

            //DONE: Print the Average of numbers
            Console.WriteLine("Average of numbers: ");

            Console.WriteLine(numbers.Average());

            //Done: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order: ");

            numbers.OrderBy(number => number).ToList().ForEach(number => Console.WriteLine(number));

            //DONE: Order numbers in descending order and print to the console
            Console.WriteLine("Numbers in descending order: ");
            var orderByDesc = numbers.OrderByDescending(number => number);
            numbers.OrderByDescending(number => number).ToList().ForEach(numbers => Console.WriteLine(numbers));
            //DONE: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6: ");
            numbers.Where(number => number > 6).ToList().ForEach(x => Console.WriteLine(x));
            //DONE: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Prints only 4 numbers");
            var print4 = numbers.OrderBy(x => x).Take(4);
            foreach (var number in print4)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            //DONE: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Changing the value of index 4.");
            numbers.SetValue(38, 4);
            
            foreach (var number in orderByDesc)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("All names that start with C or S: ");
            employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S'))
                     .OrderBy(x => x.FirstName)
                     .ToList()
                     .ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over 26 years old.");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"Full Name: {x.FullName} Age: {x.Age}"));
            //DONE: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of YOE: ");
            var employeeSum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(employeeSum);
            Console.WriteLine("Average of YOE: ");
            double employeeAvg = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(employeeAvg);
            //DONE: Add an employee to the end of the list without using employees.Add()
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "John";
            newEmployee.LastName = "Sourdough";
            newEmployee.YearsOfExperience = 7;
            newEmployee.Age = 35;
            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
