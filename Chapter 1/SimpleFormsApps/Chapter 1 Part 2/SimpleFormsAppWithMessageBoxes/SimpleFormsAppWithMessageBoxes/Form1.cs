namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fnameValue = textBox1.Text;
            string lnameValue = textBox2.Text;
            string mnameValue = textBox3.Text;
            string suffixValue = textBox4.Text;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to submit?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Hello There! {fnameValue} {mnameValue} {lnameValue} {suffixValue}!", "Greetings", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
