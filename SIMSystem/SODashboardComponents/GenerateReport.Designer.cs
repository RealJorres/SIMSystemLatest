namespace SIMSystem.SODashboardComponents
{
    partial class GenerateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReport));
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.cb_year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fc = new System.Windows.Forms.Label();
            this.lbl_daterange = new System.Windows.Forms.Label();
            this.lbl_en = new System.Windows.Forms.Label();
            this.pb_report = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_report)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Heebo Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(733, 473);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cb_month
            // 
            this.cb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_month.FormattingEnabled = true;
            this.cb_month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cb_month.Location = new System.Drawing.Point(64, 6);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(40, 26);
            this.cb_month.TabIndex = 3;
            // 
            // cb_year
            // 
            this.cb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_year.FormattingEnabled = true;
            this.cb_year.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033"});
            this.cb_year.Location = new System.Drawing.Point(157, 6);
            this.cb_year.Name = "cb_year";
            this.cb_year.Size = new System.Drawing.Size(54, 26);
            this.cb_year.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_generate.FlatAppearance.BorderSize = 0;
            this.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.Location = new System.Drawing.Point(228, 6);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 26);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_fc);
            this.panel1.Controls.Add(this.lbl_daterange);
            this.panel1.Controls.Add(this.lbl_en);
            this.panel1.Controls.Add(this.pb_report);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 428);
            this.panel1.TabIndex = 7;
            // 
            // lbl_fc
            // 
            this.lbl_fc.AutoSize = true;
            this.lbl_fc.BackColor = System.Drawing.Color.White;
            this.lbl_fc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fc.Location = new System.Drawing.Point(105, 128);
            this.lbl_fc.Name = "lbl_fc";
            this.lbl_fc.Size = new System.Drawing.Size(79, 15);
            this.lbl_fc.TabIndex = 5;
            this.lbl_fc.Text = "Regular Fund";
            // 
            // lbl_daterange
            // 
            this.lbl_daterange.AutoSize = true;
            this.lbl_daterange.BackColor = System.Drawing.Color.White;
            this.lbl_daterange.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_daterange.Location = new System.Drawing.Point(568, 128);
            this.lbl_daterange.Name = "lbl_daterange";
            this.lbl_daterange.Size = new System.Drawing.Size(0, 15);
            this.lbl_daterange.TabIndex = 4;
            // 
            // lbl_en
            // 
            this.lbl_en.AutoSize = true;
            this.lbl_en.BackColor = System.Drawing.Color.White;
            this.lbl_en.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_en.Location = new System.Drawing.Point(101, 109);
            this.lbl_en.Name = "lbl_en";
            this.lbl_en.Size = new System.Drawing.Size(219, 15);
            this.lbl_en.TabIndex = 3;
            this.lbl_en.Text = "PHILIPPINE STATISTICS AUTHORITY";
            // 
            // pb_report
            // 
            this.pb_report.BackgroundImage = global::SIMSystem.Properties.Resources.RSMIi_1;
            this.pb_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb_report.Location = new System.Drawing.Point(0, 0);
            this.pb_report.Name = "pb_report";
            this.pb_report.Size = new System.Drawing.Size(813, 957);
            this.pb_report.TabIndex = 2;
            this.pb_report.TabStop = false;
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.cb_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Heebo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateReport";
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private Label label1;
        private Button btn_save;
        private ComboBox cb_month;
        private ComboBox cb_year;
        private Label label2;
        private Button btn_generate;
        private Panel panel1;
        private PictureBox pb_report;
        private Label lbl_fc;
        private Label lbl_daterange;
        private Label lbl_en;
    }
}