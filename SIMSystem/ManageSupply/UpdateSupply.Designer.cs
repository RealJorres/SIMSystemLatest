namespace SIMSystem.ManageSupply
{
    partial class UpdateSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSupply));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_supplyPONumber = new System.Windows.Forms.TextBox();
            this.tb_supplyTotalCost = new System.Windows.Forms.TextBox();
            this.cb_supplyUnit = new System.Windows.Forms.ComboBox();
            this.cb_supplyType = new System.Windows.Forms.ComboBox();
            this.tb_supplyQuantity = new System.Windows.Forms.TextBox();
            this.cb_supplyName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.tb_supplyPONumber);
            this.panel1.Controls.Add(this.tb_supplyTotalCost);
            this.panel1.Controls.Add(this.cb_supplyUnit);
            this.panel1.Controls.Add(this.cb_supplyType);
            this.panel1.Controls.Add(this.tb_supplyQuantity);
            this.panel1.Controls.Add(this.cb_supplyName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 280);
            this.panel1.TabIndex = 13;
            // 
            // tb_supplyPONumber
            // 
            this.tb_supplyPONumber.Font = new System.Drawing.Font("Heebo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_supplyPONumber.Location = new System.Drawing.Point(182, 220);
            this.tb_supplyPONumber.Name = "tb_supplyPONumber";
            this.tb_supplyPONumber.Size = new System.Drawing.Size(209, 27);
            this.tb_supplyPONumber.TabIndex = 23;
            this.tb_supplyPONumber.Validating += new System.ComponentModel.CancelEventHandler(this.tb_supplyPONumber_Validating);
            // 
            // tb_supplyTotalCost
            // 
            this.tb_supplyTotalCost.Font = new System.Drawing.Font("Heebo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_supplyTotalCost.Location = new System.Drawing.Point(182, 187);
            this.tb_supplyTotalCost.Name = "tb_supplyTotalCost";
            this.tb_supplyTotalCost.Size = new System.Drawing.Size(209, 27);
            this.tb_supplyTotalCost.TabIndex = 22;
            this.tb_supplyTotalCost.Validating += new System.ComponentModel.CancelEventHandler(this.tb_supplyTotalCost_Validating);
            // 
            // cb_supplyUnit
            // 
            this.cb_supplyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplyUnit.Enabled = false;
            this.cb_supplyUnit.Font = new System.Drawing.Font("Heebo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_supplyUnit.FormattingEnabled = true;
            this.cb_supplyUnit.Items.AddRange(new object[] {
            "Box",
            "Piece",
            "Gallon",
            "Ream"});
            this.cb_supplyUnit.Location = new System.Drawing.Point(182, 154);
            this.cb_supplyUnit.Name = "cb_supplyUnit";
            this.cb_supplyUnit.Size = new System.Drawing.Size(209, 27);
            this.cb_supplyUnit.TabIndex = 21;
            // 
            // cb_supplyType
            // 
            this.cb_supplyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplyType.Enabled = false;
            this.cb_supplyType.Font = new System.Drawing.Font("Heebo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_supplyType.FormattingEnabled = true;
            this.cb_supplyType.Items.AddRange(new object[] {
            "PPE",
            "Office Supply",
            "Janitorial",
            "Field Supply"});
            this.cb_supplyType.Location = new System.Drawing.Point(182, 121);
            this.cb_supplyType.Name = "cb_supplyType";
            this.cb_supplyType.Size = new System.Drawing.Size(209, 27);
            this.cb_supplyType.TabIndex = 20;
            // 
            // tb_supplyQuantity
            // 
            this.tb_supplyQuantity.Font = new System.Drawing.Font("Heebo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_supplyQuantity.Location = new System.Drawing.Point(182, 88);
            this.tb_supplyQuantity.Name = "tb_supplyQuantity";
            this.tb_supplyQuantity.Size = new System.Drawing.Size(209, 27);
            this.tb_supplyQuantity.TabIndex = 19;
            this.tb_supplyQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.tb_supplyQuantity_Validating);
            // 
            // cb_supplyName
            // 
            this.cb_supplyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplyName.Font = new System.Drawing.Font("Heebo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_supplyName.FormattingEnabled = true;
            this.cb_supplyName.Location = new System.Drawing.Point(182, 55);
            this.cb_supplyName.Name = "cb_supplyName";
            this.cb_supplyName.Size = new System.Drawing.Size(209, 27);
            this.cb_supplyName.TabIndex = 18;
            this.cb_supplyName.SelectedIndexChanged += new System.EventHandler(this.cb_supplyName_SelectedIndexChanged);
            this.cb_supplyName.Validating += new System.ComponentModel.CancelEventHandler(this.cb_supplyName_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(62, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "P.O. No.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(62, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(62, 155);
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
            this.label6.Location = new System.Drawing.Point(62, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(62, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(62, 56);
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
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(221, 363);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 35);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Location = new System.Drawing.Point(340, 363);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(113, 35);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UpdateSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator: Update Supply";
            this.Load += new System.EventHandler(this.UpdateSupply_Load);
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
        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private Button btn_cancel;
        private Button btn_update;
        private TextBox tb_supplyPONumber;
        private TextBox tb_supplyTotalCost;
        private ComboBox cb_supplyUnit;
        private ComboBox cb_supplyType;
        private TextBox tb_supplyQuantity;
        private ComboBox cb_supplyName;
        private ErrorProvider errorProvider;
    }
}