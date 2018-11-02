using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Management_System
{
    class Worker:Bee
    {
        private string currentJob = "";
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        private const double additionalHoneyUnitsPerShift = .65;

        public Worker(string[] incomingJobs, double weight):base(weight)
        {
            this.jobsICanDo = incomingJobs;
        }

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public bool DoThisJob(string job, int shifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if(jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = shifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }

        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * additionalHoneyUnitsPerShift;
            return consumption;
        }
    }
}
