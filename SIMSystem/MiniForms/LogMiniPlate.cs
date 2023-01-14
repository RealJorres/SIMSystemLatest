using SIMSystem.Model;
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
    public partial class LogMiniPlate : UserControl
    {
        User user;
        Log log;
        public LogMiniPlate(Log ll, User u)
        {
            InitializeComponent();
            log = ll;
            user = u;
        }

        private void LogMiniPlate_Load(object sender, EventArgs e)
        {
            label1.Text = log.User;
            label2.Text = log.Event_occure;
            label3.Text = log.Date.ToString("MMMM/dd/yyyy hh:mm tt");
        }
    }
}
