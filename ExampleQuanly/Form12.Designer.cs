
namespace ExampleQuanly
{
    partial class Form12
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployee = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            t = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            btAddNew = new Button();
            btDelete = new Button();
            btOut = new Button();
            btEdit = new Button();
            cbPosition = new ComboBox();
            label1 = new Label();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            tbHours = new TextBox();
            label5 = new Label();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvEmployee.Location = new Point(13, 13);
            dgvEmployee.Margin = new Padding(0);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 33;
            dgvEmployee.Size = new Size(991, 196);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã nhân viên";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 170;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên nhân viên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tuổi";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Chức vụ";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Lương";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(13, 265);
            t.Name = "t";
            t.Size = new Size(40, 28);
            t.TabIndex = 1;
            t.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 329);
            label2.Name = "label2";
            label2.Size = new Size(41, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 391);
            label3.Name = "label3";
            label3.Size = new Size(50, 28);
            label3.TabIndex = 3;
            label3.Text = "Tuổi";
            // 
            // tbId
            // 
            tbId.Location = new Point(104, 265);
            tbId.Name = "tbId";
            tbId.Size = new Size(332, 34);
            tbId.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(104, 329);
            tbName.Name = "tbName";
            tbName.Size = new Size(332, 34);
            tbName.TabIndex = 5;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(104, 391);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(332, 34);
            tbAge.TabIndex = 6;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(608, 522);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(123, 38);
            btAddNew.TabIndex = 8;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(738, 522);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(122, 38);
            btDelete.TabIndex = 9;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btOut
            // 
            btOut.Location = new Point(867, 522);
            btOut.Name = "btOut";
            btOut.Size = new Size(123, 38);
            btOut.TabIndex = 10;
            btOut.Text = "Thoát";
            btOut.UseVisualStyleBackColor = true;
            btOut.Click += btOut_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(478, 522);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(123, 38);
            btEdit.TabIndex = 11;
            btEdit.Text = "Chỉnh sửa";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // cbPosition
            // 
            cbPosition.FormattingEnabled = true;
            cbPosition.Location = new Point(580, 265);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(424, 36);
            cbPosition.TabIndex = 14;
            cbPosition.SelectedIndexChanged += cbPosition_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(490, 265);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 15;
            label1.Text = "Chức vụ";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(104, 456);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(79, 32);
            rdNam.TabIndex = 17;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(277, 456);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(64, 32);
            rdNu.TabIndex = 18;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // tbHours
            // 
            tbHours.Location = new Point(581, 329);
            tbHours.Name = "tbHours";
            tbHours.Size = new Size(150, 34);
            tbHours.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(490, 329);
            label5.Name = "label5";
            label5.Size = new Size(43, 28);
            label5.TabIndex = 20;
            label5.Text = "Giờ";
            label5.Click += label5_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(64, 225);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(150, 34);
            tbSearch.TabIndex = 21;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 578);
            Controls.Add(tbSearch);
            Controls.Add(label5);
            Controls.Add(tbHours);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(label1);
            Controls.Add(cbPosition);
            Controls.Add(btEdit);
            Controls.Add(btOut);
            Controls.Add(btDelete);
            Controls.Add(btAddNew);
            Controls.Add(tbAge);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(t);
            Controls.Add(dgvEmployee);
            Font = new Font("Segoe UI", 10F);
            Name = "Form12";
            Text = "Quản lý nhân viên";
            Load += Form12_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        #endregion

        private DataGridView dgvEmployee;
        private Label t;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbAge;
        private Button btAddNew;
        private Button btDelete;
        private Button btOut;
        private Button btEdit;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox cbPosition;
        private Label label1;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private TextBox tbHours;
        private Label label5;
        private TextBox tbSearch;
    }
}
