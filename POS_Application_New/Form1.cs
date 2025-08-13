using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Application_New
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "121.30";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Friend Meal A";
            priceTxtbox.Text = "391.90";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Double Value Meal A";
            priceTxtbox.Text = "191.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Family Combo Meal B";
            priceTxtbox.Text = "799.30";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "91.30";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Lunch Value Meal 1";
            priceTxtbox.Text = "199.10";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Chicken Meal A";
            priceTxtbox.Text = "177.30";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Family Combo Meal A";
            priceTxtbox.Text = "999.90";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Pasta Meal 101";
            priceTxtbox.Text = "98.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Breakfast Meal A";
            priceTxtbox.Text = "91.30";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Lunch Value Meal B";
            priceTxtbox.Text = "191.30";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Breakfast Meal B";
            priceTxtbox.Text = "133.30";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Pancake Value Meal A";
            priceTxtbox.Text = "97.30";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Chicken Meal 2";
            priceTxtbox.Text = "191.30";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemnameTextbox.Text = "Double Palaboc Meal";
            priceTxtbox.Text = "120.50";
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            // Code for clearing or emptying the value of the Text property of a textbox
            itemnameTextbox.Clear();
            priceTxtbox.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            // Code for closing the execution of the Windows Form Application
            this.Close();
        }
    }
}
