namespace ExampleQuanly
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        Dictionary<string, decimal> salaryPerHour = new Dictionary<string, decimal>()
        {
            { "Thu Ngân", 20000 },
            { "Phục Vụ", 15000 },
            { "Pha Chế", 25000 },
            { "Quản lý", 40000 }
        };
        private decimal CalculateSalary(string position, decimal hours)
        {
            if (salaryPerHour.ContainsKey(position))
            {
                return salaryPerHour[position] * hours;
            }
            return 0;
        }

        // ================= FORM LOAD =================
        // ================= Clear Form =================
        void ClearForm()
        {
            tbId.Clear();
            tbName.Clear();
            tbAge.Clear();
            rdNam.Checked = false;
            rdNu.Checked = false;
            cbPosition.SelectedIndex = 0;
        }

        // ================= Form Load =================
        private void Form12_Load(object sender, EventArgs e)
        {
            // Thêm các chức vụ vào ComboBox
            cbPosition.Items.Add("Thu Ngân");
            cbPosition.Items.Add("Phục Vụ");
            cbPosition.Items.Add("Pha Chế");
            cbPosition.Items.Add("Quản lý");
            cbPosition.SelectedIndex = 0;
        }

        // ================= Click row load dữ liệu =================
        // ================= Click row load dữ liệu =================
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvEmployee.Rows[e.RowIndex].IsNewRow) return;

            DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];

            // Load thông tin cơ bản (Index 0 - 4)
            tbId.Text = row.Cells[0].Value?.ToString() ?? "";
            tbName.Text = row.Cells[1].Value?.ToString() ?? "";
            tbAge.Text = row.Cells[2].Value?.ToString() ?? "";

            string gender = row.Cells[3].Value?.ToString() ?? "";
            rdNam.Checked = gender == "Nam";
            rdNu.Checked = gender == "Nữ";

            cbPosition.SelectedItem = row.Cells[4].Value?.ToString();

            // KIỂM TRA: Chỉ lấy giá trị giờ nếu cột Index 6 tồn tại
            if (dgvEmployee.ColumnCount > 6)
            {
                tbHours.Text = row.Cells[6].Value?.ToString() ?? "0";
            }
            else
            {
                // Nếu bạn chưa kịp tạo cột ẩn, tạm thời lấy số giờ từ logic khác hoặc mặc định
                tbHours.Text = "0";
            }
        }

        // ================= Edit (Sửa) =================
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null || dgvEmployee.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa!");
                return;
            }

            // Kiểm tra đầu vào số giờ
            if (!decimal.TryParse(tbHours.Text, out decimal hours))
            {
                MessageBox.Show("Số giờ không hợp lệ!");
                return;
            }

            string gender = rdNam.Checked ? "Nam" : "Nữ";
            string position = cbPosition.SelectedItem.ToString();

            // Tính lại lương dựa trên số giờ mới nhập ở TextBox
            decimal salary = CalculateSalary(position, hours);

            DataGridViewRow row = dgvEmployee.CurrentRow;
            row.Cells[0].Value = tbId.Text;
            row.Cells[1].Value = tbName.Text;
            row.Cells[2].Value = tbAge.Text;
            row.Cells[3].Value = gender;
            row.Cells[4].Value = position;
            row.Cells[5].Value = salary.ToString("N0"); // Hiển thị lương đã tính lại

            // Cập nhật số giờ vào cột ẩn (Index 6) để lần sau click vào nó vẫn còn dữ liệu
            if (dgvEmployee.ColumnCount > 6)
            {
                row.Cells[6].Value = hours;
            }

            MessageBox.Show("Cập nhật thành công!");
        }
        private void btAddNew_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbName.Text == "" || tbAge.Text == "" || tbHours.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(tbAge.Text, out int age) || age < 18 || age > 65)
            {
                MessageBox.Show("Tuổi phải là số từ 18 đến 65!");
                return;
            }

            if (!decimal.TryParse(tbHours.Text, out decimal hours) || hours < 0 || hours > 200)
            {
                MessageBox.Show("Số giờ phải là số hợp lệ (0 - 200)!");
                return;
            }

            if (!rdNam.Checked && !rdNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            // Kiểm tra trùng Mã NV
            foreach (DataGridViewRow r in dgvEmployee.Rows)
            {
                if (r.Cells[0].Value != null && r.Cells[0].Value.ToString() == tbId.Text)
                {
                    MessageBox.Show("Mã NV đã tồn tại!");
                    return;
                }
            }

            string gender = rdNam.Checked ? "Nam" : "Nữ";
            string position = cbPosition.SelectedItem.ToString();
            decimal salary = CalculateSalary(position, hours);

            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, age, gender, position, salary.ToString("N0"), hours);
            ClearForm();
        }
        // ================= Edit =================
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                dgvEmployee.Rows.RemoveAt(dgvEmployee.CurrentRow.Index);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }
        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
