using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace myfirstproject.CollectionDemo
{
    class Marks_Info
        // Student has id, name and list of integer for marks 
    {
        public string S_Name;
        public int S_Marks;

        public Marks_Info(string S_Name, int S_Marks)
        {
            this.S_Name = S_Name;
            this.S_Marks = S_Marks;
        }
    }
    class StudentInfo5
    {
        public int s_id;
        public string s_name;
        public List<Marks_Info> s;

        public StudentInfo5(int s_id, string s_name, List<Marks_Info> s)
        {
            this.s_id = s_id;
            this.s_name = s_name;
            this.s = s;
        }
    }
    class CustomList5
    {
        static void Main(string[] args)
        {
            List<StudentInfo5> li = new List<StudentInfo5>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the Student Id :");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Student Name :");
                string Name = Console.ReadLine();
                List<Marks_Info> si = new List<Marks_Info>();
                Console.WriteLine("Enter the details of Subject_name & Marks");
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Enter the subject_name :");
                    string S_Name = Console.ReadLine();
                    Console.WriteLine("Enter the Marks of Subject :");
                    int S_Marks = int.Parse(Console.ReadLine());
                    si.Add(new Marks_Info(S_Name, S_Marks));
                }
                li.Add(new StudentInfo5(ID, Name, si));
            }
            Console.WriteLine("..............");
            foreach (var d in li)
            {
                Console.Write(d.s_id + "  " + d.s_name + "  ");
                foreach (var e in d.s)
                {
                    Console.Write("  " + e.S_Name + "  " + e.S_Marks);
                }
                Console.WriteLine();
            }
        }
    }
    class EmployeeDetails
    {
        public int E_id;
        public string E_Name;


        public EmployeeDetails(int E_id, string E_Name)
        {
            this.E_id = E_id;
            this.E_Name = E_Name;
        }
    }
    class DepartmentDetails
    {
        public int D_id;
        public string D_name;
        public List<EmployeeDetails> ed;

        public DepartmentDetails(int D_id, string D_name, List<EmployeeDetails> ed)
        {
            this.D_id = D_id;
            this.D_name = D_name;
            this.ed = ed;
        }
    }
    class CustomeList6
    {
        static void Main(string[] args)
        {
            List<DepartmentDetails> li = new List<DepartmentDetails>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the Department Id :");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Department Name :");
                string Name = Console.ReadLine();
                List<EmployeeDetails> em = new List<EmployeeDetails>();
                Console.WriteLine("Enter the Employee details ");
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("Enter the Employee ID :");
                    int E_id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Employee Name :");
                    string E_Name = Console.ReadLine();
                    em.Add(new EmployeeDetails(E_id, E_Name));
                }
                li.Add(new DepartmentDetails(ID, Name, em));
            }
            Console.WriteLine("..............");
            foreach (var d in li)
            {
                Console.Write(d.D_id + "  " + d.D_name + "  ");
                foreach (var e in d.ed)
                {
                    Console.Write("  " + e.E_id + "  " + e.E_Name);
                }
                Console.WriteLine();
            }
        }
    }
    class EmployeeDetails1
    {
        public int E_id;
        public string E_Name;


        public EmployeeDetails1(int E_id, string E_Name)
        {
            this.E_id = E_id;
            this.E_Name = E_Name;
        }
    }
    class DepartmentDetails1
    {
        public int D_id;
        public string D_name;
        public List<EmployeeDetails1> ed;

        public DepartmentDetails1(int D_id, string D_name, List<EmployeeDetails1> ed)
        {
            this.D_id = D_id;
            this.D_name = D_name;
            this.ed = ed;
        }
    }
    class CustomeList7
    {
        static void Main(string[] args)
        {
            List<DepartmentDetails1> li = new List<DepartmentDetails1>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the Department Id :");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Department Name :");
                string Name = Console.ReadLine();
                List<EmployeeDetails1> em = new List<EmployeeDetails1>();
                Console.WriteLine("Enter the Employee details ");
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("Enter the Employee ID :");
                    int E_id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Employee Name :");
                    string E_Name = Console.ReadLine();
                    em.Add(new EmployeeDetails1(E_id, E_Name));
                }
                li.Add(new DepartmentDetails1(ID, Name, em));
            }
            Console.WriteLine("..............");
            foreach (var d in li)
            {
                Console.Write(d.D_id + "  " + d.D_name + "  ");
                foreach (var e in d.ed)
                {
                    Console.Write("  " + e.E_id + "  " + e.E_Name);
                }
                Console.WriteLine();
            }
        }
    }
}
