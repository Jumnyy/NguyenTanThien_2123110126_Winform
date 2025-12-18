namespace Example4
{
    partial class Form4
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
            tbDisplay = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btPlus = new Button();
            btMul = new Button();
            btDot = new Button();
            btEquals = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(115, 25);
            tbDisplay.MinimumSize = new Size(50, 50);
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(341, 50);
            tbDisplay.TabIndex = 0;
            tbDisplay.TextChanged += textBox1_TextChanged;
            // 
            // bt0
            // 
            bt0.Location = new Point(115, 81);
            bt0.Name = "bt0";
            bt0.Size = new Size(81, 69);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt1
            // 
            bt1.Location = new Point(202, 81);
            bt1.Name = "bt1";
            bt1.Size = new Size(81, 69);
            bt1.TabIndex = 2;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.Location = new Point(289, 81);
            bt2.Name = "bt2";
            bt2.Size = new Size(82, 69);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            bt3.Location = new Point(377, 81);
            bt3.Name = "bt3";
            bt3.Size = new Size(79, 69);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            // 
            // btPlus
            // 
            btPlus.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPlus.Location = new Point(115, 163);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(81, 63);
            btPlus.TabIndex = 5;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // btMul
            // 
            btMul.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMul.Location = new Point(202, 163);
            btMul.Name = "btMul";
            btMul.Size = new Size(81, 63);
            btMul.TabIndex = 6;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = true;
            // 
            // btDot
            // 
            btDot.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDot.Location = new Point(289, 163);
            btDot.Name = "btDot";
            btDot.Size = new Size(82, 63);
            btDot.TabIndex = 7;
            btDot.Text = ".";
            btDot.UseVisualStyleBackColor = true;
            // 
            // btEquals
            // 
            btEquals.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEquals.Location = new Point(377, 163);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(79, 63);
            btEquals.TabIndex = 8;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btEquals_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 262);
            Controls.Add(btEquals);
            Controls.Add(btDot);
            Controls.Add(btMul);
            Controls.Add(btPlus);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(tbDisplay);
            Name = "Form4";
            Text = "Form1";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btPlus;
        private Button btMul;
        private Button btDot;
        private Button btEquals;
    }
}
