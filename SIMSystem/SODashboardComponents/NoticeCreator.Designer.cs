namespace SIMSystem.SODashboardComponents
{
    partial class NoticeCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeCreator));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_what = new System.Windows.Forms.TextBox();
            this.tb_who = new System.Windows.Forms.TextBox();
            this.tb_where = new System.Windows.Forms.TextBox();
            this.dtp_when = new System.Windows.Forms.DateTimePicker();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Announcement Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 2);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "What:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Who:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "When:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Where:";
            // 
            // tb_what
            // 
            this.tb_what.Location = new System.Drawing.Point(108, 73);
            this.tb_what.Name = "tb_what";
            this.tb_what.Size = new System.Drawing.Size(282, 30);
            this.tb_what.TabIndex = 6;
            this.tb_what.Validating += new System.ComponentModel.CancelEventHandler(this.tb_what_Validating);
            // 
            // tb_who
            // 
            this.tb_who.Location = new System.Drawing.Point(108, 109);
            this.tb_who.Name = "tb_who";
            this.tb_who.Size = new System.Drawing.Size(282, 30);
            this.tb_who.TabIndex = 7;
            this.tb_who.Validating += new System.ComponentModel.CancelEventHandler(this.tb_who_Validating);
            // 
            // tb_where
            // 
            this.tb_where.Location = new System.Drawing.Point(108, 181);
            this.tb_where.Name = "tb_where";
            this.tb_where.Size = new System.Drawing.Size(282, 30);
            this.tb_where.TabIndex = 9;
            this.tb_where.Validating += new System.ComponentModel.CancelEventHandler(this.tb_where_Validating);
            // 
            // dtp_when
            // 
            this.dtp_when.Location = new System.Drawing.Point(108, 145);
            this.dtp_when.Name = "dtp_when";
            this.dtp_when.Size = new System.Drawing.Size(282, 30);
            this.dtp_when.TabIndex = 10;
            this.dtp_when.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_when_Validating);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_preview.FlatAppearance.BorderSize = 0;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.ForeColor = System.Drawing.Color.White;
            this.btn_preview.Location = new System.Drawing.Point(108, 217);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 31);
            this.btn_preview.TabIndex = 11;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Visible = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_post
            // 
            this.btn_post.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_post.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_post.FlatAppearance.BorderSize = 0;
            this.btn_post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_post.ForeColor = System.Drawing.Color.White;
            this.btn_post.Location = new System.Drawing.Point(315, 217);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 31);
            this.btn_post.TabIndex = 12;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = false;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // NoticeCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(434, 279);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.dtp_when);
            this.Controls.Add(this.tb_where);
            this.Controls.Add(this.tb_who);
            this.Controls.Add(this.tb_what);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "NoticeCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SIMSystem: Announcement Creator";
            this.Load += new System.EventHandler(this.NoticeCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_what;
        private TextBox tb_who;
        private TextBox tb_where;
        private DateTimePicker dtp_when;
        private Button btn_preview;
        private Button btn_post;
        private ErrorProvider errorProvider;
    }
}