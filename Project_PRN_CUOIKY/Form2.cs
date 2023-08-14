using Project_PRN_CUOIKY.Models;

namespace Project_PRN_CUOIKY
{

    public partial class Form2 : Form
    {
        public readonly Project_PRNContext context = new();
        public Form2()
        {
            InitializeComponent();
            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            button4.Hide();
        }
        public List<Account> ItemAcc = new List<Account>();
        public List<Computer> ItemCom = new List<Computer>();
        private void button1_Click(object sender, EventArgs e)
        {

            Button bt = new Button();
            bt.Location = new Point(100, 12);
            bt.Name = "themtk";
            bt.Size = new Size(150, 53);
            bt.Text = "Thêm tài Khoản";
            Button bt1 = new Button();
            bt1.Location = new Point(300, 12);
            bt1.Name = "xoatk";
            bt1.Size = new Size(150, 53);
            bt1.Text = "Xóa tài Khoản";
            Button bt2 = new Button();
            bt2.Location = new Point(500, 12);
            bt2.Name = "doimk";
            bt2.Size = new Size(150, 53);
            bt2.Text = "Đổi mật khẩu";
            Button bt3 = new Button();
            bt3.Location = new Point(700, 12);
            bt3.Name = "naptien";
            bt3.Size = new Size(150, 53);
            bt3.Text = "Nạp tiền";
            panel1.Controls.Clear();
            panel1.Controls.Add(bt);
            panel1.Controls.Add(bt2);

            panel1.Controls.Add(bt1);
            panel1.Controls.Add(bt3);

            dataGridView1.Controls.Clear();
            reloadAcc();
            bt.Click += btnADD_Click;
            bt1.Click += btnDelete_Click;
            bt2.Click += btnChangePass_Click;
            bt3.Click += btnNap_Click;

            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            button4.Hide();

            //comboBox1.Controls.Clear();
            //ItemAcc = context.Accounts.Distinct().ToList();
            //var nameList = ItemAcc.Select(x => x.StatusAcc).Distinct().ToList();
            //comboBox1.DataSource = nameList;


            //if (textBox2.Text != "")
            //{
            //    dataGridView1.DataSource = context.Accounts.Where(x => x.AccName.Contains(textBox2.Text)).ToList();
            //}
        }
        void reloadAcc()
        {
            dataGridView1.DataSource = context.Accounts.Select(s => new
            {
                UserName = s.AccName,

                Role = s.Role == 0 ? "Chủ" : "Khách",
                Status = s.StatusAcc == 1 ? "Đang hoạt động" : "Chưa đăng nhập",
                Time = s.Time / 60,
            }).ToList();
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            var addCustumer = new AddCustomer();
            addCustumer.ShowDialog();
            context.SaveChanges();
            reloadAcc();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Account acc = context.Accounts.SingleOrDefault(acc => acc.AccName == textBox1.Text);
            if (acc != null)
            {
                if (acc.Role == 0)
                {
                    MessageBox.Show("không thể xóa tài khoản admin");
                }
                else
                {
                    context.Accounts.Remove(acc);
                }
            }


            context.SaveChanges();
            reloadAcc();
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Account acc = context.Accounts.SingleOrDefault(acc => acc.AccName == textBox1.Text);
            acc.Pass = "1";
            context.SaveChanges();
            reloadAcc();
            MessageBox.Show("Mật khẩu đã đặt lại thành 1");
        }
        private void btnNap_Click(object sender, EventArgs e)
        {
            var addCustumer = new naptien();
            addCustumer.ShowDialog();
            reloadAcc();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Location = new Point(100, 12);
            bt.Name = "themcom";
            bt.Size = new Size(150, 53);
            bt.Text = "Thêm máy tính";
            Button bt1 = new Button();
            bt1.Location = new Point(300, 12);
            bt1.Name = "xoacom";
            bt1.Size = new Size(150, 53);
            bt1.Text = "Xóa máy tính";


            panel1.Controls.Clear();
            panel1.Controls.Add(bt);
            panel1.Controls.Add(bt1);

            dataGridView1.Controls.Clear();
            //dataGridView1.DataSource = context.Computers.ToList();
            reloadCom();
            bt.Click += btnAddCom_Click;
            bt1.Click += btnDeleteCOM_Click;

            radioButton1.Show();
            radioButton2.Show();
            radioButton3.Show();
            button4.Show();

            //comboBox1.Controls.Clear();
            //ItemCom = context.Computers.Distinct().ToList();
            //var nameList = ItemCom.Select(x => x.StatusCom).Distinct().ToList();

            //comboBox1.DataSource = nameList;

            //if (textBox2.Text != "")
            //{
            //    dataGridView1.DataSource = context.Computers.Where(x => x.ComId == Int32.Parse(textBox2.Text)).ToList();
            //}
        }

        private void reloadCom()
        {
            dataGridView1.DataSource = context.Computers.Select(s => new
            {
                ComputerID = s.ComId,
                Status = s.StatusCom == 0 ? "Hỏng" : s.StatusCom == 1 ? "Chưa  đăng nhập" : "đã đăng nhập",
            }).ToList();

        }
        private void btnAddCom_Click(object sender, EventArgs e)
        {

            context.Computers.Add(new Computer { StatusCom = 0 });

            context.SaveChanges();
            reloadCom();
            MessageBox.Show("Đã thêm 1 máy mới");


        }
        private void btnDeleteCOM_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Computer com = context.Computers.SingleOrDefault(com => com.ComId == Int32.Parse(textBox1.Text));
                if (com != null)
                {
                    context.Computers.Remove(com);
                }

            }

            context.SaveChanges();
            reloadCom();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            textBox1.Text = row.Cells[0].Value.ToString();
            String status = row.Cells[1].Value.ToString();
            if (status == "Chưa  đăng nhập")
            {
                radioButton1.Checked = true;
            }
            else if (status == "đã đăng nhập")
            {
                radioButton2.Checked = true;

            }
            else { radioButton3.Checked = true; }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Computer com = context.Computers.SingleOrDefault(com => com.ComId == Int32.Parse(textBox1.Text));
                if (com != null)
                {
                    if (radioButton1.Checked = true)
                    {
                        com.StatusCom = 1;
                    }
                    else if (radioButton2.Checked = true)
                    {
                        com.StatusCom = 2;
                    }
                    else { com.StatusCom = 0; }
                }
                context.SaveChanges();
                reloadCom();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var serviceBoss = new ServiceWithBoss();
            serviceBoss.ShowDialog();
            context.SaveChanges();

        }
    }
}
