using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            del1 += del2 + del3;
            int finalHours = del1(3, WorkType.WriteCode);
            Console.WriteLine($"Hours of the last delegate {finalHours}");

            //DoWork(del1);
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.FixBugs);
        }

        static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 Hours worked: {hours}, Work type: {workType}");
            return hours + 1;
        }

        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 Hours worked: {hours}, Work type: {workType}");
            return hours + 2;
        }

        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed3 Hours worked: {hours}, Work type: {workType}");
            return hours + 3;
        }
    }
}
