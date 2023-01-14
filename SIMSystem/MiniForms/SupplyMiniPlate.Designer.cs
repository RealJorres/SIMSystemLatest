namespace SIMSystem.MiniForms
{
    partial class SupplyMiniPlate
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
            this.lbl_supplyName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_supplyQuantity = new System.Windows.Forms.Label();
            this.lbl_supplyCLevel = new System.Windows.Forms.Label();
            this.lbl_supplyUnitCost = new System.Windows.Forms.Label();
            this.lbl_supplyTotalCost = new System.Windows.Forms.Label();
            this.lbl_supplyUnit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_supplyName
            // 
            this.lbl_supplyName.AutoSize = true;
            this.lbl_supplyName.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyName.Location = new System.Drawing.Point(3, 9);
            this.lbl_supplyName.Name = "lbl_supplyName";
            this.lbl_supplyName.Size = new System.Drawing.Size(78, 18);
            this.lbl_supplyName.TabIndex = 0;
            this.lbl_supplyName.Text = "SupplyName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 1);
            this.panel1.TabIndex = 1;
            // 
            // lbl_supplyQuantity
            // 
            this.lbl_supplyQuantity.AutoSize = true;
            this.lbl_supplyQuantity.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyQuantity.Location = new System.Drawing.Point(131, 9);
            this.lbl_supplyQuantity.Name = "lbl_supplyQuantity";
            this.lbl_supplyQuantity.Size = new System.Drawing.Size(91, 18);
            this.lbl_supplyQuantity.TabIndex = 2;
            this.lbl_supplyQuantity.Text = "SupplyQuantity";
            // 
            // lbl_supplyCLevel
            // 
            this.lbl_supplyCLevel.AutoSize = true;
            this.lbl_supplyCLevel.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyCLevel.Location = new System.Drawing.Point(306, 9);
            this.lbl_supplyCLevel.Name = "lbl_supplyCLevel";
            this.lbl_supplyCLevel.Size = new System.Drawing.Size(80, 18);
            this.lbl_supplyCLevel.TabIndex = 3;
            this.lbl_supplyCLevel.Text = "SupplyCLevel";
            // 
            // lbl_supplyUnitCost
            // 
            this.lbl_supplyUnitCost.AutoSize = true;
            this.lbl_supplyUnitCost.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyUnitCost.Location = new System.Drawing.Point(428, 9);
            this.lbl_supplyUnitCost.Name = "lbl_supplyUnitCost";
            this.lbl_supplyUnitCost.Size = new System.Drawing.Size(92, 18);
            this.lbl_supplyUnitCost.TabIndex = 4;
            this.lbl_supplyUnitCost.Text = "SupplyUnitCost";
            // 
            // lbl_supplyTotalCost
            // 
            this.lbl_supplyTotalCost.AutoSize = true;
            this.lbl_supplyTotalCost.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyTotalCost.Location = new System.Drawing.Point(546, 9);
            this.lbl_supplyTotalCost.Name = "lbl_supplyTotalCost";
            this.lbl_supplyTotalCost.Size = new System.Drawing.Size(98, 18);
            this.lbl_supplyTotalCost.TabIndex = 5;
            this.lbl_supplyTotalCost.Text = "SupplyTotalCost";
            // 
            // lbl_supplyUnit
            // 
            this.lbl_supplyUnit.AutoSize = true;
            this.lbl_supplyUnit.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyUnit.Location = new System.Drawing.Point(226, 9);
            this.lbl_supplyUnit.Name = "lbl_supplyUnit";
            this.lbl_supplyUnit.Size = new System.Drawing.Size(67, 18);
            this.lbl_supplyUnit.TabIndex = 6;
            this.lbl_supplyUnit.Text = "SupplyUnit";
            // 
            // SupplyMiniPlate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lbl_supplyUnit);
            this.Controls.Add(this.lbl_supplyTotalCost);
            this.Controls.Add(this.lbl_supplyUnitCost);
            this.Controls.Add(this.lbl_supplyCLevel);
            this.Controls.Add(this.lbl_supplyQuantity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_supplyName);
            this.Name = "SupplyMiniPlate";
            this.Size = new System.Drawing.Size(660, 35);
            this.Load += new System.EventHandler(this.SupplyMiniPlate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_supplyName;
        private Panel panel1;
        private Label lbl_supplyQuantity;
        private Label lbl_supplyCLevel;
        private Label lbl_supplyUnitCost;
        private Label lbl_supplyTotalCost;
        private Label lbl_supplyUnit;
    }
}
