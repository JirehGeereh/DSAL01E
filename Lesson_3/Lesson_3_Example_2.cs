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
    public partial class Lesson_3_Example_2 : Form
    {
        public Lesson_3_Example_2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Breakfast Meal A";
            price_txtbox.Text = "91.30";
        }

        private void Example2_Load(object sender, EventArgs e)
        {
            itemname_txtbox.Enabled = false;
            price_txtbox.Enabled = false;
            totalqty_txtbox.Enabled = false;
            discountedamount_txtbox.Enabled = false;
            change_txtbox.Enabled = false;
            totaldiscountedamount_txtbox.Enabled = false;
            totaldiscountgiven_txtbox.Enabled = false;
            discountamount_txtbox.Enabled = false;
        }

        private void itemnane_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Breakfast_Meal_B_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Breakfast Meal B";
            price_txtbox.Text = "121.30";
        }

        private void Breakfast_Meal_C_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Breakfast Meal C";
            price_txtbox.Text = "91.30";
        }

        private void Breakfast_Meal_D_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Breakfast Meal D";
            price_txtbox.Text = "133.30";
        }

        private void Chicken_Meal_A_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Chicken Meal A";
            price_txtbox.Text = "191.30";
        }

        private void Chicken_Meal_B_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Chicken Meal B";
            price_txtbox.Text = "177.30";
        }

        private void Double_Pasta_Meal_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Double Pasta Meal";
            price_txtbox.Text = "300.30";
        }

        private void Double_Value_Meal_A_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Double Value Meal A";
            price_txtbox.Text = "200.00";
        }

        private void Double_Value_Meal_B_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Double Value Meal B";
            price_txtbox.Text = "191.00";
        }

        private void Family_Combo_Meal_A_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Family Combo Meal A";
            price_txtbox.Text = "299.99";
        }

        private void Family_Combo_Meal_B_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Family Combo Meal B";
            price_txtbox.Text = "799.30";
        }

        private void Jolly_Meal_Savers_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Jolly Meal Savers";
            price_txtbox.Text = "69.00";
        }

        private void Lunch_Value_Meal_A_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Lunch Value Meal A";
            price_txtbox.Text = "191.10";
        }

        private void Lunch_Value_Meal_B_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Lunch Value Meal B";
            price_txtbox.Text = "191.30";
        }

        private void Pancake_Value_Meal_A_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Pancake Value Meal A";
            price_txtbox.Text = "97.30";
        }

        private void Pasta_Meal_A_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Pasta Meal A";
            price_txtbox.Text = "98.00";
        }

        private void Rice_Bowl_Meal_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Rice Bowl Meal";
            price_txtbox.Text = "125.00";
        }

        private void Zinger_Steak_Meal_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Zinger Steak Meal";
            price_txtbox.Text = "120.00";
        }

        private void Chicken_Spaghetti_Meal_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Chicken Spaghetti Meal";
            price_txtbox.Text = "150.00";
        }

        private void Zinger_Burger_picbox_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Text = "Zinger Burger";
            price_txtbox.Text = "75.00";
        }

        private void seniorcitizen_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            int qty;
            double price, discount_amount, discounted_amount;

            // Convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(price_txtbox.Text);

            // Create a formula needed for computation
            discount_amount = (qty * price) * 0.30;
            discounted_amount = (qty * price) - discount_amount;

            // Converting numeric data to string and display it inside the textboxes
            discountamount_txtbox.Text = discount_amount.ToString("n");
            discountedamount_txtbox.Text = discounted_amount.ToString("n");

            // Codes for unchecking the other radio buttons in the interface once with disc. card method is executed
            withdisccard_radbtn.Checked = false;
            employeedisc_radbtn.Checked = false;
            nodiscount_radbtn.Checked = false;
        }

        private void withdisccard_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            int qty;
            double price, discount_amount, discounted_amount;

            // Convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(price_txtbox.Text);

            // Create a formula needed for computation
            discount_amount = (qty * price) * 0.10;
            discounted_amount = (qty * price) - discount_amount;

            // Converting numeric data to string and display it inside the textboxes
            discountamount_txtbox.Text = discount_amount.ToString("n");
            discountedamount_txtbox.Text = discounted_amount.ToString("n");

            // Codes for unchecking the other radio buttons in the interface once with disc. card method is executed
            seniorcitizen_radbtn.Checked = false;
            employeedisc_radbtn.Checked = false;
            nodiscount_radbtn.Checked = false;
        }

        private void employeedisc_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            int qty;
            double price, discount_amount, discounted_amount;

            // Convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(price_txtbox.Text);

            // Create a formula needed for computation
            discount_amount = (qty * price) * 0.15;
            discounted_amount = (qty * price) - discount_amount;

            // Converting numeric data to string and display it inside the textboxes
            discountamount_txtbox.Text = discount_amount.ToString("n");
            discountedamount_txtbox.Text = discounted_amount.ToString("n");

            // Codes for unchecking the other radio buttons in the interface once with disc. card method is executed
            seniorcitizen_radbtn.Checked = false;
            withdisccard_radbtn.Checked = false;
            nodiscount_radbtn.Checked = false;
        }

        private void nodiscount_radbtn_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            int qty;
            double price, discount_amount, discounted_amount;

            // Convert string data from textboxes to numeric and place it as value of the variable
            qty = Convert.ToInt32(qty_txtbox.Text);
            price = Convert.ToDouble(price_txtbox.Text);

            // Create a formula needed for computation
            discount_amount = (qty * price) * 0;
            discounted_amount = (qty * price) - discount_amount;

            // Converting numeric data to string and display it inside the textboxes
            discountamount_txtbox.Text = discount_amount.ToString("n");
            discountedamount_txtbox.Text = discounted_amount.ToString("n");

            // Codes for unchecking the other radio buttons in the interface once with disc. card method is executed
            seniorcitizen_radbtn.Checked = false;
            employeedisc_radbtn.Checked = false;
            withdisccard_radbtn.Checked = false;
        }
        int qty_total;
        double discount_total_given, discounted_total;
        private void calculatebtn_Click(object sender, EventArgs e)
        {
            // Decration of variables with data types
            int qty;
            double discount_amount, discounted_amount, cash_rendered, change;


            qty = Convert.ToInt32(qty_txtbox.Text);
            discount_amount = Convert.ToDouble(discountamount_txtbox.Text);
            discounted_amount = Convert.ToDouble(discountedamount_txtbox.Text);
            cash_rendered = Convert.ToDouble(cashrendered_txtbox.Text);

            // Codes to accumulate the value of the quantity, discount given, and discounted amount from one transaction to another.
            qty_total += qty;
            discount_total_given += discount_amount;
            discounted_total += discounted_amount;
            change = cash_rendered - discounted_amount;

            // Converting string data form textboxes to numeric and place it as value of the variable
            totalqty_txtbox.Text = qty_total.ToString();
            totaldiscountgiven_txtbox.Text = discount_total_given.ToString("n");
            totaldiscountedamount_txtbox.Text = discounted_total.ToString("n");
            change_txtbox.Text = change.ToString("n");
            cashrendered_txtbox.Text = cash_rendered.ToString("n");


        }

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Clear();
            qty_txtbox.Clear();
            price_txtbox.Clear();
            discountamount_txtbox.Clear();
            discountedamount_txtbox.Clear();
            cashrendered_txtbox.Clear();
            change_txtbox.Clear(); 
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            itemname_txtbox.Clear();
            qty_txtbox.Clear();
            price_txtbox.Clear();
            discountamount_txtbox.Clear();
            discountedamount_txtbox.Clear();
            totalqty_txtbox.Clear();
            totaldiscountgiven_txtbox.Clear();
            totaldiscountedamount_txtbox.Clear();
            cashrendered_txtbox.Clear();
            change_txtbox.Clear();
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            // Codes for calling the other form connected to the current form.
            Lesson_3_Example_2_Prelims_Exam print = new Lesson_3_Example_2_Prelims_Exam();

            // Codes for displaying the contents of the textbox from this form to the other form.
            print.itemname_txtbox.Text = this.itemname_txtbox.Text;
            print.qty_txtbox.Text = this.qty_txtbox.Text;
            print.price_txtbox.Text = this.price_txtbox.Text;
            print.discountamount_txtbox.Text = this.discountamount_txtbox.Text;
            print.discountedamount_txtbox.Text = this.discountedamount_txtbox.Text;
            print.totalqty_txtbox.Text = this.totalqty_txtbox.Text;
            print.totaldiscountgiven_txtbox.Text = this.totaldiscountgiven_txtbox.Text;
            print.totaldiscountedamount_txtbox.Text = this.totaldiscountedamount_txtbox.Text;
            print.change_txtbox.Text = this.change_txtbox.Text;

            print.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
