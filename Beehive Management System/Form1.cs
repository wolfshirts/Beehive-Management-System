using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Management_System
{
    public partial class Form1 : Form
    {
        Queen queen;

        public Form1()
        {
            InitializeComponent();

            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring",
                                                   "Hive maintenance", "Sting patrol"});

            queen = new Queen(workers);
        }

        private void nextShiftButton_Click(object sender, EventArgs e)
        {
            reportTextBox.Text = queen.WorkTheNextShift();
        }

        private void assignmentButton_Click(object sender, EventArgs e)
        {
            if(queen.AssignWork(workerBeeJob.Text, (int)shiftsValueControl.Value) == false)
            {
                MessageBox.Show("No workers are available to do the job '" + workerBeeJob.Text + "'", "The queen bee says...");
            }
            else
            {
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " + shiftsValueControl.Value + " shifts", 
                    "The queen bee says...");
            }
        }
    }
}
