using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
namespace ExampleSQL
{
    public partial class CustomerGUI : Form
    {
        CustomerBAL cusBAL = new CustomerBAL();
        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            // 1. Nạp dữ liệu vào ComboBox Khu vực
            AreaBAL areaBAL = new AreaBAL();
            List<AreaBEL> lstArea = areaBAL.ReadAreaList();

            cbArea.DataSource = lstArea;
            cbArea.DisplayMember = "Name"; 
            cbArea.ValueMember = "Id";     

            // 2. Nạp dữ liệu vào DataGridView Khách hàng
            List<CustomerBEL> lstCus = cusBAL.ReadCustomer();
            dgvCustomer.Rows.Clear();
            foreach (CustomerBEL cus in lstCus)
            {
                dgvCustomer.Rows.Add(cus.Id, cus.Name, cus.AreaName);
            }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra nhập liệu cơ bản trước khi xử lý
                if (string.IsNullOrWhiteSpace(tbId.Text) || string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show("Vui lòng không để trống ID và Tên khách hàng!", "Thông báo nhắc nhở",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CustomerBEL cus = new CustomerBEL();
                cus.Id = int.Parse(tbId.Text);
                cus.Name = tbName.Text;

                if (cbArea.SelectedValue != null)
                {
                    cus.IdArea = int.Parse(cbArea.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khu vực hợp lệ từ danh sách!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // 2. Thực hiện thêm mới
                cusBAL.NewCustomer(cus);

                // 3. Cập nhật giao diện
                dgvCustomer.Rows.Add(cus.Id, cus.Name, cbArea.Text);

                // THÔNG BÁO THÀNH CÔNG HẤP DẪN
                MessageBox.Show("Chúc mừng! Bạn đã thêm khách hàng mới thành công.", "Hệ thống thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa sạch text sau khi thêm xong
                tbId.Clear();
                tbName.Clear();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Mã ID này đã tồn tại! Vui lòng nhập mã khác.",
                        "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message,
                        "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            CustomerBEL cus = new CustomerBEL();
            cus.Id = int.Parse(tbId.Text);

            cusBAL.DeleteCustomer(cus);
            int idx = dgvCustomer.CurrentCell.RowIndex;
            dgvCustomer.Rows.RemoveAt(idx);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra xem có đang chọn dòng nào không
                if (dgvCustomer.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo");
                    return;
                }

                int newId = int.Parse(tbId.Text);
                // Lấy ID cũ từ dòng đang chọn trên lưới để so sánh
                int oldId = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString()!);

                // 2. Nếu người dùng đổi ID, ta phải kiểm tra xem ID mới có trùng với AI KHÁC không
                if (newId != oldId)
                {
                    bool isDuplicate = false;
                    foreach (DataGridViewRow row in dgvCustomer.Rows)
                    {
                        // Kiểm tra tất cả các dòng, trừ dòng hiện tại đang sửa
                        if (row != dgvCustomer.CurrentRow && row.Cells[0].Value != null)
                        {
                            int existId = int.Parse(row.Cells[0].Value.ToString()!);
                            if (newId == existId)
                            {
                                isDuplicate = true;
                                break;
                            }
                        }
                    }

                    if (isDuplicate)
                    {
                        MessageBox.Show($"Mã ID {newId} đã tồn tại trong danh sách. Vui lòng chọn mã khác!",
                            "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Dừng lại, không cho chạy tiếp xuống phần Update
                    }
                }

                // 3. Nếu không trùng (hoặc không đổi ID), tiến hành sửa như bình thường
                CustomerBEL cus = new CustomerBEL();
                cus.Id = newId;
                cus.Name = tbName.Text;

                // Gán giới tính từ RadioButton

                if (cbArea.SelectedValue != null)
                {
                    cus.IdArea = int.Parse(cbArea.SelectedValue.ToString()!);
                }

                // Gọi BAL để cập nhật vào Database
                cusBAL.EditCustomer(cus);

                // 4. Cập nhật lại giao diện
                DataGridViewRow currentRow = dgvCustomer.CurrentRow;
                currentRow.Cells[0].Value = cus.Id;
                currentRow.Cells[1].Value = cus.Name;
                currentRow.Cells[2].Value = cbArea.Text;
                // Nếu bro có cột giới tính ở index 3:
                // currentRow.Cells[3].Value = cus.Gender ? "Nam" : "Nữ";

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btRead_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(
                "Data Source=localhost,1433;Initial Catalog=sale;User Id=sa;Password=sa;TrustServerCertificate=True;"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM customer", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                dgvCustomer.Rows.Clear(); // Xóa dữ liệu cũ

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvCustomer.Rows.Add(
                            reader.GetInt32(0),   // id
                            reader.GetString(1),  // name
                            reader.GetString(2)   // Đây là AreaName (cột thứ 3 trong SELECT)
                        );
                    }
                }
            }
        }
        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
            tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
            cbArea.Text = dgvCustomer.Rows[idx].Cells[2].Value.ToString();


        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
