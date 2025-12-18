using System.Xml.Linq;

namespace Example9
{
    public partial class Form9 : Form
    {
        private string index = "";
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text =dtpDate.Value.ToShortDateString();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (rbMale.Checked == true)
                msg += "Giới tính:Nam";
            if (rbFemale.Checked == true)
                msg += "Giới tính: Nữ";
            tbDisplay.Text ="1." + tbName.Text + 
                "\r\n" + msg +
                "\r\n" + "Ngày sinh: "
                + dtpDate.Text + "\r\n"
                + "Ngành:" + index;
        }
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cb_Faculty.SelectedItem.ToString();
        }

    } 

}
