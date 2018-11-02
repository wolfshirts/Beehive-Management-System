namespace Beehive_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.shiftsValueControl = new System.Windows.Forms.NumericUpDown();
            this.nextShiftButton = new System.Windows.Forms.Button();
            this.assignmentButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsValueControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shifts";
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(9, 61);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(121, 21);
            this.workerBeeJob.TabIndex = 3;
            // 
            // shiftsValueControl
            // 
            this.shiftsValueControl.Location = new System.Drawing.Point(189, 61);
            this.shiftsValueControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftsValueControl.Name = "shiftsValueControl";
            this.shiftsValueControl.Size = new System.Drawing.Size(120, 20);
            this.shiftsValueControl.TabIndex = 4;
            this.shiftsValueControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nextShiftButton
            // 
            this.nextShiftButton.Location = new System.Drawing.Point(409, 19);
            this.nextShiftButton.Name = "nextShiftButton";
            this.nextShiftButton.Size = new System.Drawing.Size(314, 156);
            this.nextShiftButton.TabIndex = 5;
            this.nextShiftButton.Text = "Work the Next Shift";
            this.nextShiftButton.UseVisualStyleBackColor = true;
            this.nextShiftButton.Click += new System.EventHandler(this.nextShiftButton_Click);
            // 
            // assignmentButton
            // 
            this.assignmentButton.Location = new System.Drawing.Point(9, 106);
            this.assignmentButton.Name = "assignmentButton";
            this.assignmentButton.Size = new System.Drawing.Size(306, 23);
            this.assignmentButton.TabIndex = 6;
            this.assignmentButton.Text = "Assign this job to a bee";
            this.assignmentButton.UseVisualStyleBackColor = true;
            this.assignmentButton.Click += new System.EventHandler(this.assignmentButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.assignmentButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nextShiftButton);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.shiftsValueControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 237);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(12, 255);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.Size = new System.Drawing.Size(729, 181);
            this.reportTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 448);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management System EE";
            ((System.ComponentModel.ISupportInitialize)(this.shiftsValueControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.NumericUpDown shiftsValueControl;
        private System.Windows.Forms.Button nextShiftButton;
        private System.Windows.Forms.Button assignmentButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox reportTextBox;
    }
}

