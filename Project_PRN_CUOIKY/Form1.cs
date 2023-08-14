using Project_PRN_CUOIKY.Models;

namespace Project_PRN_CUOIKY
{
    public partial class Form1 : Form
    {
        public readonly Project_PRNContext context = new();
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Account acc = context.Accounts.SingleOrDefault(acc => acc.AccName == textBox1.Text);
                if (acc != null)
                {
                    if (acc.Pass == textBox2.Text)
                    {
                        MessageBox.Show("sai mk");
                    }
                    else
                    {

                        if (acc.Role == 0)
                        {
                            var form2 = new Form2();
                            acc.StatusAcc = 1;
                            this.Hide();
                            form2.ShowDialog();

                        }
                        else
                        {
                            var customer = new choiceCom(textBox1.Text);
                            acc.StatusAcc = 1;
                            customer.ShowDialog();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("user  name wrong");
                }
            }
            else
            {
                MessageBox.Show("khong dc de trong");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}