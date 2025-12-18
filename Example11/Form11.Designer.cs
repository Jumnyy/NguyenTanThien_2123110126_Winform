namespace Example11
{
    partial class Form11
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
            tbYear = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbYear
            // 
            tbYear.Location = new Point(154, 52);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(264, 31);
            tbYear.TabIndex = 12;
            tbYear.TextChanged += tbYear_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 31);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 117);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 10;
            label2.Text = "Phone number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 9;
            label1.Text = "Year";
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 194);
            Controls.Add(tbYear);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11";
            Text = "Form11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbYear;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
    }
}
