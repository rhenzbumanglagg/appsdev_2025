namespace SimpleFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fnameValue = label1.Text;
            string lnameValue = label2.Text;
            MessageBox.Show("Hello, World!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
