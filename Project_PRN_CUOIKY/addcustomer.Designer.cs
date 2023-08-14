namespace Project_PRN_CUOIKY
{
    partial class AddCustomer
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
            label3 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            button1 = new Button();
            txt3 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 43);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 90);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txt1
            // 
            txt1.Location = new Point(210, 36);
            txt1.Name = "txt1";
            txt1.Size = new Size(216, 27);
            txt1.TabIndex = 3;
            // 
            // txt2
            // 
            txt2.Location = new Point(210, 83);
            txt2.Name = "txt2";
            txt2.Size = new Size(216, 27);
            txt2.TabIndex = 4;
            txt2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(166, 178);
            button1.Name = "button1";
            button1.Size = new Size(180, 41);
            button1.TabIndex = 5;
            button1.Text = "Đăng  ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt3
            // 
            txt3.Location = new Point(210, 130);
            txt3.Name = "txt3";
            txt3.Size = new Size(216, 27);
            txt3.TabIndex = 7;
            txt3.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 137);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 6;
            label2.Text = "Nhập lại mật khẩu:";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 253);
            Controls.Add(txt3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AddCustomer";
            Text = "AddCustomer";
            FormClosed += AddCustomer_FormClosed;
            Load += AddCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txt1;
        private TextBox txt2;
        private Button button1;
        private TextBox txt3;
        private Label label2;
    }
}