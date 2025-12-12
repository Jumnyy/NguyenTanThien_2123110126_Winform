namespace Example2
{
    partial class Form2
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
            label1 = new Label();
            btSoX = new TextBox();
            label2 = new Label();
            btSoY = new TextBox();
            label3 = new Label();
            btKetQua = new TextBox();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "Số x:";
            // 
            // btSoX
            // 
            btSoX.Location = new Point(104, 39);
            btSoX.Name = "btSoX";
            btSoX.Size = new Size(257, 31);
            btSoX.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 97);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 2;
            label2.Text = "Số y:";
            // 
            // btSoY
            // 
            btSoY.Location = new Point(104, 91);
            btSoY.Name = "btSoY";
            btSoY.Size = new Size(261, 31);
            btSoY.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 159);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 4;
            label3.Text = "Kết quả:";
            // 
            // btKetQua
            // 
            btKetQua.Location = new Point(104, 159);
            btKetQua.Name = "btKetQua";
            btKetQua.Size = new Size(264, 31);
            btKetQua.TabIndex = 5;
            // 
            // btCong
            // 
            btCong.Location = new Point(13, 220);
            btCong.Name = "btCong";
            btCong.Size = new Size(112, 34);
            btCong.TabIndex = 6;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(144, 220);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(112, 34);
            btNhan.TabIndex = 7;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(341, 222);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(112, 34);
            btThoat.TabIndex = 8;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 297);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(btKetQua);
            Controls.Add(label3);
            Controls.Add(btSoY);
            Controls.Add(label2);
            Controls.Add(btSoX);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox btSoX;
        private Label label2;
        private TextBox btSoY;
        private Label label3;
        private TextBox btKetQua;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
    }
}
