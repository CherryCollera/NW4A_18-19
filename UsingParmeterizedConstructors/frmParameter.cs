using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingParmeterizedConstructors
{
    public partial class frmParameter : Form
    {
        public frmParameter()
        {
            InitializeComponent();
        }

        private void txtAge_Click(object sender, EventArgs e)
        {
            txtAge.SelectAll();
        }

        private void txtCourse_Click(object sender, EventArgs e)
        {
            txtCourse.SelectAll();
        }

        private void txtSec_Click(object sender, EventArgs e)
        {
            txtSec.SelectAll();
        }

        private void txtBirth_Click(object sender, EventArgs e)
        {
            txtBirth.SelectAll();
        }



        private void btnDisp_Click(object sender, EventArgs e)
        {
            clsParameter news = new clsParameter(txtAge.Text, txtCourse.Text, txtSec.Text, txtBirth.Text);

            MessageBox.Show(" Your age:  " + " " + news.ages + "\n " + "   Course:   " + news.courses + "\n" + "   Section:   " + news.sections +"\n" + "Birthdate:   " + news.dates , "Enjoy!", MessageBoxButtons.OK);

        }
    }
}
