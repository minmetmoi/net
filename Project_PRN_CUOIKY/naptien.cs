using Project_PRN_CUOIKY.Models;

namespace Project_PRN_CUOIKY
{
    public partial class naptien : Form
    {
        public readonly Project_PRNContext context = new Project_PRNContext();
        public naptien()
        {
            InitializeComponent();
        }

        private void naptien_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account acc = context.Accounts.SingleOrDefault(acc => acc.AccName == textBox1.Text);
            if (acc == null)
            {
                MessageBox.Show("Không tồn tại tên người dùng!", "Thông báo");
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("không được để trống", "Lỗi");
                }
                else
                {
                    acc.Time = acc.Time + int.Parse(hour.Text) * 60;
                    context.SaveChanges();
                    MessageBox.Show("đã nạp tiền thành công");
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            int a, b;
            if (Int32.TryParse(textBox2.Text, out num))
            {
                a = (Int32)(0.012 * num) / 60;
                hour.Text = a.ToString();
                b = (Int32)(0.012 * num) % 60;
                minus.Text = b.ToString();
                err.Text = "";
            }

            else
            {
                err.Text = ("vui lòng chỉ nhập số nguyên và nhỏ hơn 100 tỉ!");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

