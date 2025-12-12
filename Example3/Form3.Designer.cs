namespace Example3
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            btLuu = new Button();
            btNhan = new Button();
            btCong = new Button();
            btThoat = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "Số x:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 1;
            label2.Text = "Số y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 165);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 2;
            label3.Text = "Kết Quả:";
            // 
            // tbSoX
            // 
            tbSoX.Location = new Point(101, 44);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(674, 31);
            tbSoX.TabIndex = 3;
            // 
            // tbSoY
            // 
            tbSoY.Location = new Point(101, 104);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(674, 31);
            tbSoY.TabIndex = 4;
            // 
            // tbKetQua
            // 
            tbKetQua.Location = new Point(101, 165);
            tbKetQua.MinimumSize = new Size(200, 200);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.Size = new Size(674, 200);
            tbKetQua.TabIndex = 5;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(22, 391);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(112, 34);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(509, 391);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(112, 34);
            btNhan.TabIndex = 7;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(362, 391);
            btCong.Name = "btCong";
            btCong.Size = new Size(112, 34);
            btCong.TabIndex = 8;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(643, 391);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(112, 34);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btThoat);
            Controls.Add(btCong);
            Controls.Add(btNhan);
            Controls.Add(btLuu);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Caculator";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
        private Button btLuu;
        private Button btNhan;
        private Button btCong;
        private Button btThoat;
        private ContextMenuStrip contextMenuStrip1;
    }
}
