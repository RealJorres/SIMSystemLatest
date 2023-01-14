namespace SIMSystem.PartialForms
{
    partial class CreateRis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRis));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_entityName = new System.Windows.Forms.TextBox();
            this.tb_fundCluster = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_division = new System.Windows.Forms.ComboBox();
            this.tb_office = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_risNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_purpose = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_createRis = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creating Requisition and Issue Slip";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(16, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 1);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entity Name:";
            // 
            // tb_entityName
            // 
            this.tb_entityName.Location = new System.Drawing.Point(118, 63);
            this.tb_entityName.Name = "tb_entityName";
            this.tb_entityName.ReadOnly = true;
            this.tb_entityName.Size = new System.Drawing.Size(262, 30);
            this.tb_entityName.TabIndex = 3;
            this.tb_entityName.Text = "PHILIPPINE STATISTICS AUTHORITY";
            // 
            // tb_fundCluster
            // 
            this.tb_fundCluster.Location = new System.Drawing.Point(571, 63);
            this.tb_fundCluster.Name = "tb_fundCluster";
            this.tb_fundCluster.ReadOnly = true;
            this.tb_fundCluster.Size = new System.Drawing.Size(262, 30);
            this.tb_fundCluster.TabIndex = 5;
            this.tb_fundCluster.Text = "Regular Fund";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(467, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fund Cluster:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Division:";
            // 
            // cb_division
            // 
            this.cb_division.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_division.FormattingEnabled = true;
            this.cb_division.Items.AddRange(new object[] {
            "Admin",
            "Statistical",
            "Civil Registration",
            "PhilSys"});
            this.cb_division.Location = new System.Drawing.Point(118, 99);
            this.cb_division.MaxDropDownItems = 4;
            this.cb_division.Name = "cb_division";
            this.cb_division.Size = new System.Drawing.Size(262, 30);
            this.cb_division.TabIndex = 7;
            this.cb_division.Validating += new System.ComponentModel.CancelEventHandler(this.cb_division_Validating);
            // 
            // tb_office
            // 
            this.tb_office.Location = new System.Drawing.Point(571, 97);
            this.tb_office.Name = "tb_office";
            this.tb_office.ReadOnly = true;
            this.tb_office.Size = new System.Drawing.Size(262, 30);
            this.tb_office.TabIndex = 9;
            this.tb_office.Text = "PSA, Marinduque Provincial Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(467, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Office:";
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(118, 135);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(262, 30);
            this.tb_date.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(16, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date:";
            // 
            // tb_risNumber
            // 
            this.tb_risNumber.Location = new System.Drawing.Point(571, 133);
            this.tb_risNumber.Name = "tb_risNumber";
            this.tb_risNumber.ReadOnly = true;
            this.tb_risNumber.Size = new System.Drawing.Size(262, 30);
            this.tb_risNumber.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(467, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "RIS No.:";
            // 
            // tb_purpose
            // 
            this.tb_purpose.Location = new System.Drawing.Point(118, 171);
            this.tb_purpose.Name = "tb_purpose";
            this.tb_purpose.Size = new System.Drawing.Size(262, 30);
            this.tb_purpose.TabIndex = 15;
            this.tb_purpose.Validating += new System.ComponentModel.CancelEventHandler(this.tb_purpose_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(16, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Purpose:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(16, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 251);
            this.panel2.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add.BackgroundImage = global::SIMSystem.Properties.Resources.plus;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Location = new System.Drawing.Point(157, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(20, 20);
            this.btn_add.TabIndex = 0;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(3, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(818, 221);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Heebo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Supply Information";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(615, 480);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 35);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_createRis
            // 
            this.btn_createRis.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_createRis.FlatAppearance.BorderSize = 0;
            this.btn_createRis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createRis.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_createRis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_createRis.Location = new System.Drawing.Point(734, 480);
            this.btn_createRis.Name = "btn_createRis";
            this.btn_createRis.Size = new System.Drawing.Size(113, 35);
            this.btn_createRis.TabIndex = 17;
            this.btn_createRis.Text = "Create";
            this.btn_createRis.UseVisualStyleBackColor = false;
            this.btn_createRis.Click += new System.EventHandler(this.btn_createRis_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // CreateRis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(854, 523);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_createRis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_purpose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_risNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_office);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_division);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_fundCluster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_entityName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CreateRis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SIMSystem: Creating RIS (Regular Employee)";
            this.Load += new System.EventHandler(this.CreateRis_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox tb_entityName;
        private TextBox tb_fundCluster;
        private Label label3;
        private Label label4;
        private ComboBox cb_division;
        private TextBox tb_office;
        private Label label5;
        private TextBox tb_date;
        private Label label6;
        private TextBox tb_risNumber;
        private Label label7;
        private TextBox tb_purpose;
        private Label label8;
        private Panel panel2;
        private Panel btn_add;
        private Panel panel3;
        private Label label9;
        private Button btn_cancel;
        private Button btn_createRis;
        private ErrorProvider errorProvider;
    }
}
