namespace Example2
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(btSoX.Text);
            int y = int.Parse(btSoY.Text);
            int kq = x + y;
            btKetQua.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(btSoX.Text);
            int y = int.Parse(btSoY.Text);
            int kq = x * y;
            btKetQua.Text += kq.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
