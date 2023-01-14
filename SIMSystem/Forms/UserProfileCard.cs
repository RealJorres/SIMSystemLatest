using MySql.Data.MySqlClient;
using SIMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMSystem.Forms
{
    public partial class UserProfileCard : Form
    {
        User user;

        //for signature
        Point current = new Point();
        Point old = new Point();
        Graphics g;
        Graphics g2;
        Pen p = new Pen(Color.Black, 11);
        Bitmap surface;
        //end signature


        public UserProfileCard(User u)
        {
            InitializeComponent();
            user = u;

            
        }

        private void UserProfileCard_Load(object sender, EventArgs e)
        {
            PopulateDetails();
        }

        private void PopulateDetails()
        {
            lbl_name.Text = $"{user.Firstname} {user.Lastname}";
            lbl_email.Text = user.Email;
            lbl_address.Text = user.Address;
            lbl_type.Text = user.Type;
            pb_profileImage.Image = user.ProfileImage == null ? Properties.Resources.user__1_ : ConvertSignature.toImage(user.ProfileImage);
            if (user.Type != "Admin")
            {
                pictureBox1.Image = ConvertSignature.toImage(user.Signature);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (button1.Text == "Save Picture")
            {
                ConnectionDB connection = new ConnectionDB();
                if (connection.Open())
                {
                    try
                    {
                        MySqlCommand saveImage = new MySqlCommand(@"
                        UPDATE user SET emp_profileImage=@img WHERE emp_id=@id;", connection.connection);
                        saveImage.Parameters.Add("@img", MySqlDbType.MediumBlob).Value = ConvertSignature.toBinaryArray(pb_profileImage.Image, ImageFormat.Png);
                        saveImage.Parameters.Add("@id", MySqlDbType.VarChar).Value = user.Id;
                        
                        if(saveImage.ExecuteNonQuery() > 0)
                        {
                            user.ProfileImage = ConvertSignature.toBinaryArray(pb_profileImage.Image, ImageFormat.Png);
                            MessageBox.Show("New profile picture saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1.Text = "Edit Picture";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error saving new profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    ConnectionDB.FailMessage();
                }
            }
            else if(button1.Text == "Edit Picture")
            {
                openFileDialog.Title = "Select a PNG Image (2x2)";
                openFileDialog.Filter = "PNG Files|*.png;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pb_profileImage.Image = Image.FromFile(openFileDialog.FileName);
                    button1.Text = "Save Picture";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Edit Signature")
            {
                //change the text of the button
                button2.Text = "Save Signature";

                //remove the current signature
                pictureBox1.Image = null;

                
                g = pictureBox1.CreateGraphics();
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
                surface = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                g2 = Graphics.FromImage(surface);
                pictureBox1.BackgroundImage = surface;
                pictureBox1.BackgroundImageLayout = ImageLayout.None;
                p.Width = (float)2;

                //register mouseEvents for pictureBox
                pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
                pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);

            }
            else if(button2.Text == "Save Signature")
            {
                //change the text of the button
                button2.Text = "Edit Signature";
                //unregister mouseEvents for pictureBox
                pictureBox1.MouseDown -= new MouseEventHandler(pictureBox1_MouseDown);
                pictureBox1.MouseMove -= new MouseEventHandler(pictureBox1_MouseMove);

                byte[] newSignature = ConvertSignature.toBinaryArray(surface, ImageFormat.Png);
                ConnectionDB connection = new ConnectionDB();
                if (connection.Open())
                {
                    try
                    {
                        using (MySqlCommand resetSig = new MySqlCommand(@"UPDATE User SET emp_signature = @sig WHERE User.emp_id = @id", connection.connection))
                        {
                            resetSig.Parameters.Add("@sig", MySqlDbType.MediumBlob).Value = newSignature;
                            resetSig.Parameters.Add("@id", MySqlDbType.String).Value = user.Id;
                            if (resetSig.ExecuteNonQuery() > 0)
                            {
                                user.Signature = newSignature;
                                pictureBox1.BackgroundImage = null;
                                pictureBox1.Image = ConvertSignature.toImage(newSignature);
                                MessageBox.Show("Your new signature has been save in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error updating the new signature.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    ConnectionDB.FailMessage();
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                g2.DrawLine(p, old, current);

                old = current;
            }
        }
    }
}
