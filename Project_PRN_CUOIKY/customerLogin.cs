using Project_PRN_CUOIKY.Models;

namespace Project_PRN_CUOIKY
{
    public partial class customerLogin : Form
    {
        string name, id;

        int count = 0;
        int min = 0;

        public readonly Project_PRNContext context = new();
        public customerLogin()
        {
            InitializeComponent();
            timer1.Start();
        }



        public customerLogin(string user, int comId)
        {
            InitializeComponent();
            textBox1.Text = user;
            label5.Text = comId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dvcus = new ServiceWithCustomer();
            dvcus.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var changepass = new cuschangePass();
            changepass.ShowDialog();
        }
    }
}
