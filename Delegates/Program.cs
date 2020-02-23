using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.WorkPerformed += new WorkPerformedHandler(Worker_WorkPerformed);
            worker.DoWork(8, WorkType.WriteCode);
        }

        static void Worker_WorkPerformed(object sender, WorkedPerformedEventArgs e)
        {
            Console.WriteLine($"Hours worked: {e.Hours}, Type of Work: {e.WorkType}");
        }
    }
}
