using Example1;
using Example2;
using Example3;
using Example4;
namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

    }
}
