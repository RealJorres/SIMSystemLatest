namespace SIMSystem.MiniForms
{
    partial class UserMiniPlate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.cb_isNotifEnabled = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.link_edit = new System.Windows.Forms.LinkLabel();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(3, 6);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(164, 25);
            this.tb_name.TabIndex = 0;
            this.tb_name.Text = "Joshua Relatorres";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(173, 6);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(181, 25);
            this.tb_email.TabIndex = 2;
            this.tb_email.Text = "joshuarelatorres28@gmail.com";
            // 
            // cb_isNotifEnabled
            // 
            this.cb_isNotifEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_isNotifEnabled.Enabled = false;
            this.cb_isNotifEnabled.FormattingEnabled = true;
            this.cb_isNotifEnabled.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_isNotifEnabled.Location = new System.Drawing.Point(469, 6);
            this.cb_isNotifEnabled.Name = "cb_isNotifEnabled";
            this.cb_isNotifEnabled.Size = new System.Drawing.Size(72, 26);
            this.cb_isNotifEnabled.TabIndex = 4;
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.Enabled = false;
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Admin",
            "Supply Officer",
            "Chief Statistical Specialist",
            "Regular Employee"});
            this.cb_type.Location = new System.Drawing.Point(360, 6);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(103, 26);
            this.cb_type.TabIndex = 5;
            // 
            // link_edit
            // 
            this.link_edit.AutoSize = true;
            this.link_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_edit.Location = new System.Drawing.Point(549, 10);
            this.link_edit.Name = "link_edit";
            this.link_edit.Size = new System.Drawing.Size(29, 18);
            this.link_edit.TabIndex = 6;
            this.link_edit.TabStop = true;
            this.link_edit.Text = "Edit";
            this.link_edit.Click += new System.EventHandler(this.link_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(600, 6);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(53, 26);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 1);
            this.panel1.TabIndex = 8;
            // 
            // UserMiniPlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.link_edit);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.cb_isNotifEnabled);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_name);
            this.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserMiniPlate";
            this.Size = new System.Drawing.Size(660, 35);
            this.Load += new System.EventHandler(this.UserMiniPlate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_name;
        private TextBox tb_email;
        private ComboBox cb_isNotifEnabled;
        private ComboBox cb_type;
        private LinkLabel link_edit;
        private Button btn_save;
        private Panel panel1;
    }
}
