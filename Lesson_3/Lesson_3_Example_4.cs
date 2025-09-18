using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_3
{
    public partial class Lesson_3_Example_4 : Form
    {
        // Declaration of global variables
        private double amount_paid, price = 0.00, cash_given, change;
        private int quantity = 0;
        public Lesson_3_Example_4()
        {
            InitializeComponent();
        }

        private void Example_4_Load(object sender, EventArgs e)
        {
            // code to disable the change TextBox when the form loads
            change_txtbox.Enabled = false;
            itemname_txtbox.Enabled = false;
            price_txtbox.Enabled = false;
            amountpaid_txtbox.Enabled = false;

            // code for the location of the form when it loads
            this.Location = new Point(0, 0);

            //code for the size of the form when it loads
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Breakfast Meal B";
            price_txtbox.Text = "121.30";

            // code for where the cursor take place after clicking the picture box
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Friend Meal A";
            price_txtbox.Text = "391.90";
            qty_txtbox.Focus();
            qty_txtbox.Clear();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Double Value Meal A";
            price_txtbox.Text = "191.00";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Family Combo Meal B";
            price_txtbox.Text = "799.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Breakfast Meal A";
            price_txtbox.Text = "91.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Lunch Value Meal 1";
            price_txtbox.Text = "199.10";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Chicken Meal A";
            price_txtbox.Text = "177.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Family Combo Meal A";
            price_txtbox.Text = "99.90";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Pasta Meal 101";
            price_txtbox.Text = "98.00";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Breakfast Meal B";
            price_txtbox.Text = "91.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Lunch Value Meal B";
            price_txtbox.Text = "191.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Breakfast Meal B";
            price_txtbox.Text = "133.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            cash_given = Convert.ToDouble(cashgiven_txtbox.Text);
            change = cash_given - amount_paid;
            change_txtbox.Text = change.ToString("n");
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            // Code for clearing or emptying the value of the Text property of a textbox
            itemname_txtbox.Clear();
            amountpaid_txtbox.Clear();
            cashgiven_txtbox.Clear();
            change_txtbox.Clear();
            qty_txtbox.Text = "0";
            price_txtbox.Text = "0.00";

        }

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(price_txtbox.Text);
            amount_paid = price * quantity;
            amountpaid_txtbox.Text = amount_paid.ToString("n");
            cashgiven_txtbox.Focus();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Pancake Value Meal A";
            price_txtbox.Text = "97.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Chicken Meal 2";
            price_txtbox.Text = "191.30";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the Text property of a TextBox
            itemname_txtbox.Text = "Double Palaboc Meal";
            price_txtbox.Text = "120.50";
            qty_txtbox.Focus();
            qty_txtbox.Clear();
        }
    }
}
