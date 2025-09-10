using System;
using System.Windows.Forms;

namespace Lesson_3
{
    public partial class Example_3 : Form
    {
        public Example_3()
        {
            InitializeComponent();
        }

        private void calculatebills_btn_Click(object sender, EventArgs e)
        {
            double cashgiven, totalamountpaid, change;

            try
            {
                cashgiven = Convert.ToDouble(cashgiven_txtbox.Text);
                totalamountpaid = Convert.ToDouble(totalbills_txtbox.Text);

                change = cashgiven - totalamountpaid;

                change_txtbox.Text = change.ToString("n");

                display_listbox.Items.Add("Total Bills: " + "" + totalbills_txtbox.Text);
                display_listbox.Items.Add("Cash Given: " + "" + cashgiven_txtbox.Text);
                display_listbox.Items.Add("Change: " + "" + change_txtbox.Text);
                display_listbox.Items.Add("Total No. of Items: " + "" + totalqty_txtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter valid data in cash given textbox!");
                cashgiven_txtbox.Clear();
                cashgiven_txtbox.Focus();
            }
        }
        int qty, total_qty;
        double price, discount_amount, discounted_amount, total_amount;

        private void qty_txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                price = Convert.ToDouble(price_txtbox.Text);
                qty = Convert.ToInt32(qty_txtbox.Text);
                discount_amount = Convert.ToDouble(discountamount_txtbox.Text);
                discounted_amount = (price * qty) - discount_amount;
                total_qty += qty;
                totalqty_txtbox.Text = total_qty.ToString();
                total_amount += discounted_amount;

                totalbills_txtbox.Text = total_amount.ToString("n");
                discountedamount_txtbox.Text = discounted_amount.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Enter number of quantity ordered!");
                qty_txtbox.Focus();
            }
        }
    }

}
