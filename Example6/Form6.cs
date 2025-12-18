using System.Diagnostics.Eventing.Reader;

namespace Example6
{
    public partial class Form6 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";
        public Form6()
        {
            InitializeComponent();
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if ((char.IsDigit(bt.Text, 0) & bt.Text.Length == 1) || bt.Text == ".")
            {
                tbDisplay.Text = bt.Text;
            }
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {

            }
            else if (bt.Text == "=")
            {

            }
            else if (bt.Text == "±")
            {

            }
            else if (bt.Text == "√")
            {

            }
            else if (bt.Text == "%")
            {

            }
            else if (bt.Text == "1/x")
            {

            }
            else if (bt.Text == "←")
            {

            }
            else if (bt.Text == "MC")
            {

            }
            else if (bt.Text == "MR")
            {

            }
            else if (bt.Text == "MS")
            {

            }
            else if (bt.Text == "M+")
            {

            }
            else if (bt.Text == "M-")
            {

            }
            else if (bt.Text == "C")
            {

            }
            else if (bt.Text == "CE")
            {

            }
            else if (bt.Text == "*" || bt.Text == "/" || bt.Text == "+" || bt.Text == "-")
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(tbDisplay.Text);
                tbDisplay.Clear();
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
