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
    public partial class Example_1 : Form
    {
        public Example_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputdisplay_txtbox.Enabled = false;
        }

        private void sum_btn_Click(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            double firstinput, secondinput, thirdinput, fourthinput, sum;
            
            // Converting input read as string to numeric value
            firstinput = Convert.ToDouble(firstinput_txtbox.Text);
            secondinput = Convert.ToDouble(secondinput_txtbox.Text);
            thirdinput = Convert.ToDouble(thirdinput_txtbox.Text);
            fourthinput = Convert.ToDouble(fourthinput_txtbox.Text);

            // Creating formula for simple adding of four input numbers
            sum = firstinput + secondinput + thirdinput + fourthinput;

            // Converting the numeric value reside inside the variables and display 
            // it in the textbox
            outputdisplay_txtbox.Text = sum.ToString("n");
        }

        private void outputdisplay__txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void difference_btn_Click(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            double firstinput, secondinput, thirdinput, fourthinput, difference;

            // Converting input read as string to numeric value
            firstinput = Convert.ToDouble(firstinput_txtbox.Text);
            secondinput = Convert.ToDouble(secondinput_txtbox.Text);
            thirdinput = Convert.ToDouble(thirdinput_txtbox.Text);
            fourthinput = Convert.ToDouble(fourthinput_txtbox.Text);

            // Creating formula for simple subtracting of four input numbers
            difference = firstinput - secondinput - thirdinput - fourthinput;

            // Converting the numeric value reside inside the variables and display 
            // it in the textbox
            outputdisplay_txtbox.Text = difference.ToString("n");
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            double firstinput, secondinput, thirdinput, fourthinput, product;

            // Converting input read as string to numeric value
            firstinput = Convert.ToDouble(firstinput_txtbox.Text);
            secondinput = Convert.ToDouble(secondinput_txtbox.Text);
            thirdinput = Convert.ToDouble(thirdinput_txtbox.Text);
            fourthinput = Convert.ToDouble(fourthinput_txtbox.Text);

            // Creating formula for simple multiplying of four input numbers
            product = firstinput * secondinput * thirdinput * fourthinput;

            // Converting the numeric value reside inside the variables and display 
            // it in the textbox
            outputdisplay_txtbox.Text = product.ToString("n");
        }

        private void quotient_btn_Click(object sender, EventArgs e)
        {
            // Declaration of variables within a method of an object
            double firstinput, secondinput, thirdinput, fourthinput, quotient;

            // Converting input read as string to numeric value
            firstinput = Convert.ToDouble(firstinput_txtbox.Text);
            secondinput = Convert.ToDouble(secondinput_txtbox.Text);
            thirdinput = Convert.ToDouble(thirdinput_txtbox.Text);
            fourthinput = Convert.ToDouble(fourthinput_txtbox.Text);

            // Creating formula for simple multiplying of four input numbers
            quotient = firstinput / secondinput / thirdinput / fourthinput;

            // Converting the numeric value reside inside the variables and display 
            // it in the textbox
            outputdisplay_txtbox.Text = quotient.ToString("n");
        }
    }
}
