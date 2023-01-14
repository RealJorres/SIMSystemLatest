namespace SIMSystem.SODashboardComponents
{
    partial class RISPlate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RISPlate));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_risNumber = new System.Windows.Forms.Label();
            this.lbl_requester = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_indicator = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "RIS";
            // 
            // lbl_risNumber
            // 
            this.lbl_risNumber.AutoSize = true;
            this.lbl_risNumber.Font = new System.Drawing.Font("Heebo", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_risNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_risNumber.Location = new System.Drawing.Point(46, 104);
            this.lbl_risNumber.Name = "lbl_risNumber";
            this.lbl_risNumber.Size = new System.Drawing.Size(52, 13);
            this.lbl_risNumber.TabIndex = 1;
            this.lbl_risNumber.Text = "RISNumber";
            // 
            // lbl_requester
            // 
            this.lbl_requester.AutoSize = true;
            this.lbl_requester.Font = new System.Drawing.Font("Heebo", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_requester.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_requester.Location = new System.Drawing.Point(28, 91);
            this.lbl_requester.Name = "lbl_requester";
            this.lbl_requester.Size = new System.Drawing.Size(73, 13);
            this.lbl_requester.TabIndex = 2;
            this.lbl_requester.Text = "RequesterName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Heebo", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "By:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Heebo", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RIS No.:";
            // 
            // panel_indicator
            // 
            this.panel_indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel_indicator.Location = new System.Drawing.Point(86, 3);
            this.panel_indicator.Name = "panel_indicator";
            this.panel_indicator.Size = new System.Drawing.Size(15, 15);
            this.panel_indicator.TabIndex = 5;
            // 
            // RISPlate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.panel_indicator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_requester);
            this.Controls.Add(this.lbl_risNumber);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RISPlate";
            this.Size = new System.Drawing.Size(108, 120);
            this.Load += new System.EventHandler(this.RISPlate_Load);
            this.Click += new System.EventHandler(this.RISPlate_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_risNumber;
        private Label lbl_requester;
        private Label label2;
        private Label label3;
        private Panel panel_indicator;
        private ToolTip toolTip1;
    }
}
