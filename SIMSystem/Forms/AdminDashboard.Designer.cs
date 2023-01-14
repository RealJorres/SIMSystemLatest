namespace SIMSystem.Forms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_manageSupply = new System.Windows.Forms.Panel();
            this.btn_updateSupply = new System.Windows.Forms.Button();
            this.btn_addSupply = new System.Windows.Forms.Button();
            this.btn_manageSupply = new System.Windows.Forms.Button();
            this.panel_manageUser = new System.Windows.Forms.Panel();
            this.btn_updateUser = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_manageUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel_manageSupply.SuspendLayout();
            this.panel_manageUser.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 486);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel_manageSupply);
            this.panel6.Controls.Add(this.panel_manageUser);
            this.panel6.Location = new System.Drawing.Point(7, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 307);
            this.panel6.TabIndex = 2;
            // 
            // panel_manageSupply
            // 
            this.panel_manageSupply.Controls.Add(this.btn_updateSupply);
            this.panel_manageSupply.Controls.Add(this.btn_addSupply);
            this.panel_manageSupply.Controls.Add(this.btn_manageSupply);
            this.panel_manageSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_manageSupply.Location = new System.Drawing.Point(0, 143);
            this.panel_manageSupply.MaximumSize = new System.Drawing.Size(204, 143);
            this.panel_manageSupply.MinimumSize = new System.Drawing.Size(204, 47);
            this.panel_manageSupply.Name = "panel_manageSupply";
            this.panel_manageSupply.Size = new System.Drawing.Size(204, 143);
            this.panel_manageSupply.TabIndex = 3;
            // 
            // btn_updateSupply
            // 
            this.btn_updateSupply.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_updateSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_updateSupply.FlatAppearance.BorderSize = 0;
            this.btn_updateSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateSupply.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateSupply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_updateSupply.Image = global::SIMSystem.Properties.Resources.update_supply;
            this.btn_updateSupply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_updateSupply.Location = new System.Drawing.Point(0, 94);
            this.btn_updateSupply.Name = "btn_updateSupply";
            this.btn_updateSupply.Size = new System.Drawing.Size(204, 47);
            this.btn_updateSupply.TabIndex = 2;
            this.btn_updateSupply.Text = "Update Supply";
            this.btn_updateSupply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_updateSupply.UseVisualStyleBackColor = false;
            this.btn_updateSupply.Click += new System.EventHandler(this.btn_updateSupply_Click);
            // 
            // btn_addSupply
            // 
            this.btn_addSupply.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_addSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addSupply.FlatAppearance.BorderSize = 0;
            this.btn_addSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSupply.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addSupply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addSupply.Image = global::SIMSystem.Properties.Resources.add_supply;
            this.btn_addSupply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addSupply.Location = new System.Drawing.Point(0, 47);
            this.btn_addSupply.Name = "btn_addSupply";
            this.btn_addSupply.Size = new System.Drawing.Size(204, 47);
            this.btn_addSupply.TabIndex = 1;
            this.btn_addSupply.Text = "Add Supply";
            this.btn_addSupply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_addSupply.UseVisualStyleBackColor = false;
            this.btn_addSupply.Click += new System.EventHandler(this.btn_addSupply_Click);
            // 
            // btn_manageSupply
            // 
            this.btn_manageSupply.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_manageSupply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manageSupply.FlatAppearance.BorderSize = 0;
            this.btn_manageSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageSupply.Font = new System.Drawing.Font("Heebo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_manageSupply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_manageSupply.Image = global::SIMSystem.Properties.Resources.manage_supply;
            this.btn_manageSupply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_manageSupply.Location = new System.Drawing.Point(0, 0);
            this.btn_manageSupply.Name = "btn_manageSupply";
            this.btn_manageSupply.Size = new System.Drawing.Size(204, 47);
            this.btn_manageSupply.TabIndex = 0;
            this.btn_manageSupply.Text = "Manage Supply";
            this.btn_manageSupply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageSupply.UseVisualStyleBackColor = false;
            this.btn_manageSupply.Click += new System.EventHandler(this.btn_manageSupply_Click);
            // 
            // panel_manageUser
            // 
            this.panel_manageUser.Controls.Add(this.btn_updateUser);
            this.panel_manageUser.Controls.Add(this.btn_addUser);
            this.panel_manageUser.Controls.Add(this.btn_manageUser);
            this.panel_manageUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_manageUser.Location = new System.Drawing.Point(0, 0);
            this.panel_manageUser.MaximumSize = new System.Drawing.Size(204, 143);
            this.panel_manageUser.MinimumSize = new System.Drawing.Size(204, 47);
            this.panel_manageUser.Name = "panel_manageUser";
            this.panel_manageUser.Size = new System.Drawing.Size(204, 143);
            this.panel_manageUser.TabIndex = 2;
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_updateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_updateUser.FlatAppearance.BorderSize = 0;
            this.btn_updateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateUser.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_updateUser.Image = global::SIMSystem.Properties.Resources.update_user;
            this.btn_updateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_updateUser.Location = new System.Drawing.Point(0, 94);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(204, 47);
            this.btn_updateUser.TabIndex = 2;
            this.btn_updateUser.Text = "Update User";
            this.btn_updateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_updateUser.UseVisualStyleBackColor = false;
            this.btn_updateUser.Click += new System.EventHandler(this.btn_updateUser_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addUser.FlatAppearance.BorderSize = 0;
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addUser.Image = global::SIMSystem.Properties.Resources.add_user;
            this.btn_addUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addUser.Location = new System.Drawing.Point(0, 47);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(204, 47);
            this.btn_addUser.TabIndex = 1;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_manageUser
            // 
            this.btn_manageUser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_manageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manageUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_manageUser.FlatAppearance.BorderSize = 0;
            this.btn_manageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageUser.Font = new System.Drawing.Font("Heebo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_manageUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_manageUser.Image = global::SIMSystem.Properties.Resources.manage_user;
            this.btn_manageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_manageUser.Location = new System.Drawing.Point(0, 0);
            this.btn_manageUser.Name = "btn_manageUser";
            this.btn_manageUser.Size = new System.Drawing.Size(204, 47);
            this.btn_manageUser.TabIndex = 0;
            this.btn_manageUser.Text = "Manage User";
            this.btn_manageUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageUser.UseVisualStyleBackColor = false;
            this.btn_manageUser.Click += new System.EventHandler(this.btn_manageUser_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_userName);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 102);
            this.panel4.TabIndex = 1;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Heebo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_userName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_userName.Location = new System.Drawing.Point(48, 30);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(50, 22);
            this.lbl_userName.TabIndex = 2;
            this.lbl_userName.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SIMSystem.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Control Panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SIMSystem.Properties.Resources.psa_banner_dark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelHeader.Controls.Add(this.panel5);
            this.panelHeader.Controls.Add(this.panel2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(213, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(673, 59);
            this.panelHeader.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::SIMSystem.Properties.Resources.settingsss;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(590, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(24, 24);
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(632, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 24);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(213, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 427);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 427);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Users";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(665, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 486);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMSystem: Admin Dashboard";
            this.Activated += new System.EventHandler(this.AdminDashboard_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel_manageSupply.ResumeLayout(false);
            this.panel_manageUser.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelHeader;
        private Panel panel3;
        private Panel panel_manageUser;
        private Button btn_updateUser;
        private Button btn_addUser;
        private Button btn_manageUser;
        private Panel panel_manageSupply;
        private Button btn_updateSupply;
        private Button btn_addSupply;
        private Button btn_manageSupply;
        private Panel panel4;
        private Label label1;
        private Panel panel6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lbl_userName;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer;
        private Panel panel2;
        private Panel panel5;
    }
}