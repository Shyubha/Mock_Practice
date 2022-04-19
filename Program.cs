using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add  (new Employee(1,"Shubhankar",60000,"PUNE"));
            list.Add(new Employee(2, "Nilesh", 50000,"Solapur"));
            list.Add(new Employee(3, "Akash", 10000,"Nagpur"));
            list.Add(new Employee(5, "Amit", 40000, "PUNE"));
            list.Add(new Employee(6, "Akshay", 50000, "Pune"));
            list.Add(new Employee(7, "Parag", 10000, "Pune"));


            list.Insert(0, new Employee(22, "Amit", 40000,"Mumbai"));

            var x = from e in list
                    where e.Salary < 15000
                     select e;
            Console.WriteLine(x);
          

            var y = from e in list
                    where e.Name.StartsWith("a")
                    select e;
            foreach (Employee e in y)
            {
                Console.WriteLine(e);
            }

            var z = from e in list
                    orderby e.Salary descending
                    select e;
            foreach (Employee e in z)
            {
                Console.WriteLine(e);
            }
            var w = from e in list
                    where e.city.Contains("Pune")
                    orderby e.Salary ascending
                    select e;
            foreach (Employee e in w)
            {
                Console.WriteLine(e);
            }

            var V = from e in list
                    where e.Salary >= 25000 && e.Salary <= 40000
                    orderby e.Name descending
                    select e;
            foreach (Employee e in V)
            {
                Console.WriteLine(e);
            }

            foreach (Employee e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("____");
            Console.ReadLine();
            

        }
    }
}
