using Project_PRN_CUOIKY.Models;

namespace Project_PRN_CUOIKY
{
    public partial class ServiceWithCustomer : Form
    {
        public readonly Project_PRNContext context = new();
        public ServiceWithCustomer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var st = context.Services.Where(s => s.CategoryId == 1).Select(s => new { name = s.ServiceName, price = s.Price, category = s.Category.CategoryName }).ToList();
            dataGridView1.DataSource = st.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var st = context.Services.Select(s => new { name = s.ServiceName, price = s.Price, category = s.Category.CategoryName }).ToList();
            dataGridView1.DataSource = st.ToList();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            var st = context.Services.Where(s => s.CategoryId == 2).Select(s => new { name = s.ServiceName, price = s.Price, category = s.Category.CategoryName }).ToList();
            dataGridView1.DataSource = st.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var st = context.Services.Where(s => s.CategoryId == 3).Select(s => new { name = s.ServiceName, price = s.Price, category = s.Category.CategoryName }).ToList();
            dataGridView1.DataSource = st.ToList();
        }
    }
}
