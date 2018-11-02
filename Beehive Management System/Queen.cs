using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Management_System
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        public Queen(Worker[] work)
        {
            workers = work;
        }

        public bool AssignWork(string work, int shifts)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if(workers[i].DoThisJob(work, shifts))
                {
                    return true;
                }
            }
            return false;
        }
        
        public string WorkTheNextShift()
        {
            this.shiftNumber++;
            string report = "Report for shift #" + this.shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                {
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                }
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is not working\r\n";
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob +
                            "' for " + workers[i].ShiftsLeft + " more shifts\r\n";

                    }
                    else
                    {
                        report += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob + "' after this shift\r\n";
                    }
                }
            }
            return report;
        }
    }
}
