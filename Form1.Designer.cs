namespace ReportPage
{
    partial class ReportPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.machineListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.describeIssue = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "Availability";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 101);
            this.button3.TabIndex = 2;
            this.button3.Text = "History";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(629, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 101);
            this.button4.TabIndex = 3;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1505, 100);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.machineListBox);
            this.panel2.Controls.Add(this.locationListBox);
            this.panel2.Controls.Add(this.submitButton);
            this.panel2.Controls.Add(this.describeIssue);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(169, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 631);
            this.panel2.TabIndex = 5;
            // 
            // machineListBox
            // 
            this.machineListBox.FormattingEnabled = true;
            this.machineListBox.ItemHeight = 31;
            this.machineListBox.Location = new System.Drawing.Point(59, 217);
            this.machineListBox.Name = "machineListBox";
            this.machineListBox.Size = new System.Drawing.Size(219, 66);
            this.machineListBox.TabIndex = 6;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 31;
            this.locationListBox.Location = new System.Drawing.Point(59, 102);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(218, 66);
            this.locationListBox.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(118, 515);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(285, 97);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // describeIssue
            // 
            this.describeIssue.Location = new System.Drawing.Point(59, 326);
            this.describeIssue.Name = "describeIssue";
            this.describeIssue.Size = new System.Drawing.Size(389, 158);
            this.describeIssue.TabIndex = 3;
            this.describeIssue.Text = "Describe the issue...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(602, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 160);
            this.label1.TabIndex = 1;
            this.label1.Text = "A place to report any broken \r\nmachines, operates similarly to \r\na normal FMS wor" +
    "k ticket. User can input\r\nlocation, machine number, and \r\ndescribe the issue.\r\n";
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(202)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1516, 962);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReportPage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RichTextBox describeIssue;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.ListBox machineListBox;
    }
}

