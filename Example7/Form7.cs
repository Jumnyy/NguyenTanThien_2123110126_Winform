namespace Example7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbResult.Enabled = true;
            else
                tbResult.Enabled = false;
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if (rbMale.Checked == true)
                msg += "Ông";
            if (rbFemale.Checked == true)
                msg += "Bà";
            if (ckDiscount.Checked == true)
                disc = 5;
            tbResult.Text = msg + tbName.Text + "được giảm" + disc.ToString() + "%" + "\r\n";
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
