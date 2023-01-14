namespace SIMSAdminControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_province = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_brgyTown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_emailAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator\'s Account Creation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMSAdminControl.Properties.Resources.psa_banner_dark;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 1);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(35, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_createAccount.FlatAppearance.BorderSize = 0;
            this.btn_createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createAccount.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_createAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_createAccount.Location = new System.Drawing.Point(640, 343);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(148, 40);
            this.btn_createAccount.TabIndex = 4;
            this.btn_createAccount.Text = "Create Account";
            this.btn_createAccount.UseVisualStyleBackColor = false;
            this.btn_createAccount.Click += new System.EventHandler(this.btn_createAccount_Click);
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id.Location = new System.Drawing.Point(135, 142);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(236, 30);
            this.tb_id.TabIndex = 5;
            this.tb_id.Validating += new System.ComponentModel.CancelEventHandler(this.tb_id_Validating);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_username.Location = new System.Drawing.Point(531, 142);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(236, 30);
            this.tb_username.TabIndex = 7;
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_username_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(431, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(531, 178);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(236, 30);
            this.tb_password.TabIndex = 9;
            this.tb_password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_password_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(431, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_firstName.Location = new System.Drawing.Point(135, 178);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(236, 30);
            this.tb_firstName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(35, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "First Name:";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_lastName.Location = new System.Drawing.Point(135, 214);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(236, 30);
            this.tb_lastName.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(35, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Last Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_province);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_brgyTown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(431, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 120);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // tb_province
            // 
            this.tb_province.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_province.Location = new System.Drawing.Point(151, 66);
            this.tb_province.Name = "tb_province";
            this.tb_province.ReadOnly = true;
            this.tb_province.Size = new System.Drawing.Size(179, 30);
            this.tb_province.TabIndex = 14;
            this.tb_province.Text = "Marinduque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Province:";
            // 
            // cb_brgyTown
            // 
            this.cb_brgyTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_brgyTown.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_brgyTown.FormattingEnabled = true;
            this.cb_brgyTown.Items.AddRange(new object[] {
            "Agot, Boac",
            "Agumaymayan, Boac",
            "Amoingon, Boac",
            "Apitong, Boac",
            "Balagasan, Boac",
            "Balaring, Boac",
            "Balimbing, Boac",
            "Balogo, Boac",
            "Bamban, Boac",
            "Bangbangalon, Boac",
            "Bantad, Boac",
            "Bantay, Boac",
            "Bayuti, Boac",
            "Binunga, Boac",
            "Boi, Boac",
            "Boton, Boac",
            "Buliasnin, Boac",
            "Bunganay, Boac",
            "Caganhao, Boac",
            "Canat, Boac",
            "Catubugan, Boac",
            "Cawit, Boac",
            "Daig, Boac",
            "Daypay, Boac",
            "Duyay, Boac",
            "Hinapulan, Boac",
            "Ihatub, Boac",
            "Isok I, Boac",
            "Isok II Poblacion, Boac",
            "Laylay, Boac",
            "Lupac, Boac",
            "Mahinhin, Boac",
            "Mainit, Boac",
            "Malbog, Boac",
            "Maligaya, Boac",
            "Malusak, Boac",
            "Mansiwat, Boac",
            "Mataas na Bayan, Boac",
            "Maybo, Boac",
            "Mercado, Boac",
            "Murallon, Boac",
            "Ogbac, Boac",
            "Pawa, Boac",
            "Pili, Boac",
            "Poctoy, Boac",
            "Poras, Boac",
            "Puting Buhangin, Boac",
            "Puyog, Boac",
            "Sabong, Boac",
            "San Miguel, Boac",
            "Santol, Boac",
            "Sawi, Boac",
            "Tabi, Boac",
            "Tabigue, Boac",
            "Tagwak, Boac",
            "Tambunan, Boac",
            "Tampus, Boac",
            "Tanza, Boac",
            "Tugos, Boac",
            "Tumagabok, Boac",
            "Tumapon, Boac",
            "Bagacay, Buenavista",
            "Bagtingon, Buenavista",
            "Barangay I, Buenavista",
            "Barangay II, Buenavista",
            "Barangay III, Buenavista",
            "Barangay IV, Buenavista",
            "Bicas-bicas, Buenavista",
            "Caigangan, Buenavista",
            "Daykitin, Buenavista",
            "Libas, Buenavista",
            "Malbog, Buenavista",
            "Sihi, Buenavista",
            "Timbo, Buenavista",
            "Tungib-Lipata, Buenavista",
            "Yook, Buenavista",
            "Antipolo, Gasan",
            "Bachao Ibaba, Gasan",
            "Bachao Ilaya, Gasan",
            "Bacongbacong, Gasan",
            "Bahi, Gasan",
            "Bangbang, Gasan",
            "Banot, Gasan",
            "Banuyo, Gasan",
            "Barangay I, Gasan",
            "Barangay II, Gasan",
            "Barangay III, Gasan",
            "Bognuyan, Gasan",
            "Cabugao, Gasan",
            "Dawis, Gasan",
            "Dili, Gasan",
            "Libtangin, Gasan",
            "Mahunig, Gasan",
            "Mangiliol, Gasan",
            "Masiga, Gasan",
            "Matandang Gasan, Gasan",
            "Pangi, Gasan",
            "Pingan, Gasan",
            "Tabionan, Gasan",
            "Tapuyan, Gasan",
            "Tiguion, Gasan",
            "Anapog-Sibucao, Mogpog",
            "Argao, Mogpog",
            "Balanacan, Mogpog",
            "Banto, Mogpog",
            "Bintakay, Mogpog",
            "Bocboc, Mogpog",
            "Butansapa, Mogpog",
            "Candahon, Mogpog",
            "Capayang, Mogpog",
            "Danao, Mogpog",
            "Dulong Bayan, Mogpog",
            "Gitnang Bayan, Mogpog",
            "Guisian, Mogpog",
            "Hinadharan, Mogpog",
            "Hinanggayon, Mogpog",
            "Ino, Mogpog",
            "Janagdong, Mogpog",
            "Lamesa, Mogpog",
            "Laon, Mogpog",
            "Magapua, Mogpog",
            "Malayak, Mogpog",
            "Malusak, Mogpog",
            "Mampaitan, Mogpog",
            "Mangyan-Mababad, Mogpog",
            "Market Site, Mogpog",
            "Mataas na Bayan, Mogpog",
            "Mendez, Mogpog",
            "Nangka I, Mogpog",
            "Nangka II, Mogpog",
            "Paye, Mogpog",
            "Pili, Mogpog",
            "Puting Buhangin, Mogpog",
            "Sayao, Mogpog",
            "Silangan, Mogpog",
            "Sumangga, Mogpog",
            "Tarug, Mogpog",
            "Villa Mendez, Mogpog",
            "Alobo, Santa Cruz",
            "Angas, Santa Cruz",
            "Aturan, Santa Cruz",
            "Bagong Silang Poblacion, Santa Cruz",
            "Baguidbirin, Santa Cruz",
            "Baliis, Santa Cruz",
            "Balogo, Santa Cruz",
            "Banahaw Poblacion, Santa Cruz",
            "Bangcuangan, Santa Cruz",
            "Banogbog, Santa Cruz",
            "Biga, Santa Cruz",
            "Botilao, Santa Cruz",
            "Buyabod, Santa Cruz",
            "Dating Bayan, Santa Cruz",
            "Devilla, Santa Cruz",
            "Dolores, Santa Cruz",
            "Haguimit, Santa Cruz",
            "Hupi, Santa Cruz",
            "Ipil, Santa Cruz",
            "Jolo, Santa Cruz",
            "Kaganhao, Santa Cruz",
            "Kalangkang, Santa Cruz",
            "Kamandugan, Santa Cruz",
            "Kasily, Santa Cruz",
            "Kilo-kilo, Santa Cruz",
            "Kiñaman, Santa Cruz",
            "Labo, Santa Cruz",
            "Lamesa, Santa Cruz",
            "Landy, Santa Cruz",
            "Lapu-lapu Poblacion, Santa Cruz",
            "Libjo, Santa Cruz",
            "Lipa, Santa Cruz",
            "Lusok, Santa Cruz",
            "Maharlika Poblacion, Santa Cruz",
            "Makulapnit, Santa Cruz",
            "Maniwaya, Santa Cruz",
            "Manlibunan, Santa Cruz",
            "Masaguisi, Santa Cruz",
            "Masalukot, Santa Cruz",
            "Matalaba, Santa Cruz",
            "Mongpong, Santa Cruz",
            "Morales, Santa Cruz",
            "Napo, Santa Cruz",
            "Pag-asa Poblacion, Santa Cruz",
            "Pantayin, Santa Cruz",
            "Polo, Santa Cruz",
            "Pulong-Parang, Santa Cruz",
            "Punong, Santa Cruz",
            "San Antonio, Santa Cruz",
            "San Isidro, Santa Cruz",
            "Tagum, Santa Cruz",
            "Tamayo, Santa Cruz",
            "Tambangan, Santa Cruz",
            "Tawiran, Santa Cruz",
            "Taytay, Santa Cruz",
            "Bangwayin, Torrijos",
            "Bayakbakin, Torrijos",
            "Bolo, Torrijos",
            "Bonliw, Torrijos",
            "Buangan, Torrijos",
            "Cabuyo, Torrijos",
            "Cagpo, Torrijos",
            "Dampulan, Torrijos",
            "Kay Duke, Torrijos",
            "Mabuhay, Torrijos",
            "Makawayan, Torrijos",
            "Malibago, Torrijos",
            "Malinao, Torrijos",
            "Maranlig, Torrijos",
            "Marlangga, Torrijos",
            "Matuyatuya, Torrijos",
            "Nangka, Torrijos",
            "Pakaskasan, Torrijos",
            "Payanas, Torrijos",
            "Poblacion, Torrijos",
            "Poctoy, Torrijos",
            "Sibuyao, Torrijos",
            "Suha, Torrijos",
            "Talawan, Torrijos",
            "Tigwi, Torrijos"});
            this.cb_brgyTown.Location = new System.Drawing.Point(151, 23);
            this.cb_brgyTown.Name = "cb_brgyTown";
            this.cb_brgyTown.Size = new System.Drawing.Size(179, 30);
            this.cb_brgyTown.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Brgy., Municipality: ";
            // 
            // tb_emailAddress
            // 
            this.tb_emailAddress.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_emailAddress.Location = new System.Drawing.Point(135, 250);
            this.tb_emailAddress.Name = "tb_emailAddress";
            this.tb_emailAddress.Size = new System.Drawing.Size(236, 30);
            this.tb_emailAddress.TabIndex = 16;
            this.tb_emailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tb_emailAddress_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(35, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.tb_emailAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIMSystem: Admin Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Button btn_createAccount;
        private TextBox tb_id;
        private TextBox tb_username;
        private Label label3;
        private TextBox tb_password;
        private Label label4;
        private TextBox tb_firstName;
        private Label label5;
        private TextBox tb_lastName;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox tb_province;
        private Label label8;
        private ComboBox cb_brgyTown;
        private Label label7;
        private TextBox tb_emailAddress;
        private Label label9;
        private ErrorProvider errorProvider;
        private OpenFileDialog openFileDialog;
    }
}