using Project_PRN_CUOIKY.Models;
using System.Data;

namespace Project_PRN_CUOIKY
{
    public partial class choiceCom : Form
    {
        public readonly Project_PRNContext context = new();
        string username;
        public choiceCom()
        {
            InitializeComponent();
        }
        public choiceCom(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Computer> ItemCom = new List<Computer>();

            dataGridView1.DataSource = context.Computers.Select(s => new
            {
                ComputerID = s.ComId,
                Status = s.StatusCom == 0 ? "Hỏng" : s.StatusCom == 1 ? "Chưa  đăng nhập" : "đã đăng nhập",
            }).ToList();





        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox1.Text = row.Cells[0].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                Computer com = context.Computers.SingleOrDefault(com => com.ComId == Int32.Parse(textBox1.Text));
                if (com != null)
                {
                    if (com.StatusCom == 2) { MessageBox.Show("chọn máy khác đi máy này đã có người"); }
                    if (com.StatusCom == 0) { MessageBox.Show("chọn máy khác đi máy này hỏng"); }
                    if (com.StatusCom == 1)
                    {
                        com.StatusCom = 2;
                        var cutomer = new customerLogin(username, com.ComId);
                        this.Hide();
                        cutomer.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("acc null");
                }



            }
            else
            {
                MessageBox.Show("â");
            }

        }
    }
}
