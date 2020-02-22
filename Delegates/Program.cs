using System;

namespace Delegates
{

    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            del1 += del2 + del3;
            del1(3, WorkType.WriteCode);

            //DoWork(del1);
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.FixBugs);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed1 Hours worked: {hours}, Work type: {workType}");
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed2 Hours worked: {hours}, Work type: {workType}");
        }

        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine($"WorkPerformed3 Hours worked: {hours}, Work type: {workType}");
        }
    }
}
