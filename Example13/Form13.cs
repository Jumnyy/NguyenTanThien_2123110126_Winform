using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Example13
{
    public partial class Form13 : Form
    {
        List<Employee> lst;
        BindingSource bs = new BindingSource();

        public Form13()
        {
            InitializeComponent();
            lst = GetData();
            this.Load += Form13_Load;
        }
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();
            Employee em = new Employee();
            em.Id = "123";
            em.Name = "Trần Tiến";
            em.Age = 20;
            lst.Add(em);
            return lst;
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            dgvEmployee.Columns.Clear();

            dgvEmployee.Columns.Add("Id", "Mã NV");
            dgvEmployee.Columns.Add("Name", "Tên NV");
            dgvEmployee.Columns.Add("Age", "Tuổi");
            dgvEmployee.Columns.Add("Gender", "Giới tính");

            lst = GetData();
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = int.Parse(tbAge.Text);
            em.Gender = ckGender.Checked;

            lst.Add(em);
            dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && dgvEmployee.Rows[idx].Cells[0].Value != null)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                ckGender.Checked = (bool)dgvEmployee.Rows[idx].Cells[3].Value;
            }
        }


        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                lst.RemoveAt(idx);
                dgvEmployee.Rows.RemoveAt(idx);
            }
        }
    }
}
