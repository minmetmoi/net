namespace Project_PRN_CUOIKY
{
    partial class customerLogin
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lbmin = new Label();
            lbsec = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 22);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 92);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Thời gian";
            // 
            // button1
            // 
            button1.Location = new Point(238, 205);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(238, 139);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Dịch vụ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 139);
            button3.Name = "button3";
            button3.Size = new Size(136, 29);
            button3.TabIndex = 6;
            button3.Text = "Đổi mật khẩu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.CausesValidation = false;
            textBox1.Enabled = false;
            textBox1.Location = new Point(173, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 27);
            textBox1.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(33, 205);
            button4.Name = "button4";
            button4.Size = new Size(136, 31);
            button4.TabIndex = 8;
            button4.Text = "Chat ";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 54);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 9;
            label4.Text = "Id máy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 54);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // lbmin
            // 
            lbmin.AutoSize = true;
            lbmin.Location = new Point(144, 92);
            lbmin.Name = "lbmin";
            lbmin.Size = new Size(25, 20);
            lbmin.TabIndex = 11;
            lbmin.Text = "00";
            // 
            // lbsec
            // 
            lbsec.AutoSize = true;
            lbsec.Location = new Point(216, 92);
            lbsec.Name = "lbsec";
            lbsec.Size = new Size(25, 20);
            lbsec.TabIndex = 12;
            lbsec.Text = "00";
            // 
            // customerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 265);
            Controls.Add(lbsec);
            Controls.Add(lbmin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "customerLogin";
            Text = "customerLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Label lbmin;
        private Label lbsec;
    }
}