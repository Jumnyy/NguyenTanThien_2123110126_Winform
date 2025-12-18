namespace Example7
{
    partial class Form7
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
            tbName = new TextBox();
            tbResult = new RichTextBox();
            btRun = new Button();
            button2 = new Button();
            ckDiscount = new CheckBox();
            tbDiscount = new TextBox();
            groupBox1 = new GroupBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(26, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(389, 31);
            tbName.TabIndex = 0;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(26, 240);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(422, 144);
            tbResult.TabIndex = 1;
            tbResult.Text = "";
            // 
            // btRun
            // 
            btRun.Location = new Point(218, 405);
            btRun.Name = "btRun";
            btRun.Size = new Size(112, 34);
            btRun.TabIndex = 2;
            btRun.Text = "Tính tiền";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // button2
            // 
            button2.Location = new Point(336, 405);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // ckDiscount
            // 
            ckDiscount.AutoSize = true;
            ckDiscount.Location = new Point(26, 205);
            ckDiscount.Name = "ckDiscount";
            ckDiscount.Size = new Size(108, 29);
            ckDiscount.TabIndex = 3;
            ckDiscount.Text = "Giảm giá";
            ckDiscount.UseVisualStyleBackColor = true;
            ckDiscount.CheckedChanged += ckDiscount_CheckedChanged;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(153, 203);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(295, 31);
            tbDiscount.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Location = new Point(26, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 130);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới Tính";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(237, 59);
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
            rbMale.Location = new Point(56, 59);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 451);
            Controls.Add(groupBox1);
            Controls.Add(ckDiscount);
            Controls.Add(button2);
            Controls.Add(btRun);
            Controls.Add(tbResult);
            Controls.Add(tbDiscount);
            Controls.Add(tbName);
            Name = "Form7";
            Text = "Form1";
            Load += Form7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private RichTextBox tbResult;
        private Button btRun;
        private Button button2;
        private CheckBox ckDiscount;
        private TextBox tbDiscount;
        private GroupBox groupBox1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
    }
}
