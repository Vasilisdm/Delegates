using System;
namespace Delegates
{
    public delegate int WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, WorkType.WriteCode);
            }
            OnWorkedCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            if (WorkPerformed is WorkPerformedHandler del)
            {
                del(hours, workType);
            }
        }

        protected virtual void OnWorkedCompleted()
        {
            if (WorkCompleted is EventHandler del)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
