namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> cartoonImages = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Mickey Mouse");
            comboBox1.Items.Add("SpongeBob");
            comboBox1.Items.Add("Tom & Jerry");
            comboBox1.Items.Add("Scooby-Doo");
            string basePath = @"C:\Users\buman\OneDrive\Desktop\Chapter 1 Part 2\New folder\";

            cartoonImages["Mickey Mouse"] = basePath + "Mickey.jpg";
            cartoonImages["SpongeBob"] = basePath + "SpongeBob.jpg";
            cartoonImages["Tom & Jerry"] = basePath + "Tom&jerry.jpg";
            cartoonImages["Scooby-Doo"] = basePath + "Scooby_Doo.jpg";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedCharacter = comboBox1.SelectedItem.ToString();
                if (cartoonImages.ContainsKey(selectedCharacter))
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(cartoonImages[selectedCharacter]);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Image not found for the selected character.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a cartoon character.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
