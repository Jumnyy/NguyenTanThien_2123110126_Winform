namespace Example3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " + " + y.ToString() + " = " + kq.ToString() + " \r\n";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + " \r\n";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
