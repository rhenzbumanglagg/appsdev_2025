namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadMovies();
        }
        private void LoadMovies()
        {
            string[] movies = { "Hello, Love, Again", "Inception", "Titanic", "Avengers: Endgame", "The Matrix" };
            checkedListBox.Items.AddRange(movies);
            checkedListBox.CheckOnClick = true; 
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox.CheckedItems)
            {
                if (!listBox.Items.Contains(item))
                {
                    listBox.Items.Add(item);
                }
            }
        }
        private void dltBtn_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }
        private void clrBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                listBox.Items.Clear();
            }
            else
            {
                MessageBox.Show("No items to clear.");
            }
        }
    }
}
