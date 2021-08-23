using System;
using System.Collections;
using System.Collections.Generic;
namespace CollectionInterfacesDemo
{
    class Employees : IEnumerable<Employee>
    {
        List<Employee> employeeList = new List<Employee>();     
        public Employee this[int index]
        {
            get
            {
                return employeeList[index];
            } set
            {
                employeeList.Add(value);
            }
        }
        public IEnumerator<Employee> GetEnumerator()
        {
            return employeeList.GetEnumerator();
        }             
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    internal class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
    }
}
