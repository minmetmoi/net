using Project_PRN_CUOIKY.Models;

namespace Project_PRN_CUOIKY
{
    public partial class AddService : Form
    {
        public readonly Project_PRNContext context = new Project_PRNContext();
        public AddService()
        {
            InitializeComponent();
        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service s = new Service();

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("không được để trống", "Lỗi");
            }


            if (Int32.Parse(textBox2.Text) < 0)
            {
                MessageBox.Show("nhập giá tiền lớn hơn 0");
            }



            else
            {
                //Service ser = new Service();
                //ser.ServiceName = textBox1.Text;
                //ser.Price = Convert.ToInt32(textBox2.Text);
                //ser.CategoryId = comboBox1.SelectedIndex;
                //context.Services.Add(ser);
                //context.SaveChanges();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                MessageBox.Show("hay nhap so thoi");
            }
        }
    }
}
