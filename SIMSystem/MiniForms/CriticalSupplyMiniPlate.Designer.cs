namespace SIMSystem.MiniForms
{
    partial class CriticalSupplyMiniPlate
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
            this.lbl_supplyCriticalLevel = new System.Windows.Forms.Label();
            this.lbl_supplyQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_supplyName
            // 
            this.lbl_supplyName.AutoSize = true;
            this.lbl_supplyName.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyName.Location = new System.Drawing.Point(3, 9);
            this.lbl_supplyName.Name = "lbl_supplyName";
            this.lbl_supplyName.Size = new System.Drawing.Size(78, 18);
            this.lbl_supplyName.TabIndex = 1;
            this.lbl_supplyName.Text = "SupplyName";
            // 
            // lbl_supplyCriticalLevel
            // 
            this.lbl_supplyCriticalLevel.AutoSize = true;
            this.lbl_supplyCriticalLevel.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyCriticalLevel.Location = new System.Drawing.Point(215, 9);
            this.lbl_supplyCriticalLevel.Name = "lbl_supplyCriticalLevel";
            this.lbl_supplyCriticalLevel.Size = new System.Drawing.Size(110, 18);
            this.lbl_supplyCriticalLevel.TabIndex = 2;
            this.lbl_supplyCriticalLevel.Text = "SupplyCriticalLevel";
            // 
            // lbl_supplyQuantity
            // 
            this.lbl_supplyQuantity.AutoSize = true;
            this.lbl_supplyQuantity.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_supplyQuantity.Location = new System.Drawing.Point(450, 9);
            this.lbl_supplyQuantity.Name = "lbl_supplyQuantity";
            this.lbl_supplyQuantity.Size = new System.Drawing.Size(91, 18);
            this.lbl_supplyQuantity.TabIndex = 3;
            this.lbl_supplyQuantity.Text = "SupplyQuantity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 1);
            this.panel1.TabIndex = 4;
            // 
            // CriticalSupplyMiniPlate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_supplyQuantity);
            this.Controls.Add(this.lbl_supplyCriticalLevel);
            this.Controls.Add(this.lbl_supplyName);
            this.Name = "CriticalSupplyMiniPlate";
            this.Size = new System.Drawing.Size(660, 35);
            this.Load += new System.EventHandler(this.CriticalSupplyMiniPlate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_supplyName;
        private Label lbl_supplyCriticalLevel;
        private Label lbl_supplyQuantity;
        private Panel panel1;
    }
}
