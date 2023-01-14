namespace SIMSystem.Forms
{
    partial class SODashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SODashboard));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_soBody = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_usersOnlineStatus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_bulletin = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_overview = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer_ris_watcher = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1273, 56);
            this.panelHeader.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMSystem.Properties.Resources.psa_banner_dark;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_soBody
            // 
            this.panel_soBody.AutoScroll = true;
            this.panel_soBody.Location = new System.Drawing.Point(245, 62);
            this.panel_soBody.Name = "panel_soBody";
            this.panel_soBody.Size = new System.Drawing.Size(786, 530);
            this.panel_soBody.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_usersOnlineStatus);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1037, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 536);
            this.panel3.TabIndex = 4;
            // 
            // panel_usersOnlineStatus
            // 
            this.panel_usersOnlineStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_usersOnlineStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_usersOnlineStatus.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_usersOnlineStatus.Location = new System.Drawing.Point(0, 22);
            this.panel_usersOnlineStatus.Name = "panel_usersOnlineStatus";
            this.panel_usersOnlineStatus.Size = new System.Drawing.Size(236, 514);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.lbl_empName);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 536);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(5, 507);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 24);
            this.panel5.TabIndex = 5;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_bulletin);
            this.panel2.Controls.Add(this.btn_inventory);
            this.panel2.Controls.Add(this.btn_overview);
            this.panel2.Location = new System.Drawing.Point(3, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 237);
            this.panel2.TabIndex = 4;
            // 
            // btn_bulletin
            // 
            this.btn_bulletin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bulletin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bulletin.FlatAppearance.BorderSize = 0;
            this.btn_bulletin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bulletin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_bulletin.Image = global::SIMSystem.Properties.Resources.schedule1;
            this.btn_bulletin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bulletin.Location = new System.Drawing.Point(0, 122);
            this.btn_bulletin.Name = "btn_bulletin";
            this.btn_bulletin.Size = new System.Drawing.Size(230, 61);
            this.btn_bulletin.TabIndex = 2;
            this.btn_bulletin.Text = "Bulletin";
            this.btn_bulletin.UseVisualStyleBackColor = true;
            this.btn_bulletin.Click += new System.EventHandler(this.btn_bulletin_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inventory.FlatAppearance.BorderSize = 0;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_inventory.Image = global::SIMSystem.Properties.Resources.storage;
            this.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventory.Location = new System.Drawing.Point(0, 61);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(230, 61);
            this.btn_inventory.TabIndex = 1;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_overview
            // 
            this.btn_overview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_overview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_overview.FlatAppearance.BorderSize = 0;
            this.btn_overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_overview.Image = global::SIMSystem.Properties.Resources.statistics;
            this.btn_overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_overview.Location = new System.Drawing.Point(0, 0);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Size = new System.Drawing.Size(230, 61);
            this.btn_overview.TabIndex = 0;
            this.btn_overview.Text = "Overview";
            this.btn_overview.UseVisualStyleBackColor = true;
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(3, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 2);
            this.panel1.TabIndex = 3;
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Font = new System.Drawing.Font("Heebo Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_empName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_empName.Location = new System.Drawing.Point(50, 93);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(95, 19);
            this.lbl_empName.TabIndex = 2;
            this.lbl_empName.Text = "Juan Dela Cruz";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SIMSystem.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Heebo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "DASHBOARD";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_ris_watcher
            // 
            this.timer_ris_watcher.Tick += new System.EventHandler(this.timer_ris_watcher_Tick);
            // 
            // SODashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 592);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_soBody);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SODashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMSystem: Supply Officer Dashboard";
            this.Activated += new System.EventHandler(this.SODashboard_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SODashboard_FormClosing);
            this.Load += new System.EventHandler(this.SODashboard_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private PictureBox pictureBox1;
        private Panel panel_soBody;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Panel panel_usersOnlineStatus;
        private Label label2;
        private Panel panel1;
        private Label lbl_empName;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btn_bulletin;
        private Button btn_inventory;
        private Button btn_overview;
        private System.Windows.Forms.Timer timer;
        private Panel panel5;
        private System.Windows.Forms.Timer timer_ris_watcher;
    }
}