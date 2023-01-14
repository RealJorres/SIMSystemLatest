namespace SIMSystem.Forms
{
    partial class RegularDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegularDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_usersOnlineStatus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_requestHistory = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_employeeBashboardBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SIMSystem.Properties.Resources.psa_banner_dark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(947, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_usersOnlineStatus);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(711, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 464);
            this.panel3.TabIndex = 5;
            // 
            // panel_usersOnlineStatus
            // 
            this.panel_usersOnlineStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_usersOnlineStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_usersOnlineStatus.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_usersOnlineStatus.Location = new System.Drawing.Point(0, 22);
            this.panel_usersOnlineStatus.Name = "panel_usersOnlineStatus";
            this.panel_usersOnlineStatus.Size = new System.Drawing.Size(236, 442);
            this.panel_usersOnlineStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Online Status";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_empName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 464);
            this.panel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(9, 431);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 24);
            this.panel5.TabIndex = 8;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_requestHistory);
            this.panel4.Controls.Add(this.btn_overview);
            this.panel4.Location = new System.Drawing.Point(3, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 218);
            this.panel4.TabIndex = 7;
            // 
            // btn_requestHistory
            // 
            this.btn_requestHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_requestHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_requestHistory.FlatAppearance.BorderSize = 0;
            this.btn_requestHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_requestHistory.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_requestHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_requestHistory.Image = global::SIMSystem.Properties.Resources.schedule;
            this.btn_requestHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_requestHistory.Location = new System.Drawing.Point(0, 61);
            this.btn_requestHistory.Name = "btn_requestHistory";
            this.btn_requestHistory.Size = new System.Drawing.Size(197, 61);
            this.btn_requestHistory.TabIndex = 2;
            this.btn_requestHistory.Text = "Request History";
            this.btn_requestHistory.UseVisualStyleBackColor = true;
            this.btn_requestHistory.Click += new System.EventHandler(this.btn_requestHistory_Click);
            // 
            // btn_overview
            // 
            this.btn_overview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_overview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_overview.FlatAppearance.BorderSize = 0;
            this.btn_overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overview.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_overview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_overview.Image = global::SIMSystem.Properties.Resources.statistics;
            this.btn_overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_overview.Location = new System.Drawing.Point(0, 0);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(197, 61);
            this.btn_overview.TabIndex = 1;
            this.btn_overview.Text = "Overview";
            this.btn_overview.UseVisualStyleBackColor = true;
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(3, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 1);
            this.panel2.TabIndex = 6;
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Font = new System.Drawing.Font("Heebo Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_empName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_empName.Location = new System.Drawing.Point(47, 67);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(95, 19);
            this.lbl_empName.TabIndex = 5;
            this.lbl_empName.Text = "Juan Dela Cruz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SIMSystem.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(9, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Heebo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "DASHBOARD";
            // 
            // panel_employeeBashboardBody
            // 
            this.panel_employeeBashboardBody.AutoScroll = true;
            this.panel_employeeBashboardBody.BackColor = System.Drawing.SystemColors.Control;
            this.panel_employeeBashboardBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_employeeBashboardBody.Location = new System.Drawing.Point(203, 59);
            this.panel_employeeBashboardBody.Name = "panel_employeeBashboardBody";
            this.panel_employeeBashboardBody.Size = new System.Drawing.Size(508, 464);
            this.panel_employeeBashboardBody.TabIndex = 7;
            // 
            // RegularDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 523);
            this.Controls.Add(this.panel_employeeBashboardBody);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegularDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMSystem: Employee Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegularDashboard_FormClosing);
            this.Load += new System.EventHandler(this.RegularDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel_usersOnlineStatus;
        private Label label1;
        private System.Windows.Forms.Timer timer;
        private Panel panel1;
        private Label label2;
        private Label lbl_empName;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel4;
        private Button btn_overview;
        private Panel panel_employeeBashboardBody;
        private Button btn_requestHistory;
        private Panel panel5;
    }
}