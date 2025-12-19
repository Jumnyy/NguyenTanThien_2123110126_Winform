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
            t = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            tbAge = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btDelete = new Button();
            button3 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvEmployee.Location = new Point(12, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.Size = new Size(762, 175);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(12, 237);
            t.Name = "t";
            t.Size = new Size(37, 25);
            t.TabIndex = 1;
            t.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 294);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 349);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 3;
            label3.Text = "Tuổi";
            // 
            // tbId
            // 
            tbId.Location = new Point(95, 237);
            tbId.Name = "tbId";
            tbId.Size = new Size(302, 31);
            tbId.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(95, 294);
            tbName.Name = "tbName";
            tbName.Size = new Size(302, 31);
            tbName.TabIndex = 5;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(95, 349);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(298, 31);
            tbAge.TabIndex = 6;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(91, 395);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(76, 29);
            ckGender.TabIndex = 7;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(381, 466);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(112, 34);
            btAddNew.TabIndex = 8;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(524, 466);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(111, 34);
            btDelete.TabIndex = 9;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // button3
            // 
            button3.Location = new Point(662, 466);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 10;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã nhân viên";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 200;
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
            // Form12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 516);
            Controls.Add(button3);
            Controls.Add(btDelete);
            Controls.Add(btAddNew);
            Controls.Add(ckGender);
            Controls.Add(tbAge);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(t);
            Controls.Add(dgvEmployee);
            Name = "Form12";
            Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private Label t;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbAge;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btDelete;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
