namespace SIMSystem.PartialForms
{
    partial class RisMiniSupply
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
            this.cb_supply = new System.Windows.Forms.ComboBox();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_isAvailable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_currentCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_supply
            // 
            this.cb_supply.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supply.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_supply.FormattingEnabled = true;
            this.cb_supply.Location = new System.Drawing.Point(3, 3);
            this.cb_supply.Name = "cb_supply";
            this.cb_supply.Size = new System.Drawing.Size(199, 26);
            this.cb_supply.TabIndex = 0;
            this.cb_supply.SelectedIndexChanged += new System.EventHandler(this.cb_supply_SelectedIndexChanged);
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_unit.Location = new System.Drawing.Point(238, 6);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(30, 18);
            this.lbl_unit.TabIndex = 1;
            this.lbl_unit.Text = "Unit";
            // 
            // tb_quantity
            // 
            this.tb_quantity.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_quantity.Enabled = false;
            this.tb_quantity.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_quantity.Location = new System.Drawing.Point(327, 3);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(124, 25);
            this.tb_quantity.TabIndex = 2;
            this.tb_quantity.TextChanged += new System.EventHandler(this.tb_quantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(567, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stock Available?";
            // 
            // lbl_isAvailable
            // 
            this.lbl_isAvailable.AutoSize = true;
            this.lbl_isAvailable.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_isAvailable.Location = new System.Drawing.Point(670, 6);
            this.lbl_isAvailable.Name = "lbl_isAvailable";
            this.lbl_isAvailable.Size = new System.Drawing.Size(48, 18);
            this.lbl_isAvailable.TabIndex = 4;
            this.lbl_isAvailable.Text = "Yes/No";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 1);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Heebo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(724, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_currentCount
            // 
            this.lbl_currentCount.AutoSize = true;
            this.lbl_currentCount.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_currentCount.Location = new System.Drawing.Point(491, 6);
            this.lbl_currentCount.Name = "lbl_currentCount";
            this.lbl_currentCount.Size = new System.Drawing.Size(29, 18);
            this.lbl_currentCount.TabIndex = 7;
            this.lbl_currentCount.Text = "999";
            // 
            // RisMiniSupply
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lbl_currentCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_isAvailable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.lbl_unit);
            this.Controls.Add(this.cb_supply);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "RisMiniSupply";
            this.Size = new System.Drawing.Size(818, 33);
            this.Load += new System.EventHandler(this.RisMiniSupply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_unit;
        private Label label1;
        private Label lbl_isAvailable;
        private Panel panel1;
        private Button button1;
        private Label lbl_currentCount;
        public ComboBox cb_supply;
        public TextBox tb_quantity;
    }
}
