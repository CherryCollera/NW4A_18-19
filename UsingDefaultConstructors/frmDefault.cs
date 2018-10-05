using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingDefaultConstructors
{
    public partial class frmDefault : Form
    {
        public frmDefault()
        {
            InitializeComponent();
        }

   
   

        private void btnDisplay_Click(object sender, EventArgs e)

        {
            clsDefault check = new clsDefault();
            check.firstname = txtName.Text;
            check.lastname = txtLname.Text;

            
            MessageBox.Show("Welcome " + " " + check.firstname + " " + check.lastname  , "Enjoy!", MessageBoxButtons.OK);
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
           
                txtName.SelectAll();
        }

        private void txtLname_Click(object sender, EventArgs e)
        {
                txtLname.SelectAll();
        }

        private void frmDefault_Load(object sender, EventArgs e)
        {

        }
    }
}
