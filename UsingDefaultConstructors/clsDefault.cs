

namespace UsingDefaultConstructors
{
    class clsDefault
    {
        public string firstname;
        public string lastname;

        public clsDefault()
        {
            frmDefault forms = new frmDefault();
           

            firstname= forms.txtName.Text;
            lastname = forms.txtLname.Text;

        }
    }
}
