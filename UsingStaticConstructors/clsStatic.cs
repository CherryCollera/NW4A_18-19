

namespace UsingStaticConstructors
{
    class clsStatic
    
    {
       
            public string firstname;
            public string lastname;

            static clsStatic()
            {

            System.Windows.Forms.MessageBox.Show("Static Constructor", "This Program", System.Windows.Forms.MessageBoxButtons.OK);


        }
        public clsStatic()
        {
            frmStatic forms = new frmStatic();

            firstname = forms.txtName.Text;
            lastname = forms.txtLname.Text;

        }


    }

}

