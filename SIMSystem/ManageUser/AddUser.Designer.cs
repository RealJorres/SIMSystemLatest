namespace SIMSystem.ManageUser
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_notification = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_empType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_empId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_address = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_confirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel_sigCanvas = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_signature = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 74);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SIMSystem.Properties.Resources.psa_banner_dark;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.cb_notification);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cb_empType);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tb_empId);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_address);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_lastName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_firstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 375);
            this.panel1.TabIndex = 3;
            // 
            // cb_notification
            // 
            this.cb_notification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_notification.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_notification.FormattingEnabled = true;
            this.cb_notification.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cb_notification.Location = new System.Drawing.Point(97, 265);
            this.cb_notification.Name = "cb_notification";
            this.cb_notification.Size = new System.Drawing.Size(203, 30);
            this.cb_notification.TabIndex = 15;
            this.cb_notification.Validating += new System.ComponentModel.CancelEventHandler(this.cb_notification_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(3, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 22);
            this.label13.TabIndex = 14;
            this.label13.Text = "Notification:";
            // 
            // cb_empType
            // 
            this.cb_empType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_empType.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_empType.FormattingEnabled = true;
            this.cb_empType.Items.AddRange(new object[] {
            "Supply Officer",
            "Chief Statistical Specialist",
            "Regular Employee"});
            this.cb_empType.Location = new System.Drawing.Point(97, 229);
            this.cb_empType.Name = "cb_empType";
            this.cb_empType.Size = new System.Drawing.Size(203, 30);
            this.cb_empType.TabIndex = 13;
            this.cb_empType.Validating += new System.ComponentModel.CancelEventHandler(this.cb_empType_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(3, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Emp. Type:";
            // 
            // tb_empId
            // 
            this.tb_empId.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_empId.Location = new System.Drawing.Point(97, 49);
            this.tb_empId.Name = "tb_empId";
            this.tb_empId.Size = new System.Drawing.Size(203, 30);
            this.tb_empId.TabIndex = 2;
            this.tb_empId.Validating += new System.ComponentModel.CancelEventHandler(this.tb_empId_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(3, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Emp. ID:";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(97, 193);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(203, 30);
            this.tb_email.TabIndex = 9;
            this.tb_email.Validating += new System.ComponentModel.CancelEventHandler(this.tb_email_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // cb_address
            // 
            this.cb_address.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_address.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_address.FormattingEnabled = true;
            this.cb_address.Items.AddRange(new object[] {
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
            this.cb_address.Location = new System.Drawing.Point(97, 157);
            this.cb_address.Name = "cb_address";
            this.cb_address.Size = new System.Drawing.Size(203, 30);
            this.cb_address.TabIndex = 7;
            this.cb_address.Validating += new System.ComponentModel.CancelEventHandler(this.cb_address_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address:";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_lastName.Location = new System.Drawing.Point(97, 121);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(203, 30);
            this.tb_lastName.TabIndex = 5;
            this.tb_lastName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_lastName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_firstName.Location = new System.Drawing.Point(97, 85);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(203, 30);
            this.tb_firstName.TabIndex = 3;
            this.tb_firstName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_firstName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(3, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 1);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Heebo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fill-up the user information";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.tb_confirmPassword);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tb_password);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.tb_username);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(412, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 168);
            this.panel4.TabIndex = 4;
            // 
            // tb_confirmPassword
            // 
            this.tb_confirmPassword.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_confirmPassword.Location = new System.Drawing.Point(147, 121);
            this.tb_confirmPassword.Name = "tb_confirmPassword";
            this.tb_confirmPassword.Size = new System.Drawing.Size(203, 30);
            this.tb_confirmPassword.TabIndex = 9;
            this.tb_confirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tb_confirmPassword_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Confirm Password:";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(147, 85);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(203, 30);
            this.tb_password.TabIndex = 5;
            this.tb_password.Validating += new System.ComponentModel.CancelEventHandler(this.tb_password_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Password:";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_username.Location = new System.Drawing.Point(147, 49);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(203, 30);
            this.tb_username.TabIndex = 3;
            this.tb_username.Validating += new System.ComponentModel.CancelEventHandler(this.tb_username_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(3, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Username:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(3, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 1);
            this.panel5.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Heebo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fill-up the login credential";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Controls.Add(this.panel_sigCanvas);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.lbl_signature);
            this.panel6.Location = new System.Drawing.Point(412, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(376, 201);
            this.panel6.TabIndex = 5;
            // 
            // panel_sigCanvas
            // 
            this.panel_sigCanvas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_sigCanvas.Location = new System.Drawing.Point(3, 36);
            this.panel_sigCanvas.Name = "panel_sigCanvas";
            this.panel_sigCanvas.Size = new System.Drawing.Size(370, 160);
            this.panel_sigCanvas.TabIndex = 4;
            this.panel_sigCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_sigCanvas_MouseDown);
            this.panel_sigCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_sigCanvas_MouseMove);
            this.panel_sigCanvas.Validating += new System.ComponentModel.CancelEventHandler(this.panel_sigCanvas_Validating);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Location = new System.Drawing.Point(3, 29);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(370, 1);
            this.panel7.TabIndex = 3;
            // 
            // lbl_signature
            // 
            this.lbl_signature.AutoSize = true;
            this.lbl_signature.Font = new System.Drawing.Font("Heebo Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_signature.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_signature.Location = new System.Drawing.Point(3, 7);
            this.lbl_signature.Name = "lbl_signature";
            this.lbl_signature.Size = new System.Drawing.Size(128, 24);
            this.lbl_signature.TabIndex = 2;
            this.lbl_signature.Text = "User\'s Signature";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Location = new System.Drawing.Point(672, 461);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 42);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.CausesValidation = false;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Heebo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(553, 461);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 42);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator: Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private TextBox tb_lastName;
        private Label label3;
        private TextBox tb_firstName;
        private Label label2;
        private Label label4;
        private TextBox tb_email;
        private Label label5;
        private ComboBox cb_address;
        private Panel panel4;
        private TextBox tb_confirmPassword;
        private Label label6;
        private TextBox tb_password;
        private Label label8;
        private TextBox tb_username;
        private Label label9;
        private Panel panel5;
        private Label label10;
        private Panel panel6;
        private Panel panel7;
        private Label lbl_signature;
        private ComboBox cb_notification;
        private Label label13;
        private ComboBox cb_empType;
        private Label label12;
        private TextBox tb_empId;
        private Label label11;
        private Panel panel_sigCanvas;
        private Button btn_add;
        private Button btn_cancel;
        private ErrorProvider errorProvider;
    }
}