using System;
using System.Collections.Generic;
using System.Text;


namespace myfirstproject.CollectionDemo
{
    class EmployeeList
        // write code to create list of employee id, name, salary and display only those employee whose salary is greater than 25000
    {
        public int id;
        public string name;
        public int salary;

        public EmployeeList(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }

    class CustomList
    {
        static void Main(string[] args)
        {
            List<EmployeeList> li = new List<EmployeeList>();
            li.Add(new EmployeeList(101,"Shreya",35000));
            li.Add(new EmployeeList(102, "Neha", 18000));
            li.Add(new EmployeeList(103, "Snehal", 20000));
            li.Add(new EmployeeList(104, "Samiksha", 28000));
            li.Add(new EmployeeList(105, "Shweta", 30000));
            foreach (EmployeeList e in li)
            {
                if (e.salary > 25000)
                {
                    Console.WriteLine(e.id+"  "+e.name+"  "+e.salary);
                }
            }
        }
    }
    class StudentList
    {
        public int id;
        public string name;

        public StudentList(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class CustomList2
    {
        static void Main(string[] args)
        {
            List<StudentList> li = new List<StudentList>();
            li.Add(new StudentList(101, "Shreya"));
            li.Add(new StudentList(102, "Neha"));
            li.Add(new StudentList(103, "Snehal"));
            foreach (StudentList s in li)
            {
                    Console.WriteLine(s.id + "  " + s.name);
                
            }
        }
    }
    class SortedListEx
        /* write code to create a sorted list which contain int type of key and string type of value
        if key is even then the display the entry */
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Pune");
            sl.Add(2, "Mumbai");
            sl.Add(3, "Nagpur");
            sl.Add(4, "Banglore");
            sl.Add(5, "Chennai");
            sl.Add(6, "Hyderabad");
            sl.Add(7, "Nashik");
            sl.Add(8, "Aurangabad");
            sl.Add(9, "Goa");
            sl.Add(10, "Ahmedabad");
            foreach(var myentry in sl)
            {
                if(myentry.Key%2==0)
                {
                    Console.WriteLine(myentry.Key+"  "+myentry.Value);
                }
            }
        }
    }
    class SortedListEx2
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "Pune");
            sl.Add(2, "Mumbai");
            sl.Add(3, "Nagpur");
            sl.Add(4, "Banglore");
            sl.Add(5, "Chennai");
            foreach(var myentry in sl)
            {
                Console.WriteLine(myentry.Key+"  "+myentry.Value);
            }
            Console.WriteLine(".............");
            Console.WriteLine(sl[1]);
            Console.WriteLine("...........");
            sl[1] = "Ahmedabad";
            foreach (var myentry in sl)
            {
                Console.WriteLine(myentry.Key + "  " + myentry.Value);
            }
            Console.WriteLine(".......All Keys..........");
            IList<int> al = sl.Keys;
            foreach(var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(".......All Values..........");
            IList<string> al2 = sl.Values;
            foreach (var v in al2)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("........Delete Entry........");
            sl.Remove(1);
            foreach (var myentry in sl)
            {
                Console.WriteLine(myentry.Key + "  " + myentry.Value);
            }
            Console.WriteLine(".............."+sl.ContainsKey(1));
            Console.WriteLine("............."+sl.ContainsValue("Pune"));
            Console.WriteLine(sl.Count);
        }
    }
    class EmployeeList1 : IComparable
        /* create employee class employee has id, name, salary create list of employee
           and sort it on the basis of salary in descending order */
    { 
        public int id;
        public string name;
        public int salary;

        public EmployeeList1(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public int CompareTo(Object obj)
        {
            EmployeeList1 e1 = (EmployeeList1)obj;
            return e1.salary - this.salary;
        }
    }

    class CustomList1
    {
        static void Main(string[] args)
        {
            List<EmployeeList1> li = new List<EmployeeList1>();
            li.Add(new EmployeeList1(101, "Shreya", 35000));
            li.Add(new EmployeeList1(102, "Neha", 18000));
            li.Add(new EmployeeList1(103, "Snehal", 20000));
            li.Add(new EmployeeList1(104, "Samiksha", 28000));
            li.Add(new EmployeeList1(105, "Shweta", 30000));
            foreach (EmployeeList1 e1 in li)
            {
                Console.WriteLine(e1.id+"  "+e1.name+"  "+e1.salary);
            }
            Console.WriteLine(".............");
            li.Sort();
            foreach (EmployeeList1 e1 in li)
            {
                Console.WriteLine(e1.id + "  " + e1.name + "  " + e1.salary);
            }
        }
    }
    class CarList : IComparable
        /* crate a car class car has model_no. , car_name, car_price and car_color create a list of car and
        sort the list on the basis of car_price in descending order if price is same then sort on the basis of car_name
        and if car_name is also same then sort on the basis of model_no. */
    {
        public int model_no;
        public string car_name;
        public int car_price;
        public string car_color;

        public CarList(int model_no, string car_name, int car_price, string car_color)
        {
            this.model_no = model_no;
            this.car_name = car_name;
            this.car_price = car_price;
            this.car_color = car_color;
        }
        public int CompareTo(Object obj)
        {
            CarList c = (CarList)obj;
            if(this.car_price==c.car_price)
            {
                return c.car_name.CompareTo(this.car_name);
                {
                    if (this.car_name==c.car_name)
                    {
                        return c.model_no - this.model_no;
                    }
                }
            }
            else
            {
                return c.car_price - this.car_price;
            }
        }

    }
    class CustomList3
    {
        static void Main(string[] args)
        {
            List<CarList> li = new List<CarList>();
            li.Add(new CarList(101, "Swift", 850000, "White"));
            li.Add(new CarList(102, "Alto", 758000, "Black"));
            li.Add(new CarList(103, "BMW", 2800000, "Gray"));
            li.Add(new CarList(104, "Mercedes", 2600000, "Silver"));
            li.Add(new CarList(105, "Wagonar", 930000, "Red"));
            foreach (CarList c in li)
            {
                Console.WriteLine(c.model_no + "  " + c.car_name + "  " + c.car_price+"  "+c.car_color);
            }
            Console.WriteLine(".............");
            li.Sort();
            foreach (CarList c in li)
            {
                Console.WriteLine(c.model_no + "  " + c.car_name + "  " + c.car_price + "  " + c.car_color);
            }
        }
    }
    class CarList1
    {
        public int model_no;
        public string car_name;
        public int car_price;

        public CarList1(int model_no, string car_name, int car_price)
        {
            this.model_no = model_no;
            this.car_name = car_name;
            this.car_price = car_price;
        }
    }
    class ComparerList
    {
        static void Main(string[] args)
        {
            List<CarList1> li = new List<CarList1>();
            li.Add(new CarList1(101, "Swift", 850000));
            li.Add(new CarList1(102, "Alto", 758000));
            li.Add(new CarList1(103, "BMW", 2800000));
            li.Add(new CarList1(104, "Mercedes", 2600000));
            li.Add(new CarList1(105, "Wagonar", 930000));
            foreach (CarList1 c in li)
            {
                Console.WriteLine(c.model_no + "  " + c.car_name + "  " + c.car_price);
            }
            Console.WriteLine(".............");
            li.Sort(new SortbyPrice());
            foreach (CarList1 c in li)
            {
                Console.WriteLine(c.model_no + "  " + c.car_name + "  " + c.car_price);
            }
            Console.WriteLine("..............");
            li.Sort(new SortbyName());
            foreach (CarList1 c in li)
            {
                Console.WriteLine(c.model_no + "  " + c.car_name + "  " + c.car_price);
            }
            Console.WriteLine("..............");
            li.Sort(new SortbyModelNo());
            foreach (CarList1 c in li)
            {
                Console.WriteLine(c.model_no + "  " + c.car_name + "  " + c.car_price);
            }
        }
    }
    class SortbyPrice : IComparer<CarList1>
    {
        int IComparer<CarList1>.Compare(CarList1 x, CarList1 y)
        {
            return y.car_price - x.car_price;
        }
    }
    class SortbyName : IComparer<CarList1>
    {
        int IComparer<CarList1>.Compare(CarList1 x, CarList1 y)
        {
            return y.car_name.CompareTo(x.car_name);
        }
    }
    class SortbyModelNo : IComparer<CarList1>
    {
        int IComparer<CarList1>.Compare(CarList1 x, CarList1 y)
        {
            return y.model_no - x.model_no;
        }
    }
    class TrainInfo
    /*  create a list of train, train id, train name and no. of seats. arrange the train as per the no. of seats 
     if the no. of seats are same then the sort on the basis of train name  */
    {
        public int train_id;
        public string train_name;
        public int no_of_seats;

        public TrainInfo(int train_id, string train_name, int no_of_seats)
        {
            this.train_id = train_id;
            this.train_name = train_name;
            this.no_of_seats = no_of_seats;
        }
    }
    class No_Of_Seats : IComparer<TrainInfo>
    {
        int IComparer<TrainInfo>.Compare(TrainInfo x, TrainInfo y)
        {
            if(x.no_of_seats==y.no_of_seats)
            {
                return y.train_name.CompareTo(x.train_name);
            }
            return x.no_of_seats - y.no_of_seats;
        }
    }
    class ComparerList2
    {
        static void Main(string[] args)
        {
            List<TrainInfo> li = new List<TrainInfo>();
            li.Add(new TrainInfo(10201, "Azadhind", 850));
            li.Add(new TrainInfo(10321, "Nagpur-Pune", 758));
            li.Add(new TrainInfo(10832, "Gitanjali", 800));
            li.Add(new TrainInfo(10540, "Hawrah-Exp", 753));
            li.Add(new TrainInfo(10750, "kajipeth", 850));
            foreach (TrainInfo t in li)
            {
                Console.WriteLine(t.train_id + "  " + t.train_name + "  " + t.no_of_seats);
            }
            Console.WriteLine(".............");
            li.Sort(new No_Of_Seats());
            foreach (TrainInfo t in li)
            {
                Console.WriteLine(t.train_id + "  " + t.train_name + "  " + t.no_of_seats);
            }
        }
    }
}
