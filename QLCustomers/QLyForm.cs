using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace QLCustomers
{
    public partial class QLyForm : Form
    {
        string connStr =
            "Server=localhost,1433;Database=QLKhachHang;User Id=sa;Password=sa;TrustServerCertificate=True;";
        public QLyForm()
        {
            InitializeComponent();
        }
        bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Mã khách hàng không được để trống!");
                txtMaKH.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống!");
                txtHoTen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenDN.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống!");
                txtTenDN.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                txtMatKhau.Focus();
                return false;
            }

            if (!long.TryParse(txtSDT.Text, out _))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                txtSDT.Focus();
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!");
                txtEmail.Focus();
                return false;
            }

            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }

            return true;
        }

        void LoadData()
        {
            using SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM KhachHang", conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvKhachHang.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvKhachHang.Rows[e.RowIndex];

            txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtTenDN.Text = row.Cells["TenDangNhap"].Value.ToString();
            txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            dtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

            if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;

            if (row.Cells["Avatar"].Value != DBNull.Value)
            {
                avatarData = (byte[])row.Cells["Avatar"].Value;
                using MemoryStream ms = new MemoryStream(avatarData);
                picAvatar.Image = Image.FromStream(ms);
            }
            else
            {
                picAvatar.Image = null;
                avatarData = null;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                string sql = @"INSERT INTO KhachHang
VALUES (@MaKH,@HoTen,@TenDN,@MK,@DC,@GT,@SDT,@Email,@NS,@Avatar)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                cmd.Parameters.AddWithValue("@MK", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@DC", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@GT", rdoNam.Checked ? "Nam" : "Nữ");
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NS", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@Avatar", avatarData ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm khách hàng thành công!");
                LoadData();
                ClearForm();   // ⭐ reset form để thêm mới
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!");
                    txtMaKH.Focus();
                }
                else
                {
                    MessageBox.Show("Lỗi SQL:\n" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống:\n" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (MessageBox.Show("Bạn có chắc muốn sửa?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                string sql = @"UPDATE KhachHang SET
HoTen=@HoTen, TenDangNhap=@TenDN, MatKhau=@MK,
DiaChi=@DC, GioiTinh=@GT, SoDienThoai=@SDT,
Email=@Email, NgaySinh=@NS, Avatar=@Avatar
WHERE MaKH=@MaKH";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                cmd.Parameters.AddWithValue("@MK", txtMatKhau.Text);
                cmd.Parameters.AddWithValue("@DC", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@GT", rdoNam.Checked ? "Nam" : "Nữ");
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NS", dtNgaySinh.Value);
                cmd.Parameters.AddWithValue("@Avatar", avatarData ?? (object)DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật:\n" + ex.Message);
            }
        }

        byte[] avatarData = null;

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(ofd.FileName);
                avatarData = File.ReadAllBytes(ofd.FileName);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM KhachHang WHERE MaKH=@MaKH", conn);

                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu:\n" + ex.Message);
            }
        }
        void ClearForm()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtTenDN.Clear();
            txtMatKhau.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();

            rdoNam.Checked = false;
            rdoNu.Checked = false;

            dtNgaySinh.Value = DateTime.Now;

            picAvatar.Image = null;
            avatarData = null;

            txtMaKH.Focus();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                string sql = @"SELECT * FROM KhachHang
                       WHERE MaKH LIKE @kw
                       OR HoTen LIKE @kw
                       OR SoDienThoai LIKE @kw";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + txtTimKiem.Text.Trim() + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKhachHang.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm:\n" + ex.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                MessageBox.Show("Kết nối SQL Server thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook wb = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet ws = wb.ActiveSheet;

                ws.Name = "DanhSach";

                // Header
                for (int i = 0; i < dgvKhachHang.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dgvKhachHang.Columns[i].HeaderText;
                }

                // Data
                for (int i = 0; i < dgvKhachHang.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKhachHang.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] =
                            dgvKhachHang.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                ws.Columns.AutoFit();
                excelApp.Visible = true;

                MessageBox.Show("Xuất Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel:\n" + ex.Message);
            }
        }
    }
}
