using System;
using System.Windows.Forms;

namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newItem = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(newItem) && !listBox1.Items.Contains(newItem))
            {
                listBox1.Items.Add(newItem);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid, unique programming language.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to clear all items?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("The list is already empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
