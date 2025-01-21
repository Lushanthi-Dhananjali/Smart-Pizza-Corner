namespace WinFormsApp123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "lushanthidha@gmail.com" && textBox2.Text == "Lushanthi")
            {
                Form2 fm1 = new Form2();
                fm1.Show();
                this.Hide();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 fm1 = new Form4();
            fm1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4_2 fm2 = new Form4_2();
            fm2.Show();
        }
    }
}
