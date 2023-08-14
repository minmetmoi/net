using Project_PRN_CUOIKY.Models;

namespace Project_PRN_CUOIKY
{
    public partial class AddCustomer : Form
    {
        public readonly Project_PRNContext context = new Project_PRNContext();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account acc = context.Accounts.SingleOrDefault(acc => acc.AccName == txt1.Text);
            if (acc != null)
            {
                MessageBox.Show("Tên người dùng đã tồn tại");
            }
            else if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "")
            {
                MessageBox.Show("không được để trống", "Lỗi");
            }
            else
            {
                if (txt2.Text == txt3.Text)
                {
                    Account newAcc = new Account();
                    newAcc.AccName = txt1.Text;
                    newAcc.Pass = txt2.Text;
                    newAcc.Role = 1;
                    newAcc.Time = 0;
                    context.Accounts.Add(newAcc);

                    context.SaveChanges();
                    MessageBox.Show("đã đăng kí thành công");

                }
                else
                {
                    MessageBox.Show("nhập lại mật khẩu sai");
                }

            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
