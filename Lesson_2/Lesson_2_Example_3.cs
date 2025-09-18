using System;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class Lesson_2_Example_3 : Form
    {
        public Lesson_2_Example_3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Breakfast Meal A";
            price_txtbox.Text = "91.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Breakfast Meal B";
            price_txtbox.Text = "121.30";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Breakfast Meal C";
            price_txtbox.Text = "91.30";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Breakfast Meal D";
            price_txtbox.Text = "133.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Chicken Meal A";
            price_txtbox.Text = "177.30";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Chicken Meal B";
            price_txtbox.Text = "191.30";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Double Pasta Meal";
            price_txtbox.Text = "300.30";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Double Value Meal A";
            price_txtbox.Text = "250.99";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Double Value Meal B";
            price_txtbox.Text = "191.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Family Combo Meal A";
            price_txtbox.Text = "299.99";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Family Combo Meal B";
            price_txtbox.Text = "799.30";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Jolly Meal Savers";
            price_txtbox.Text = "69.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Lunch Value Meal A";
            price_txtbox.Text = "191.10";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Lunch Value Meal B";
            price_txtbox.Text = "191.30";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Pancake Value Meal A";
            price_txtbox.Text = "97.30";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Pasta Meal A";
            price_txtbox.Text = "98.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Rice Bowl Meal";
            price_txtbox.Text = "125.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        // Display item name and price in the textboxes when the picture box is clicked
        {
            itemname_txtbox.Text = "Zinger Steak Meal";
            price_txtbox.Text = "120.00";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        // Display item name and price in the textboxes when the picture box is clicked
        {
            itemname_txtbox.Text = "Chicken Spaghetti Meal";
            price_txtbox.Text = "150.00";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            // Display item name and price in the textboxes when the picture box is clicked
            itemname_txtbox.Text = "Zinger Burger";
            price_txtbox.Text = "75.00";
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            // Clear the textboxes when the New button is clicked
            itemname_txtbox.Clear();
            price_txtbox.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
