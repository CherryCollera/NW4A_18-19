

namespace UsingPrivateConstructor
{
    class clsPrivate
    {
        public string firstname;
        public string lastname;


        public clsPrivate(string x , string y)

        {
            frmPrivate forms = new frmPrivate();

            firstname = x;
            lastname = y;

        }
        private clsPrivate()
        {
            System.Windows.Forms.MessageBox.Show("Private constructor with no parameters", "This Program", System.Windows.Forms.MessageBoxButtons.OK);


        }
    }
}
