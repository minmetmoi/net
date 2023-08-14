namespace Project_PRN_CUOIKY
{
    partial class naptien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            hour = new Label();
            label6 = new Label();
            label7 = new Label();
            minus = new Label();
            err = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 35);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên Tài khoản";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Số tiền nạp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 203);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 3;
            label3.Text = "Quy đổi ra thời gian:";
            // 
            // button1
            // 
            button1.Location = new Point(192, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 145);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Mức giá: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 145);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 8;
            label5.Text = "5000 VNĐ / 1H";
            // 
            // hour
            // 
            hour.AutoSize = true;
            hour.Location = new Point(194, 203);
            hour.Name = "hour";
            hour.Size = new Size(21, 20);
            hour.TabIndex = 9;
            hour.Text = "0 ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 203);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 10;
            label6.Text = "giờ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(357, 203);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 11;
            label7.Text = "phút";
            // 
            // minus
            // 
            minus.AutoSize = true;
            minus.Location = new Point(312, 203);
            minus.Name = "minus";
            minus.Size = new Size(21, 20);
            minus.TabIndex = 12;
            minus.Text = "0 ";
            // 
            // err
            // 
            err.AutoSize = true;
            err.Location = new Point(188, 223);
            err.Name = "err";
            err.Size = new Size(0, 20);
            err.TabIndex = 13;
            // 
            // naptien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 322);
            Controls.Add(err);
            Controls.Add(minus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(hour);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "naptien";
            Text = "naptien";
            Load += naptien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label hour;
        private Label label6;
        private Label label7;
        private Label minus;
        private Label err;
    }
}