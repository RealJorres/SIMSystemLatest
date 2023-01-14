namespace SIMSystem.MsgrForms
{
    partial class MessageOther
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
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Heebo Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(8, 106);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(85, 17);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "January 1, 2023";
            // 
            // lbl_content
            // 
            this.lbl_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.lbl_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_content.ForeColor = System.Drawing.Color.White;
            this.lbl_content.Location = new System.Drawing.Point(8, 8);
            this.lbl_content.MaxLength = 150;
            this.lbl_content.Multiline = true;
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.ReadOnly = true;
            this.lbl_content.Size = new System.Drawing.Size(270, 95);
            this.lbl_content.TabIndex = 2;
            this.lbl_content.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin tincidunt ut nisl " +
    "sit amet lacinia. Nullam sodales gravida venenatis. Sed a felis quis.";
            // 
            // MessageOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_content);
            this.Font = new System.Drawing.Font("Heebo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessageOther";
            this.Size = new System.Drawing.Size(286, 128);
            this.Load += new System.EventHandler(this.MessageOther_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_date;
        private TextBox lbl_content;
    }
}
