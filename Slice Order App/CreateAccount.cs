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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Account.txt");

            writer.Write(txtBusName.Text + "," + txtEmpName.Text);
            writer.Close();
        }
    }
}
