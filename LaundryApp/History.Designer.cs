namespace LaundryApp
{
    
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.navToolStrip = new System.Windows.Forms.ToolStrip();
            this.homeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.availToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.historyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.historyGroupBox = new System.Windows.Forms.GroupBox();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setting1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setting2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navToolStrip.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.historyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navToolStrip
            // 
            this.navToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.navToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripButton,
            this.availToolStripButton,
            this.historyToolStripButton,
            this.reportToolStripButton});
            this.navToolStrip.Location = new System.Drawing.Point(0, 0);
            this.navToolStrip.Name = "navToolStrip";
            this.navToolStrip.Size = new System.Drawing.Size(800, 25);
            this.navToolStrip.TabIndex = 0;
            this.navToolStrip.Text = "navToolStrip";
            // 
            // homeToolStripButton
            // 
            this.homeToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.homeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.homeToolStripButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripButton.ForeColor = System.Drawing.Color.White;
            this.homeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeToolStripButton.Name = "homeToolStripButton";
            this.homeToolStripButton.Size = new System.Drawing.Size(43, 22);
            this.homeToolStripButton.Text = "Home";
            // 
            // availToolStripButton
            // 
            this.availToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.availToolStripButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availToolStripButton.ForeColor = System.Drawing.Color.White;
            this.availToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("availToolStripButton.Image")));
            this.availToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.availToolStripButton.Name = "availToolStripButton";
            this.availToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.availToolStripButton.Text = "Availability";
            // 
            // historyToolStripButton
            // 
            this.historyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyToolStripButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyToolStripButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.historyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyToolStripButton.Name = "historyToolStripButton";
            this.historyToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.historyToolStripButton.Text = "History";
            // 
            // reportToolStripButton
            // 
            this.reportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reportToolStripButton.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripButton.ForeColor = System.Drawing.Color.White;
            this.reportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportToolStripButton.Name = "reportToolStripButton";
            this.reportToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.reportToolStripButton.Text = "Report";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Location = new System.Drawing.Point(12, 39);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(366, 59);
            this.searchPanel.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(19, 21);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(242, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(267, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // historyGroupBox
            // 
            this.historyGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(104)))), ((int)(((byte)(62)))));
            this.historyGroupBox.Controls.Add(this.historyDataGridView);
            this.historyGroupBox.ForeColor = System.Drawing.Color.White;
            this.historyGroupBox.Location = new System.Drawing.Point(12, 116);
            this.historyGroupBox.Name = "historyGroupBox";
            this.historyGroupBox.Size = new System.Drawing.Size(776, 322);
            this.historyGroupBox.TabIndex = 2;
            this.historyGroupBox.TabStop = false;
            this.historyGroupBox.Text = "History";
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.MachineName,
            this.Setting1,
            this.Setting2,
            this.LoadName,
            this.LoadInterval});
            this.historyDataGridView.Location = new System.Drawing.Point(19, 19);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.Size = new System.Drawing.Size(642, 211);
            this.historyDataGridView.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // MachineName
            // 
            this.MachineName.HeaderText = "Machine Name";
            this.MachineName.Name = "MachineName";
            // 
            // Setting1
            // 
            this.Setting1.HeaderText = "Setting 1";
            this.Setting1.Name = "Setting1";
            // 
            // Setting2
            // 
            this.Setting2.HeaderText = "Setting 2";
            this.Setting2.Name = "Setting2";
            // 
            // LoadName
            // 
            this.LoadName.HeaderText = "Load Name";
            this.LoadName.Name = "LoadName";
            // 
            // LoadInterval
            // 
            this.LoadInterval.HeaderText = "Load Interval";
            this.LoadInterval.Name = "LoadInterval";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(202)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyGroupBox);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.navToolStrip);
            this.Name = "History";
            this.Text = "History Log";
            this.navToolStrip.ResumeLayout(false);
            this.navToolStrip.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.historyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip navToolStrip;
        private System.Windows.Forms.ToolStripButton homeToolStripButton;
        private System.Windows.Forms.ToolStripButton availToolStripButton;
        private System.Windows.Forms.ToolStripButton historyToolStripButton;
        private System.Windows.Forms.ToolStripButton reportToolStripButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox historyGroupBox;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setting1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setting2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoadInterval;
    }

    
}