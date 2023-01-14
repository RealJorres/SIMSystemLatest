namespace SIMSystem.ManageSupply
{
    partial class AddSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupply));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_poNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_supplyUnit = new System.Windows.Forms.ComboBox();
            this.cb_supplyType = new System.Windows.Forms.ComboBox();
            this.tb_supplyTotalCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_supplyUnitCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_supplyCLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_supplyQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_supplyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 74);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMSystem.Properties.Resources.psa_banner_dark;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(221, 428);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 35);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Location = new System.Drawing.Point(340, 428);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 35);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.tb_poNumber);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cb_supplyUnit);
            this.panel1.Controls.Add(this.cb_supplyType);
            this.panel1.Controls.Add(this.tb_supplyTotalCost);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_supplyUnitCost);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_supplyCLevel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_supplyQuantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_supplyName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 342);
            this.panel1.TabIndex = 10;
            // 
            // tb_poNumber
            // 
            this.tb_poNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_poNumber.Location = new System.Drawing.Point(175, 290);
            this.tb_poNumber.Name = "tb_poNumber";
            this.tb_poNumber.Size = new System.Drawing.Size(198, 27);
            this.tb_poNumber.TabIndex = 18;
            this.tb_poNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tb_poNumber_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(61, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "P.O. No.:";
            // 
            // cb_supplyUnit
            // 
            this.cb_supplyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplyUnit.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_supplyUnit.FormattingEnabled = true;
            this.cb_supplyUnit.Items.AddRange(new object[] {
            "Box",
            "Piece",
            "Gallon",
            "Ream"});
            this.cb_supplyUnit.Location = new System.Drawing.Point(175, 188);
            this.cb_supplyUnit.Name = "cb_supplyUnit";
            this.cb_supplyUnit.Size = new System.Drawing.Size(198, 30);
            this.cb_supplyUnit.TabIndex = 12;
            this.cb_supplyUnit.Validating += new System.ComponentModel.CancelEventHandler(this.cb_supplyUnit_Validating);
            // 
            // cb_supplyType
            // 
            this.cb_supplyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplyType.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_supplyType.FormattingEnabled = true;
            this.cb_supplyType.Items.AddRange(new object[] {
            "PPE",
            "Office Supply",
            "Janitorial",
            "Field Supply"});
            this.cb_supplyType.Location = new System.Drawing.Point(175, 152);
            this.cb_supplyType.Name = "cb_supplyType";
            this.cb_supplyType.Size = new System.Drawing.Size(198, 30);
            this.cb_supplyType.TabIndex = 10;
            this.cb_supplyType.Validating += new System.ComponentModel.CancelEventHandler(this.cb_supplyType_Validating);
            // 
            // tb_supplyTotalCost
            // 
            this.tb_supplyTotalCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_supplyTotalCost.Location = new System.Drawing.Point(175, 257);
            this.tb_supplyTotalCost.Name = "tb_supplyTotalCost";
            this.tb_supplyTotalCost.ReadOnly = true;
            this.tb_supplyTotalCost.Size = new System.Drawing.Size(198, 27);
            this.tb_supplyTotalCost.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(61, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total Cost:";
            // 
            // tb_supplyUnitCost
            // 
            this.tb_supplyUnitCost.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_supplyUnitCost.Location = new System.Drawing.Point(175, 224);
            this.tb_supplyUnitCost.Name = "tb_supplyUnitCost";
            this.tb_supplyUnitCost.Size = new System.Drawing.Size(198, 27);
            this.tb_supplyUnitCost.TabIndex = 14;
            this.tb_supplyUnitCost.Validating += new System.ComponentModel.CancelEventHandler(this.tb_supplyUnitCost_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(61, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Unit Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(61, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Unit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(61, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Type:";
            // 
            // tb_supplyCLevel
            // 
            this.tb_supplyCLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_supplyCLevel.Location = new System.Drawing.Point(175, 119);
            this.tb_supplyCLevel.Name = "tb_supplyCLevel";
            this.tb_supplyCLevel.Size = new System.Drawing.Size(198, 27);
            this.tb_supplyCLevel.TabIndex = 8;
            this.tb_supplyCLevel.Validating += new System.ComponentModel.CancelEventHandler(this.tb_supplyCLevel_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(61, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Critical Level:";
            // 
            // tb_supplyQuantity
            // 
            this.tb_supplyQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_supplyQuantity.Location = new System.Drawing.Point(175, 86);
            this.tb_supplyQuantity.Name = "tb_supplyQuantity";
            this.tb_supplyQuantity.Size = new System.Drawing.Size(198, 27);
            this.tb_supplyQuantity.TabIndex = 6;
            this.tb_supplyQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.tb_supplyQuantity_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(61, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // tb_supplyName
            // 
            this.tb_supplyName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_supplyName.Location = new System.Drawing.Point(175, 53);
            this.tb_supplyName.Name = "tb_supplyName";
            this.tb_supplyName.Size = new System.Drawing.Size(198, 27);
            this.tb_supplyName.TabIndex = 4;
            this.tb_supplyName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_supplyName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(61, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supply Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(283, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Note (Hover here)";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(3, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 1);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please fill-up the supply information:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // AddSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(465, 472);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator: Add Supply";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_cancel;
        private Button btn_add;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private ToolTip toolTip;
        private TextBox tb_supplyTotalCost;
        private Label label9;
        private TextBox tb_supplyUnitCost;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tb_supplyCLevel;
        private Label label5;
        private TextBox tb_supplyQuantity;
        private Label label4;
        private TextBox tb_supplyName;
        private Label label3;
        private ComboBox cb_supplyUnit;
        private ComboBox cb_supplyType;
        private TextBox tb_poNumber;
        private Label label10;
        private ErrorProvider errorProvider;
    }
}