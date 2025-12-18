namespace Example9
{
    partial class Form9
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
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            tbName = new TextBox();
            label1 = new Label();
            cb_Faculty = new ComboBox();
            button2 = new Button();
            btRun = new Button();
            label4 = new Label();
            label3 = new Label();
            tbDisplay = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(121, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 147);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(166, 76);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(61, 29);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(19, 76);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 15;
            label2.Text = "Ngày sinh";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(121, 69);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(321, 31);
            dtpDate.TabIndex = 14;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(121, 18);
            tbName.Name = "tbName";
            tbName.Size = new Size(321, 31);
            tbName.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 12;
            label1.Text = "Họ và tên";
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Ngoại ngữ", "Quản trị kinh doanh", "Cơ khí", "Điện" });
            cb_Faculty.Location = new Point(121, 297);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(322, 33);
            cb_Faculty.TabIndex = 22;
            cb_Faculty.SelectedIndexChanged += cb_Faculty_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(330, 609);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 21;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // btRun
            // 
            btRun.Location = new Point(197, 609);
            btRun.Name = "btRun";
            btRun.Size = new Size(112, 34);
            btRun.TabIndex = 20;
            btRun.Text = "Thêm";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 346);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 19;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 292);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 18;
            label3.Text = "Khoa";
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(121, 346);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(321, 196);
            tbDisplay.TabIndex = 17;
            tbDisplay.Text = "";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 660);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(cb_Faculty);
            Controls.Add(button2);
            Controls.Add(btRun);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbDisplay);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label2;
        private DateTimePicker dtpDate;
        private TextBox tbName;
        private Label label1;
        private ComboBox cb_Faculty;
        private Button button2;
        private Button btRun;
        private Label label4;
        private Label label3;
        private RichTextBox tbDisplay;
    }
}
