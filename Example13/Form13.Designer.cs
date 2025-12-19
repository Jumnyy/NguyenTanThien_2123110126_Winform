namespace Example13
{
    partial class Form13
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
            ckGender = new CheckBox();
            button3 = new Button();
            btDelete = new Button();
            btAddNew = new Button();
            tbName = new TextBox();
            tbAge = new TextBox();
            tbId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvEmployee.Location = new Point(12, 11);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.Size = new Size(776, 225);
            dgvEmployee.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.FillWeight = 200F;
            Column1.HeaderText = "Mã Nhân Viên";
            Column1.MinimumWidth = 10;
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
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(149, 405);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(76, 29);
            ckGender.TabIndex = 21;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(676, 405);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 20;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(558, 405);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(112, 34);
            btDelete.TabIndex = 19;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(440, 405);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(112, 34);
            btAddNew.TabIndex = 18;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(149, 306);
            tbName.Name = "tbName";
            tbName.Size = new Size(325, 31);
            tbName.TabIndex = 17;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(149, 352);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(325, 31);
            tbAge.TabIndex = 16;
            // 
            // tbId
            // 
            tbId.Location = new Point(149, 257);
            tbId.Name = "tbId";
            tbId.Size = new Size(325, 31);
            tbId.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 352);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 14;
            label3.Text = "Tuổi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 306);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 13;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 257);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 12;
            label1.Text = "Mã ";
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEmployee);
            Controls.Add(ckGender);
            Controls.Add(button3);
            Controls.Add(btDelete);
            Controls.Add(btAddNew);
            Controls.Add(tbName);
            Controls.Add(tbAge);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form13";
            Text = "Quản lý";
            Load += Form13_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private CheckBox ckGender;
        private Button button3;
        private Button btDelete;
        private Button btAddNew;
        private TextBox tbName;
        private TextBox tbAge;
        private TextBox tbId;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
