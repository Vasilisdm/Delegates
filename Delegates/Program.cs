using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            worker.WorkPerformed += delegate(object sender, WorkedPerformedEventArgs e)
            {
                Console.WriteLine($"Hours worked: {e.Hours}, Type of Work: {e.WorkType}");
            };

            worker.WorkCompleted += delegate (object sender, EventArgs e)
            {
                Console.WriteLine($"Work is done!");
            };

            worker.DoWork(8, WorkType.CodeWriting);
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
