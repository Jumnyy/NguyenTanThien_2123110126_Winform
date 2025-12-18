namespace Example5
{
    partial class Form5
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
            cb_Faculty = new ComboBox();
            tbDisplay = new TextBox();
            btOK = new Button();
            btClear = new Button();
            SuspendLayout();
            // 
            // cb_Faculty
            // 
            cb_Faculty.FormattingEnabled = true;
            cb_Faculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Ngoại ngữ", "Quản trị kinh doanh", "Cơ khí", "Điện", "Cơ khí động lực" });
            cb_Faculty.Location = new Point(12, 12);
            cb_Faculty.Name = "cb_Faculty";
            cb_Faculty.Size = new Size(539, 33);
            cb_Faculty.TabIndex = 0;
            cb_Faculty.SelectedIndexChanged += cb_Faculty_SelectedIndexChanged;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(12, 62);
            tbDisplay.Margin = new Padding(9, 9, 3, 3);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(539, 31);
            tbDisplay.TabIndex = 1;
            // 
            // btOK
            // 
            btOK.Location = new Point(439, 296);
            btOK.Name = "btOK";
            btOK.Size = new Size(112, 34);
            btOK.TabIndex = 2;
            btOK.Text = "Ok";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(321, 296);
            btClear.Name = "btClear";
            btClear.Size = new Size(112, 34);
            btClear.TabIndex = 3;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 342);
            Controls.Add(btClear);
            Controls.Add(btOK);
            Controls.Add(tbDisplay);
            Controls.Add(cb_Faculty);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_Faculty;
        private TextBox tbDisplay;
        private Button btOK;
        private Button btClear;
    }
}
