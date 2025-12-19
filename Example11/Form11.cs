using System.ComponentModel;

namespace Example11
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void tbYear_KeyPress (object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            int year = int.Parse(tbYear.Text);
            if (year >2000) 
                e.Cancel = true;
        }
    }
}
