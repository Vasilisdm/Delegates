using System;
namespace Delegates
{
    public class ProcessData
    {
        public void Process(int x, int y, BizRulesDelegate del)
        {
            var result = del(x, y);
            Console.WriteLine($"Result of the delegate process is: {result}");
        }

        public void ProcessFunc(int x, int y, Func<int,int,int> func)
        { 
            var result = func(x, y);
            Console.WriteLine($"Result of ProcessFunc {result}");
        }
    }
}
