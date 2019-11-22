using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using Course.Entities;

namespace Course
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>(); ;

            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));

                    }
                }

                var emails = list.Where(p => p.Salary > 2000.00).OrderBy(p => p.Email).Select(p => p.Email);
                Console.WriteLine("Email of people whose salary is more than 2000.00:");
                foreach (string name in emails)
                {
                    Console.WriteLine(name);
                }

                var sumSalary = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumSalary.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

        }

    }
}