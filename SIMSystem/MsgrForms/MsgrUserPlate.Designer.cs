namespace SIMSystem.MsgrForms
{
    partial class MsgrUserPlate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.pic_color = new System.Windows.Forms.PictureBox();
            this.pic_msg = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pb_userImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_msg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(38, 8);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(97, 17);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Juan Dela Cruz";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(38, 25);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(82, 15);
            this.lbl_position.TabIndex = 3;
            this.lbl_position.Text = "Supply Officer";
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.Green;
            this.pic_color.Location = new System.Drawing.Point(179, 25);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(15, 15);
            this.pic_color.TabIndex = 4;
            this.pic_color.TabStop = false;
            // 
            // pic_msg
            // 
            this.pic_msg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_msg.Image = global::SIMSystem.Properties.Resources.email;
            this.pic_msg.Location = new System.Drawing.Point(200, 22);
            this.pic_msg.Name = "pic_msg";
            this.pic_msg.Size = new System.Drawing.Size(25, 20);
            this.pic_msg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_msg.TabIndex = 5;
            this.pic_msg.TabStop = false;
            this.pic_msg.Click += new System.EventHandler(this.pic_msg_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pb_userImage
            // 
            this.pb_userImage.Image = global::SIMSystem.Properties.Resources.user;
            this.pb_userImage.Location = new System.Drawing.Point(5, 10);
            this.pb_userImage.Name = "pb_userImage";
            this.pb_userImage.Size = new System.Drawing.Size(32, 32);
            this.pb_userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_userImage.TabIndex = 6;
            this.pb_userImage.TabStop = false;
            // 
            // MsgrUserPlate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pb_userImage);
            this.Controls.Add(this.pic_msg);
            this.Controls.Add(this.pic_color);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MsgrUserPlate";
            this.Size = new System.Drawing.Size(236, 50);
            this.Load += new System.EventHandler(this.MsgrUserPlate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_msg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lbl_name;
        private Label lbl_position;
        private PictureBox pic_color;
        private PictureBox pic_msg;
        private System.Windows.Forms.Timer timer;
        private PictureBox pb_userImage;
    }
}
