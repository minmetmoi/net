using Project_PRN_CUOIKY.Models;

namespace Project_PRN_CUOIKY
{
    public partial class ServiceWithBoss : Form
    {
        public readonly Project_PRNContext context = new();
        public ServiceWithBoss()
        {
            InitializeComponent();

        }



        void loadAllService()
        {
            dataGridView1.DataSource = context.Services.Select(x => new { Name = x.ServiceName, Price = x.Price, category = x.Category.CategoryName }).ToList();
            var location = context.Categories.Select(l => l.CategoryName).ToList();
            comboBox1.DataSource = location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Controls.Clear();
            loadAllService();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var add = new AddService();
            add.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            string a = row.Cells[2].Value.ToString();

            if (a == "Nước")
            {
                comboBox1.SelectedItem = "Nước";
            }
            if (a == "Ăn")
            {
                comboBox1.SelectedItem = "Ăn";
            }
            else
            {
                comboBox1.SelectedItem = "Combo khuyến mãi";
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Service se = context.Services.SingleOrDefault(x => x.ServiceName == textBox1.Text);
                se.Price = Int32.Parse(textBox2.Text);
                if (comboBox1.Text == "Nước")
                {
                    se.CategoryId = 1;
                }
                if (comboBox1.Text == "Ăn")
                {
                    se.CategoryId = 2;
                }
                else
                {
                    se.CategoryId = 3;
                }
                context.SaveChanges();
                loadAllService();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi");
            }

        }

        private void search_TextChanged(object sender, EventArgs e)
        {


        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Controls.Clear();
            var st = context.Services.Where(a => a.ServiceName.Contains(textBox1.Text)).Select(x => new { Name = x.ServiceName, Price = x.Price, category = x.Category.CategoryName }).ToList();

            dataGridView1.DataSource = st.ToList();

            MessageBox.Show("aa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Service se = context.Services.SingleOrDefault(x => x.ServiceName == textBox1.Text);
                context.Remove(se);
                context.SaveChanges();
                loadAllService();
                MessageBox.Show("đã xóa");
            }
        }
    }
}
