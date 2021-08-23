using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInterfacesDemo
{
    class Program
    {
        // This program demos. about IEnumerable.
        static void Main(string[] args)
        {
            Employee emp1 = new Employee {EmpCode=100,EmpName="Scott",Email="scott@gmail.com" };
            Employee emp2 = new Employee {EmpCode=101,EmpName="Tiger",Email="tiger@gmail.com" };

            Employees employees = new Employees();
            employees[0] = emp1;
            employees[1] = emp2;

            foreach(var employee in employees)
            {
                Console.WriteLine("Code={0}\tName={1}\tEmail={2}",employee.EmpCode,employee.EmpName,employee.Email);
            }

           
            Console.ReadLine();
        }
    }
}
