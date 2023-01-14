namespace SIMSystem.SODashboardComponents
{
    partial class RISPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RISPreview));
            this.btn_action = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_purpose = new System.Windows.Forms.Label();
            this.lbl_receivedDate = new System.Windows.Forms.Label();
            this.lbl_soDate = new System.Windows.Forms.Label();
            this.lbl_cssDate = new System.Windows.Forms.Label();
            this.lbl_requesterDate = new System.Windows.Forms.Label();
            this.lbl_receiverDesignation = new System.Windows.Forms.Label();
            this.lbl_requesterDesignation = new System.Windows.Forms.Label();
            this.lbl_receiverName = new System.Windows.Forms.Label();
            this.lbl_requeterName = new System.Windows.Forms.Label();
            this.lbl_risNumber = new System.Windows.Forms.Label();
            this.lbl_office = new System.Windows.Forms.Label();
            this.lbl_division = new System.Windows.Forms.Label();
            this.lbl_fundCluster = new System.Windows.Forms.Label();
            this.lbl_entityName = new System.Windows.Forms.Label();
            this.pb_receiverSignature = new System.Windows.Forms.PictureBox();
            this.pb_soSignature = new System.Windows.Forms.PictureBox();
            this.pb_cssSignature = new System.Windows.Forms.PictureBox();
            this.pb_requesterSignature = new System.Windows.Forms.PictureBox();
            this.pb_ris = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_receiverSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cssSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_requesterSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ris)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_action
            // 
            this.btn_action.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_action.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_action.FlatAppearance.BorderSize = 0;
            this.btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_action.Font = new System.Drawing.Font("Heebo Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_action.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_action.Location = new System.Drawing.Point(699, 453);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(103, 36);
            this.btn_action.TabIndex = 1;
            this.btn_action.Text = "Sign";
            this.btn_action.UseVisualStyleBackColor = false;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_purpose);
            this.panel1.Controls.Add(this.lbl_receivedDate);
            this.panel1.Controls.Add(this.lbl_soDate);
            this.panel1.Controls.Add(this.lbl_cssDate);
            this.panel1.Controls.Add(this.lbl_requesterDate);
            this.panel1.Controls.Add(this.lbl_receiverDesignation);
            this.panel1.Controls.Add(this.lbl_requesterDesignation);
            this.panel1.Controls.Add(this.lbl_receiverName);
            this.panel1.Controls.Add(this.lbl_requeterName);
            this.panel1.Controls.Add(this.lbl_risNumber);
            this.panel1.Controls.Add(this.lbl_office);
            this.panel1.Controls.Add(this.lbl_division);
            this.panel1.Controls.Add(this.lbl_fundCluster);
            this.panel1.Controls.Add(this.lbl_entityName);
            this.panel1.Controls.Add(this.pb_receiverSignature);
            this.panel1.Controls.Add(this.pb_soSignature);
            this.panel1.Controls.Add(this.pb_cssSignature);
            this.panel1.Controls.Add(this.pb_requesterSignature);
            this.panel1.Controls.Add(this.pb_ris);
            this.panel1.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 435);
            this.panel1.TabIndex = 2;
            // 
            // lbl_purpose
            // 
            this.lbl_purpose.AutoSize = true;
            this.lbl_purpose.BackColor = System.Drawing.Color.White;
            this.lbl_purpose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_purpose.Location = new System.Drawing.Point(93, 746);
            this.lbl_purpose.Name = "lbl_purpose";
            this.lbl_purpose.Size = new System.Drawing.Size(44, 15);
            this.lbl_purpose.TabIndex = 18;
            this.lbl_purpose.Text = "label13";
            // 
            // lbl_receivedDate
            // 
            this.lbl_receivedDate.AutoSize = true;
            this.lbl_receivedDate.BackColor = System.Drawing.Color.White;
            this.lbl_receivedDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_receivedDate.Location = new System.Drawing.Point(581, 956);
            this.lbl_receivedDate.Name = "lbl_receivedDate";
            this.lbl_receivedDate.Size = new System.Drawing.Size(0, 15);
            this.lbl_receivedDate.TabIndex = 17;
            // 
            // lbl_soDate
            // 
            this.lbl_soDate.AutoSize = true;
            this.lbl_soDate.BackColor = System.Drawing.Color.White;
            this.lbl_soDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soDate.Location = new System.Drawing.Point(426, 956);
            this.lbl_soDate.Name = "lbl_soDate";
            this.lbl_soDate.Size = new System.Drawing.Size(0, 15);
            this.lbl_soDate.TabIndex = 16;
            // 
            // lbl_cssDate
            // 
            this.lbl_cssDate.AutoSize = true;
            this.lbl_cssDate.BackColor = System.Drawing.Color.White;
            this.lbl_cssDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cssDate.Location = new System.Drawing.Point(273, 956);
            this.lbl_cssDate.Name = "lbl_cssDate";
            this.lbl_cssDate.Size = new System.Drawing.Size(0, 15);
            this.lbl_cssDate.TabIndex = 15;
            // 
            // lbl_requesterDate
            // 
            this.lbl_requesterDate.AutoSize = true;
            this.lbl_requesterDate.BackColor = System.Drawing.Color.White;
            this.lbl_requesterDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_requesterDate.Location = new System.Drawing.Point(132, 956);
            this.lbl_requesterDate.Name = "lbl_requesterDate";
            this.lbl_requesterDate.Size = new System.Drawing.Size(0, 15);
            this.lbl_requesterDate.TabIndex = 14;
            // 
            // lbl_receiverDesignation
            // 
            this.lbl_receiverDesignation.AutoSize = true;
            this.lbl_receiverDesignation.BackColor = System.Drawing.Color.White;
            this.lbl_receiverDesignation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_receiverDesignation.Location = new System.Drawing.Point(581, 932);
            this.lbl_receiverDesignation.Name = "lbl_receiverDesignation";
            this.lbl_receiverDesignation.Size = new System.Drawing.Size(0, 15);
            this.lbl_receiverDesignation.TabIndex = 13;
            // 
            // lbl_requesterDesignation
            // 
            this.lbl_requesterDesignation.AutoSize = true;
            this.lbl_requesterDesignation.BackColor = System.Drawing.Color.White;
            this.lbl_requesterDesignation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_requesterDesignation.Location = new System.Drawing.Point(132, 932);
            this.lbl_requesterDesignation.Name = "lbl_requesterDesignation";
            this.lbl_requesterDesignation.Size = new System.Drawing.Size(0, 15);
            this.lbl_requesterDesignation.TabIndex = 12;
            // 
            // lbl_receiverName
            // 
            this.lbl_receiverName.AutoSize = true;
            this.lbl_receiverName.BackColor = System.Drawing.Color.White;
            this.lbl_receiverName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_receiverName.Location = new System.Drawing.Point(581, 893);
            this.lbl_receiverName.Name = "lbl_receiverName";
            this.lbl_receiverName.Size = new System.Drawing.Size(0, 15);
            this.lbl_receiverName.TabIndex = 11;
            // 
            // lbl_requeterName
            // 
            this.lbl_requeterName.AutoSize = true;
            this.lbl_requeterName.BackColor = System.Drawing.Color.White;
            this.lbl_requeterName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_requeterName.Location = new System.Drawing.Point(132, 893);
            this.lbl_requeterName.Name = "lbl_requeterName";
            this.lbl_requeterName.Size = new System.Drawing.Size(0, 15);
            this.lbl_requeterName.TabIndex = 10;
            // 
            // lbl_risNumber
            // 
            this.lbl_risNumber.AutoSize = true;
            this.lbl_risNumber.BackColor = System.Drawing.Color.White;
            this.lbl_risNumber.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_risNumber.Location = new System.Drawing.Point(474, 169);
            this.lbl_risNumber.Name = "lbl_risNumber";
            this.lbl_risNumber.Size = new System.Drawing.Size(38, 15);
            this.lbl_risNumber.TabIndex = 9;
            this.lbl_risNumber.Text = "label5";
            // 
            // lbl_office
            // 
            this.lbl_office.AutoSize = true;
            this.lbl_office.BackColor = System.Drawing.Color.White;
            this.lbl_office.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_office.Location = new System.Drawing.Point(71, 169);
            this.lbl_office.Name = "lbl_office";
            this.lbl_office.Size = new System.Drawing.Size(38, 15);
            this.lbl_office.TabIndex = 8;
            this.lbl_office.Text = "label4";
            // 
            // lbl_division
            // 
            this.lbl_division.AutoSize = true;
            this.lbl_division.BackColor = System.Drawing.Color.White;
            this.lbl_division.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_division.Location = new System.Drawing.Point(82, 150);
            this.lbl_division.Name = "lbl_division";
            this.lbl_division.Size = new System.Drawing.Size(38, 15);
            this.lbl_division.TabIndex = 7;
            this.lbl_division.Text = "label3";
            // 
            // lbl_fundCluster
            // 
            this.lbl_fundCluster.AutoSize = true;
            this.lbl_fundCluster.BackColor = System.Drawing.Color.White;
            this.lbl_fundCluster.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fundCluster.Location = new System.Drawing.Point(582, 121);
            this.lbl_fundCluster.Name = "lbl_fundCluster";
            this.lbl_fundCluster.Size = new System.Drawing.Size(40, 15);
            this.lbl_fundCluster.TabIndex = 6;
            this.lbl_fundCluster.Text = "label2";
            // 
            // lbl_entityName
            // 
            this.lbl_entityName.AutoSize = true;
            this.lbl_entityName.BackColor = System.Drawing.Color.White;
            this.lbl_entityName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_entityName.Location = new System.Drawing.Point(108, 122);
            this.lbl_entityName.Name = "lbl_entityName";
            this.lbl_entityName.Size = new System.Drawing.Size(40, 15);
            this.lbl_entityName.TabIndex = 5;
            this.lbl_entityName.Text = "label1";
            // 
            // pb_receiverSignature
            // 
            this.pb_receiverSignature.BackColor = System.Drawing.Color.White;
            this.pb_receiverSignature.Location = new System.Drawing.Point(581, 844);
            this.pb_receiverSignature.Name = "pb_receiverSignature";
            this.pb_receiverSignature.Size = new System.Drawing.Size(130, 30);
            this.pb_receiverSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_receiverSignature.TabIndex = 4;
            this.pb_receiverSignature.TabStop = false;
            // 
            // pb_soSignature
            // 
            this.pb_soSignature.BackColor = System.Drawing.Color.White;
            this.pb_soSignature.Location = new System.Drawing.Point(426, 844);
            this.pb_soSignature.Name = "pb_soSignature";
            this.pb_soSignature.Size = new System.Drawing.Size(130, 30);
            this.pb_soSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_soSignature.TabIndex = 3;
            this.pb_soSignature.TabStop = false;
            // 
            // pb_cssSignature
            // 
            this.pb_cssSignature.BackColor = System.Drawing.Color.White;
            this.pb_cssSignature.Location = new System.Drawing.Point(273, 844);
            this.pb_cssSignature.Name = "pb_cssSignature";
            this.pb_cssSignature.Size = new System.Drawing.Size(130, 30);
            this.pb_cssSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cssSignature.TabIndex = 2;
            this.pb_cssSignature.TabStop = false;
            // 
            // pb_requesterSignature
            // 
            this.pb_requesterSignature.BackColor = System.Drawing.Color.White;
            this.pb_requesterSignature.Location = new System.Drawing.Point(132, 844);
            this.pb_requesterSignature.Name = "pb_requesterSignature";
            this.pb_requesterSignature.Size = new System.Drawing.Size(130, 30);
            this.pb_requesterSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_requesterSignature.TabIndex = 1;
            this.pb_requesterSignature.TabStop = false;
            // 
            // pb_ris
            // 
            this.pb_ris.Image = ((System.Drawing.Image)(resources.GetObject("pb_ris.Image")));
            this.pb_ris.Location = new System.Drawing.Point(3, 3);
            this.pb_ris.Name = "pb_ris";
            this.pb_ris.Size = new System.Drawing.Size(768, 1056);
            this.pb_ris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ris.TabIndex = 0;
            this.pb_ris.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // RISPreview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_action);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RISPreview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RIS Preview";
            this.Load += new System.EventHandler(this.RISPreview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_receiverSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_soSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cssSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_requesterSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_action;
        private Panel panel1;
        private PictureBox pb_ris;
        private PictureBox pb_receiverSignature;
        private PictureBox pb_soSignature;
        private PictureBox pb_cssSignature;
        private PictureBox pb_requesterSignature;
        private Label lbl_risNumber;
        private Label lbl_office;
        private Label lbl_division;
        private Label lbl_fundCluster;
        private Label lbl_entityName;
        private Label lbl_requeterName;
        private Label lbl_receivedDate;
        private Label lbl_soDate;
        private Label lbl_cssDate;
        private Label lbl_requesterDate;
        private Label lbl_receiverDesignation;
        private Label lbl_requesterDesignation;
        private Label lbl_receiverName;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label lbl_purpose;
    }
}
