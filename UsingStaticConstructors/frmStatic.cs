using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingStaticConstructors
{
    public partial class frmStatic : Form
    {
        public frmStatic()
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
            clsStatic checks = new clsStatic();
            clsStatic check = new clsStatic();
            check.firstname = txtName.Text;
            check.lastname = txtLname.Text;

            
            MessageBox.Show("Welcome " + " " + check.firstname + " " + check.lastname, "Enjoy!", MessageBoxButtons.OK);
        }
    }
}
