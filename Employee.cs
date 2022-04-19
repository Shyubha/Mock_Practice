using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Employee
    {
        public int Id
        {
            get { return id;}
            set { id = value;}
        }
        public string Name
        {
            get { return name;}
            set { name = value;}
        }
        public int Salary
        {
            get{ return salary;}
            set { salary = value;}
        }
        public string city
        {
            get { return city;}

        }

        int id;
        string name;
        int salary;
        String City;
        public Employee()
        {
            
        }
        public Employee(int id,string name,int Salary,string city)
        {
            this.id = id;
            this.name = name;
            this.salary = Salary;
            this.City = city;

            
        }
        public override string ToString()
        {
            return id + " " + name + " " + salary + " " +city;  
            
        }

    }
}
