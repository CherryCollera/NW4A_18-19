using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingCopyConstructors
{
    public partial class frmCopy : Form
    {
        public frmCopy()
        {
            InitializeComponent();
        }

        private void frmCopy_Load(object sender, EventArgs e)
        {

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



        private void btn(object sender, EventArgs e)
        {
            clsCopy news = new clsCopy(txtAge.Text, txtCourse.Text, txtSec.Text, txtBirth.Text);
            clsCopy news1 = new clsCopy(news);


            MessageBox.Show("Your age: " + " " + news1.ages + "\n " + "   Course: " + news1.courses + "\n" + "   Section: " + news1.sections + "\n" + "Birthdate: " + news1.dates, "Copy", MessageBoxButtons.OK);
            MessageBox.Show(" Your age:  " + " " + news.ages + "\n " + "   Course:   " + news.courses + "\n" + "   Section:   " + news.sections + "\n" + "Birthdate:   " + news.dates, "Original", MessageBoxButtons.OK);

        }

      
    }
}
