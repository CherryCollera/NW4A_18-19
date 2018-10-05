using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingPrivateConstructor
{
    public partial class frmPrivate : Form
    {
        public frmPrivate()
        {
            InitializeComponent();
        }
        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {

            txtName.SelectAll();
        }

        private void txtLname_Click(object sender, EventArgs e)
        {
            txtLname.SelectAll();
        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            clsPrivate check = new clsPrivate( txtName.Text,txtLname.Text);
           


            MessageBox.Show("Welcome " + " " + check.firstname + " " + check.lastname, "Enjoy!", MessageBoxButtons.OK);
        }
    }
}
