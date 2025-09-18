using System;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class Lesson_2_Example_2 : Form
    {
        public Lesson_2_Example_2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Breakfast Meal B";
            price_txtbox.Text = "121.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Friend Meal A";
            price_txtbox.Text = "391.90";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Double Value Meal A";
            price_txtbox.Text = "191.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Family Combo Meal B";
            price_txtbox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Breakfast Meal A";
            price_txtbox.Text = "91.30";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Lunch Value Meal 1";
            price_txtbox.Text = "199.10";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Chicken Meal A";
            price_txtbox.Text = "177.30";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Family Combo Meal A";
            price_txtbox.Text = "99.90";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Pasta Meal 101";
            price_txtbox.Text = "98.00";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Breakfast Meal B";
            price_txtbox.Text = "91.30";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Lunch Value Meal B";
            price_txtbox.Text = "191.30";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Breakfast Meal B";
            price_txtbox.Text = "133.30";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Pancake Value Meal A";
            price_txtbox.Text = "97.30";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Chicken Meal 2";
            price_txtbox.Text = "191.30";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Double Palaboc Meal";
            price_txtbox.Text = "120.50";
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            // Code for clearing or emptying the value of the Text property of a textbox
            itemname_txtbox.Clear();
            price_txtbox.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
