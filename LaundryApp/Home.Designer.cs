namespace LaundryApp
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.currentLoadsGroupBox = new System.Windows.Forms.GroupBox();
            this.loadGroupBox3 = new System.Windows.Forms.GroupBox();
            this.loadEstimatedTimeLabel3 = new System.Windows.Forms.Label();
            this.loadMachineNumberLabel3 = new System.Windows.Forms.Label();
            this.loadLocationLabel3 = new System.Windows.Forms.Label();
            this.loadGroupBox2 = new System.Windows.Forms.GroupBox();
            this.loadEstimatedTimeLabel2 = new System.Windows.Forms.Label();
            this.loadMachineNumberLabel2 = new System.Windows.Forms.Label();
            this.loadLocationLabel2 = new System.Windows.Forms.Label();
            this.loadGroupBox1 = new System.Windows.Forms.GroupBox();
            this.loadEstimatedTimeLabel1 = new System.Windows.Forms.Label();
            this.loadMachineNumberLabel1 = new System.Windows.Forms.Label();
            this.loadLocationLabel1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLoadGroupBox = new System.Windows.Forms.GroupBox();
            this.goButton = new System.Windows.Forms.Button();
            this.dryRadioButton = new System.Windows.Forms.RadioButton();
            this.washRadioButton = new System.Windows.Forms.RadioButton();
            this.laundromatLabel = new System.Windows.Forms.Label();
            this.laundromatComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.currentLoadsGroupBox.SuspendLayout();
            this.loadGroupBox3.SuspendLayout();
            this.loadGroupBox2.SuspendLayout();
            this.loadGroupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.newLoadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // currentLoadsGroupBox
            // 
            this.currentLoadsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.currentLoadsGroupBox.Controls.Add(this.loadGroupBox3);
            this.currentLoadsGroupBox.Controls.Add(this.loadGroupBox2);
            this.currentLoadsGroupBox.Controls.Add(this.loadGroupBox1);
            this.currentLoadsGroupBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLoadsGroupBox.Location = new System.Drawing.Point(11, 40);
            this.currentLoadsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.currentLoadsGroupBox.Name = "currentLoadsGroupBox";
            this.currentLoadsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.currentLoadsGroupBox.Size = new System.Drawing.Size(378, 399);
            this.currentLoadsGroupBox.TabIndex = 0;
            this.currentLoadsGroupBox.TabStop = false;
            this.currentLoadsGroupBox.Text = "Current Laundry Loads";
            // 
            // loadGroupBox3
            // 
            this.loadGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loadGroupBox3.Controls.Add(this.loadEstimatedTimeLabel3);
            this.loadGroupBox3.Controls.Add(this.loadMachineNumberLabel3);
            this.loadGroupBox3.Controls.Add(this.loadLocationLabel3);
            this.loadGroupBox3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGroupBox3.Location = new System.Drawing.Point(18, 283);
            this.loadGroupBox3.Name = "loadGroupBox3";
            this.loadGroupBox3.Size = new System.Drawing.Size(341, 100);
            this.loadGroupBox3.TabIndex = 4;
            this.loadGroupBox3.TabStop = false;
            this.loadGroupBox3.Text = "[Load Name]";
            // 
            // loadEstimatedTimeLabel3
            // 
            this.loadEstimatedTimeLabel3.AutoSize = true;
            this.loadEstimatedTimeLabel3.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadEstimatedTimeLabel3.Location = new System.Drawing.Point(176, 33);
            this.loadEstimatedTimeLabel3.Name = "loadEstimatedTimeLabel3";
            this.loadEstimatedTimeLabel3.Size = new System.Drawing.Size(159, 20);
            this.loadEstimatedTimeLabel3.TabIndex = 2;
            this.loadEstimatedTimeLabel3.Text = "[Load Estimated Time]";
            this.loadEstimatedTimeLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loadMachineNumberLabel3
            // 
            this.loadMachineNumberLabel3.AutoSize = true;
            this.loadMachineNumberLabel3.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMachineNumberLabel3.Location = new System.Drawing.Point(6, 64);
            this.loadMachineNumberLabel3.Name = "loadMachineNumberLabel3";
            this.loadMachineNumberLabel3.Size = new System.Drawing.Size(170, 20);
            this.loadMachineNumberLabel3.TabIndex = 1;
            this.loadMachineNumberLabel3.Text = "[Load Machine Number]";
            // 
            // loadLocationLabel3
            // 
            this.loadLocationLabel3.AutoSize = true;
            this.loadLocationLabel3.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLocationLabel3.Location = new System.Drawing.Point(6, 33);
            this.loadLocationLabel3.Name = "loadLocationLabel3";
            this.loadLocationLabel3.Size = new System.Drawing.Size(113, 20);
            this.loadLocationLabel3.TabIndex = 0;
            this.loadLocationLabel3.Text = "[Load Location]";
            // 
            // loadGroupBox2
            // 
            this.loadGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loadGroupBox2.Controls.Add(this.loadEstimatedTimeLabel2);
            this.loadGroupBox2.Controls.Add(this.loadMachineNumberLabel2);
            this.loadGroupBox2.Controls.Add(this.loadLocationLabel2);
            this.loadGroupBox2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGroupBox2.Location = new System.Drawing.Point(18, 163);
            this.loadGroupBox2.Name = "loadGroupBox2";
            this.loadGroupBox2.Size = new System.Drawing.Size(341, 100);
            this.loadGroupBox2.TabIndex = 3;
            this.loadGroupBox2.TabStop = false;
            this.loadGroupBox2.Text = "[Load Name]";
            // 
            // loadEstimatedTimeLabel2
            // 
            this.loadEstimatedTimeLabel2.AutoSize = true;
            this.loadEstimatedTimeLabel2.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadEstimatedTimeLabel2.Location = new System.Drawing.Point(176, 33);
            this.loadEstimatedTimeLabel2.Name = "loadEstimatedTimeLabel2";
            this.loadEstimatedTimeLabel2.Size = new System.Drawing.Size(159, 20);
            this.loadEstimatedTimeLabel2.TabIndex = 2;
            this.loadEstimatedTimeLabel2.Text = "[Load Estimated Time]";
            this.loadEstimatedTimeLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loadMachineNumberLabel2
            // 
            this.loadMachineNumberLabel2.AutoSize = true;
            this.loadMachineNumberLabel2.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMachineNumberLabel2.Location = new System.Drawing.Point(6, 64);
            this.loadMachineNumberLabel2.Name = "loadMachineNumberLabel2";
            this.loadMachineNumberLabel2.Size = new System.Drawing.Size(170, 20);
            this.loadMachineNumberLabel2.TabIndex = 1;
            this.loadMachineNumberLabel2.Text = "[Load Machine Number]";
            // 
            // loadLocationLabel2
            // 
            this.loadLocationLabel2.AutoSize = true;
            this.loadLocationLabel2.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLocationLabel2.Location = new System.Drawing.Point(6, 33);
            this.loadLocationLabel2.Name = "loadLocationLabel2";
            this.loadLocationLabel2.Size = new System.Drawing.Size(113, 20);
            this.loadLocationLabel2.TabIndex = 0;
            this.loadLocationLabel2.Text = "[Load Location]";
            // 
            // loadGroupBox1
            // 
            this.loadGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loadGroupBox1.Controls.Add(this.loadEstimatedTimeLabel1);
            this.loadGroupBox1.Controls.Add(this.loadMachineNumberLabel1);
            this.loadGroupBox1.Controls.Add(this.loadLocationLabel1);
            this.loadGroupBox1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGroupBox1.Location = new System.Drawing.Point(18, 43);
            this.loadGroupBox1.Name = "loadGroupBox1";
            this.loadGroupBox1.Size = new System.Drawing.Size(341, 100);
            this.loadGroupBox1.TabIndex = 0;
            this.loadGroupBox1.TabStop = false;
            this.loadGroupBox1.Text = "[Load Name]";
            // 
            // loadEstimatedTimeLabel1
            // 
            this.loadEstimatedTimeLabel1.AutoSize = true;
            this.loadEstimatedTimeLabel1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadEstimatedTimeLabel1.Location = new System.Drawing.Point(176, 33);
            this.loadEstimatedTimeLabel1.Name = "loadEstimatedTimeLabel1";
            this.loadEstimatedTimeLabel1.Size = new System.Drawing.Size(159, 20);
            this.loadEstimatedTimeLabel1.TabIndex = 2;
            this.loadEstimatedTimeLabel1.Text = "[Load Estimated Time]";
            this.loadEstimatedTimeLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // loadMachineNumberLabel1
            // 
            this.loadMachineNumberLabel1.AutoSize = true;
            this.loadMachineNumberLabel1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadMachineNumberLabel1.Location = new System.Drawing.Point(6, 64);
            this.loadMachineNumberLabel1.Name = "loadMachineNumberLabel1";
            this.loadMachineNumberLabel1.Size = new System.Drawing.Size(170, 20);
            this.loadMachineNumberLabel1.TabIndex = 1;
            this.loadMachineNumberLabel1.Text = "[Load Machine Number]";
            // 
            // loadLocationLabel1
            // 
            this.loadLocationLabel1.AutoSize = true;
            this.loadLocationLabel1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLocationLabel1.Location = new System.Drawing.Point(6, 33);
            this.loadLocationLabel1.Name = "loadLocationLabel1";
            this.loadLocationLabel1.Size = new System.Drawing.Size(113, 20);
            this.loadLocationLabel1.TabIndex = 0;
            this.loadLocationLabel1.Text = "[Load Location]";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.availabilityToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(800, 26);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // availabilityToolStripMenuItem
            // 
            this.availabilityToolStripMenuItem.Name = "availabilityToolStripMenuItem";
            this.availabilityToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.availabilityToolStripMenuItem.Text = "Availability";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // newLoadGroupBox
            // 
            this.newLoadGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newLoadGroupBox.Controls.Add(this.goButton);
            this.newLoadGroupBox.Controls.Add(this.dryRadioButton);
            this.newLoadGroupBox.Controls.Add(this.washRadioButton);
            this.newLoadGroupBox.Controls.Add(this.laundromatLabel);
            this.newLoadGroupBox.Controls.Add(this.laundromatComboBox);
            this.newLoadGroupBox.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLoadGroupBox.Location = new System.Drawing.Point(412, 136);
            this.newLoadGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.newLoadGroupBox.Name = "newLoadGroupBox";
            this.newLoadGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.newLoadGroupBox.Size = new System.Drawing.Size(377, 179);
            this.newLoadGroupBox.TabIndex = 3;
            this.newLoadGroupBox.TabStop = false;
            this.newLoadGroupBox.Text = "New Laundry Load";
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.White;
            this.goButton.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(200, 93);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(162, 48);
            this.goButton.TabIndex = 13;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = false;
            // 
            // dryRadioButton
            // 
            this.dryRadioButton.AutoSize = true;
            this.dryRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dryRadioButton.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dryRadioButton.Location = new System.Drawing.Point(112, 100);
            this.dryRadioButton.Name = "dryRadioButton";
            this.dryRadioButton.Padding = new System.Windows.Forms.Padding(5);
            this.dryRadioButton.Size = new System.Drawing.Size(60, 34);
            this.dryRadioButton.TabIndex = 12;
            this.dryRadioButton.TabStop = true;
            this.dryRadioButton.Text = "Dry";
            this.dryRadioButton.UseVisualStyleBackColor = false;
            // 
            // washRadioButton
            // 
            this.washRadioButton.AutoSize = true;
            this.washRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.washRadioButton.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.washRadioButton.Location = new System.Drawing.Point(22, 100);
            this.washRadioButton.Name = "washRadioButton";
            this.washRadioButton.Padding = new System.Windows.Forms.Padding(5);
            this.washRadioButton.Size = new System.Drawing.Size(73, 34);
            this.washRadioButton.TabIndex = 11;
            this.washRadioButton.TabStop = true;
            this.washRadioButton.Text = "Wash";
            this.washRadioButton.UseVisualStyleBackColor = false;
            // 
            // laundromatLabel
            // 
            this.laundromatLabel.AutoSize = true;
            this.laundromatLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laundromatLabel.Location = new System.Drawing.Point(20, 50);
            this.laundromatLabel.Name = "laundromatLabel";
            this.laundromatLabel.Size = new System.Drawing.Size(89, 20);
            this.laundromatLabel.TabIndex = 5;
            this.laundromatLabel.Text = "Laundromat";
            // 
            // laundromatComboBox
            // 
            this.laundromatComboBox.BackColor = System.Drawing.Color.White;
            this.laundromatComboBox.FormattingEnabled = true;
            this.laundromatComboBox.Location = new System.Drawing.Point(137, 44);
            this.laundromatComboBox.Name = "laundromatComboBox";
            this.laundromatComboBox.Size = new System.Drawing.Size(225, 33);
            this.laundromatComboBox.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newLoadGroupBox);
            this.Controls.Add(this.currentLoadsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.currentLoadsGroupBox.ResumeLayout(false);
            this.loadGroupBox3.ResumeLayout(false);
            this.loadGroupBox3.PerformLayout();
            this.loadGroupBox2.ResumeLayout(false);
            this.loadGroupBox2.PerformLayout();
            this.loadGroupBox1.ResumeLayout(false);
            this.loadGroupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.newLoadGroupBox.ResumeLayout(false);
            this.newLoadGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox currentLoadsGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availabilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.GroupBox newLoadGroupBox;
        private System.Windows.Forms.Label laundromatLabel;
        private System.Windows.Forms.ComboBox laundromatComboBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.RadioButton dryRadioButton;
        private System.Windows.Forms.RadioButton washRadioButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox loadGroupBox1;
        private System.Windows.Forms.Label loadLocationLabel1;
        private System.Windows.Forms.Label loadEstimatedTimeLabel1;
        private System.Windows.Forms.Label loadMachineNumberLabel1;
        private System.Windows.Forms.GroupBox loadGroupBox3;
        private System.Windows.Forms.Label loadEstimatedTimeLabel3;
        private System.Windows.Forms.Label loadMachineNumberLabel3;
        private System.Windows.Forms.Label loadLocationLabel3;
        private System.Windows.Forms.GroupBox loadGroupBox2;
        private System.Windows.Forms.Label loadEstimatedTimeLabel2;
        private System.Windows.Forms.Label loadMachineNumberLabel2;
        private System.Windows.Forms.Label loadLocationLabel2;
    }
}