using System.Diagnostics.Eventing.Reader;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] foodCuisine = { "Filipino", "Japanese", "India", "Korea" };
            comboBox1.Items. AddRange(foodCuisine);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedItem = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox.Items)
            {
                bool isSelected = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(item));
                if (isSelected && !listBox.Items.Contains(item))
                {
                    listBox.Items.Add(item);
                }
            }
        }

        private void slcBtn_Click(object sender, EventArgs e)
        {
            string[] Filipino = { "Sisig", "Sinigang", "Lechon", "Sarsiado", "Bulalo", "Leche Flan" };
            string[] Japanese = { "Horumon", "Wanko Soba", "Wagashi", "Tsukemono", "Ramen", "Onigiri" };
            string[] India = { "Biryani", "Masala Dosa", "Paroka", "Tindoori Chicken", "Chole Bhature" };
            string[] Korea = { "Haemul Pajeon", "Kimchi", "Tteokbokki", "Naengmyeon", "Samgyeopsal", "Bingsu" };

            checkedListBox.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox.Items.AddRange(Filipino);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox.Items.AddRange(Japanese);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("India"))
            {
                checkedListBox.Items.AddRange(India);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Korea"))
            {
                checkedListBox.Items.AddRange(Korea);
            }
        }
    }
}
