namespace ExampleSQL
{
    partial class CustomerGUI
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
            dgvCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btRead = new Button();
            btNew = new Button();
            btDelete = new Button();
            btEdit = new Button();
            btExit = new Button();
            tbId = new TextBox();
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbArea = new ComboBox();
            label3 = new Label();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCustomer.Location = new Point(12, 12);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(776, 275);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellContentClick += dgvCustomer_RowEnter;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id";
            Column1.HeaderText = "Mã";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "name";
            Column2.HeaderText = "Tên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "AreaName";
            Column3.HeaderText = "Khu Vực";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 300;
            // 
            // btRead
            // 
            btRead.Location = new Point(14, 496);
            btRead.Name = "btRead";
            btRead.Size = new Size(112, 34);
            btRead.TabIndex = 1;
            btRead.Text = "Đọc dữ liệu";
            btRead.UseVisualStyleBackColor = true;
            btRead.Click += btRead_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(236, 496);
            btNew.Name = "btNew";
            btNew.Size = new Size(112, 34);
            btNew.TabIndex = 2;
            btNew.Text = "Thêm";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(385, 496);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(112, 34);
            btDelete.TabIndex = 3;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(523, 496);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(112, 34);
            btEdit.TabIndex = 4;
            btEdit.Text = "Sửa";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(676, 496);
            btExit.Name = "btExit";
            btExit.Size = new Size(112, 34);
            btExit.TabIndex = 5;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click_1;
            // 
            // tbId
            // 
            tbId.Location = new Point(90, 306);
            tbId.Name = "tbId";
            tbId.Size = new Size(295, 31);
            tbId.TabIndex = 6;
            // 
            // tbName
            // 
            tbName.Location = new Point(90, 352);
            tbName.Name = "tbName";
            tbName.Size = new Size(295, 31);
            tbName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 306);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 8;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 355);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 9;
            label2.Text = "Tên";
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Items.AddRange(new object[] { "Bắc ", "Trung ", "Tây Nguyên ", "Tây Nam", "Đông Nam" });
            cbArea.Location = new Point(90, 411);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(295, 33);
            cbArea.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 411);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 11;
            label3.Text = "Khu vực";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(419, 306);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(75, 29);
            rdNam.TabIndex = 12;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(523, 308);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(61, 29);
            rdNu.TabIndex = 13;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // CustomerGUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(label3);
            Controls.Add(cbArea);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(btExit);
            Controls.Add(btEdit);
            Controls.Add(btDelete);
            Controls.Add(btNew);
            Controls.Add(btRead);
            Controls.Add(dgvCustomer);
            Name = "CustomerGUI";
            Text = "Form14";
            Load += CustomerGUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomer;
        private Button btRead;
        private Button btNew;
        private Button btDelete;
        private Button btEdit;
        private Button btExit;
        private TextBox tbId;
        private TextBox tbName;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox cbArea;
        private Label label3;
        private RadioButton rdNam;
        private RadioButton rdNu;
    }
}
