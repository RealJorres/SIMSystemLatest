using SIMSystem.Forms;
using SIMSystem.ManageSupply;
using SIMSystem.ManageUser;
using SIMSystem.Model;
using SIMSystem.PartialForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMSystem.MiniForms
{
    public partial class PasswordConfirmation : Form
    {
        User user;
        UserMiniPlate userMiniPlateOwner;
        UpdateUser updateUserOwner;
        AddUser addUserOwner;
        AddSupply addSupplyOwner;
        UpdateSupply updateSupplyOwner;
        CreateRis createRisOwner;
        object owner;

        public PasswordConfirmation(UserMiniPlate o, User u)
        {
            InitializeComponent();
            user = u;
            userMiniPlateOwner = o;
            owner = userMiniPlateOwner;
        }

        public PasswordConfirmation(UpdateUser o, User u)
        {
            InitializeComponent();
            user = u;
            updateUserOwner = o;
            owner = updateUserOwner;
        }

        public PasswordConfirmation(AddUser o, User u)
        {
            InitializeComponent();
            user = u;
            addUserOwner = o;
            owner = addUserOwner;
        }

        public PasswordConfirmation(AddSupply o, User u)
        {
            InitializeComponent();
            user = u;
            addSupplyOwner = o;
            owner = addSupplyOwner;
        }

        public PasswordConfirmation(UpdateSupply o, User u)
        {
            InitializeComponent();
            user = u;
            updateSupplyOwner = o;
            owner = updateSupplyOwner;
        }

        public PasswordConfirmation(CreateRis o, User u)
        {
            InitializeComponent();
            user = u;
            createRisOwner = o;
            owner = createRisOwner;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if(owner.GetType() == typeof(UserMiniPlate))
            {
                string password = tb_password.Text.ToString();
                if (PasswordHashAlgorithm.CalculateMD5Hash(password) == user.Password)
                {
                    userMiniPlateOwner.SaveUserChanges();
                    Close();

                }
                else
                {
                    label2.Visible = true;
                }
            }
            else if(owner.GetType() == typeof(UpdateUser))
            {
                string password = tb_password.Text.ToString();
                if (PasswordHashAlgorithm.CalculateMD5Hash(password) == user.Password)
                {
                    updateUserOwner.SaveUserChanges();
                    Close();

                }
                else
                {
                    label2.Visible = true;
                }
            }
            else if(owner.GetType() == typeof(AddUser))
            {
                string password = tb_password.Text.ToString();
                if (PasswordHashAlgorithm.CalculateMD5Hash(password) == user.Password)
                {
                    addUserOwner.AddUserToDb();
                    Close();

                }
                else
                {
                    label2.Visible = true;
                }
            }
            else if (owner.GetType() == typeof(AddSupply))
            {
                string password = tb_password.Text.ToString();
                if (PasswordHashAlgorithm.CalculateMD5Hash(password) == user.Password)
                {
                    addSupplyOwner.AddSupplyToDb();
                    Close();

                }
                else
                {
                    label2.Visible = true;
                }
            }
            else if(owner.GetType() == typeof(UpdateSupply))
            {
                string password = tb_password.Text.ToString();
                if (PasswordHashAlgorithm.CalculateMD5Hash(password) == user.Password)
                {
                    updateSupplyOwner.UpdateToDb();
                    Close();

                }
                else
                {
                    label2.Visible = true;
                }
            }
            else if(owner.GetType() == typeof(CreateRis))
            {
                string password = tb_password.Text.ToString();
                if (PasswordHashAlgorithm.CalculateMD5Hash(password) == user.Password)
                {
                    createRisOwner.SaveNewRis();
                    Close();

                }
                else
                {
                    label2.Visible = true;
                }
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_password.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '•';
            }
        }
    }
}
