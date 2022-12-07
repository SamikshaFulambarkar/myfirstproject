using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstproject.OOPS_Ex
{
    class Department
    {
        int deptId;
        string deptName;

        public Department(int deptId, string deptName)
        {
            this.deptId = deptId;
            this.deptName = deptName;
        }
        public void DisplayDepartment()
        {
            Console.WriteLine(deptId + " " + deptName);
        }
    }
    class Employee
    {
        int empId;
        string empName;
        Department dept;

        public Employee(int empId, string empName, Department dept)
        {
            this.empId = empId;
            this.empName = empName;
            this.dept = dept;
        }
        public void DisplayEmployee()
        {
            Console.WriteLine(empId + " " + empName + " ");
            dept.DisplayDepartment();
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "Dhruv", new Department(1, "Mechanical"));
            e.DisplayEmployee();
        }
    }
}
