﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { City = "Phoenix", FirstName = "John", LastName = "Doe", ID = 1 },
                new Customer { City = "Phoenix", FirstName = "Jane", LastName = "Doe", ID = 500 },
                new Customer { City = "Seattle", FirstName = "Suki", LastName = "Pizzoro", ID = 3 },
                new Customer { City = "New York City", FirstName = "Michele", LastName = "Smith", ID = 4 },
            };

            var pheonixCustomers = customers.Where(c => c.City == "Pheonix" && c.ID < 500).OrderBy(c => c.FirstName);

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer's firstName: {customer.FirstName}");
            }

            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;
            var processData = new ProcessData();
            processData.Process(3, 5, addDel);

            Func<int, int, int> funcAddition = (x, y) => x + y;
            Func<int, int, int> funcMultiplication = (x, y) => x * y;

            processData.ProcessFunc(2, 3, funcAddition);

            Worker worker = new Worker();
            worker.WorkPerformed += (sender, e) => Console.WriteLine($"Hours worked: {e.Hours}, Type of Work: {e.WorkType}");

            worker.WorkCompleted += delegate (object sender, EventArgs e)
            {
                Console.WriteLine($"Work is done!");
            };

            //worker.DoWork(8, WorkType.CodeWriting);
        }

        //static void Worker_WorkPerformed(object sender, WorkedPerformedEventArgs e)
        //{
        //    Console.WriteLine($"Hours worked: {e.Hours}, Type of Work: {e.WorkType}");
        //}

        //static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine($"Work is done!");
        //}
    }
}
