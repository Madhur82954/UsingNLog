using System;
using System.Collections.Generic;

namespace UsingNLog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 110,
                Name = "raj",
                Salary = 8000
            };
            Customer customer2 = new Customer()
            {
                ID = 111,
                Name = "riddhi",
                Salary = 8000
            };
            Customer customer3 = new Customer()
            {
                ID = 112,
                Name = "shrsha",
                Salary = 8000
            };
            List<Customer> cust = new List<Customer>();
            cust.Add(customer1);
            cust.Add(customer2);
            cust.Add(customer3);

            foreach (var customer in cust)
            {
                Console.WriteLine(customer.ID);
                Console.WriteLine(customer.Name);
                Console.WriteLine("---------------");
            }
            cust.Remove(customer2);
            foreach (var customer in cust)
            {
                Console.WriteLine(customer.ID);
                Console.WriteLine(customer.Name);
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("1", "raj");
            dic.Add("2", "ram");


            Dictionary<int, Customer> c = new Dictionary<int, Customer>();
            c.Add(1, customer1);
            c.Add(2, customer2);


            foreach (KeyValuePair<int, Customer> customer in c)
            {
                Console.WriteLine(customer.Key);
                Customer custdata = customer.Value;
                Console.WriteLine(custdata.ID);
                Console.WriteLine(custdata.Name);
                Console.WriteLine(custdata.Salary);
            }
        }
    }
}
