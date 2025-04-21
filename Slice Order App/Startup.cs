using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slice_Order_App
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void timerStart_tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            lblLoad.Visible = false;
            timerStart.Enabled = false;

            CheckAccount();
        }

        private void CheckAccount()
        {
            StreamReader reader = new StreamReader("Account.txt");

            if (reader.Peek() == -1)
            {
                reader.Close();

                CreateAccount createAccount = new CreateAccount();
                createAccount.Show();

                this.Hide();
            }
            else
            {
                string[] values = reader.ReadLine().Split(',');
                reader.Close();
            }
           
        }

        private int period = 0;
        private void timerLoad_Tick(object sender, EventArgs e)
        {
            string[] periods = { ".", "..", "..." };
            string load = "Loading";
            lblLoad.Text = load + periods[period];
            period++;
            if (period > 2)
                period = 0;
        }
    }
}
