using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIOSKS
{
    public partial class Activity2 : Form
    {
        public Activity2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void itemnanetxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void qtytxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            itemnanetxtbox.Enabled = false;
            pricetxtbox.Enabled = false; 
            totalqtytextbox.Enabled = false;    
            discountedamounttxtbox.Enabled = false; 
            changetxtbox.Enabled = false;
            totaldiscountedamounttxtbox.Enabled = false;
            totaldiscountgiventxtbox.Enabled = false;   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Breakfast Meal A";
            pricetxtbox.Text = "91.30";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Breakfast Meal B";
            pricetxtbox.Text = "121.30";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Breakfast Meal C";
            pricetxtbox.Text = "91.30";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Breakfast Meal D";
            pricetxtbox.Text = "133.30";
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Chicken Meal A";
            pricetxtbox.Text = "191.30";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Chicken Meal B";
            pricetxtbox.Text = "177.30";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Double Pasta Meal";
            pricetxtbox.Text = "300.30";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Double Value Meal A";
            pricetxtbox.Text = "250.99";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Double Value Meal B";
            pricetxtbox.Text = "191.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Family Combo Meal A";
            pricetxtbox.Text = "299.99";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Family Combo Meal B";
            pricetxtbox.Text = "799.30";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Jolly Meal Savers";
            pricetxtbox.Text = "69.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Lunch Value Meal A";
            pricetxtbox.Text = "191.10";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Lunch Value Meal B";
            pricetxtbox.Text = "191.30";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Pancake Value Meal A";
            pricetxtbox.Text = "97.30";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Pasta Meal A";
            pricetxtbox.Text = "98.00";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Rice Bowl Meal";
            pricetxtbox.Text = "125.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Zinger Steak Meal";
            pricetxtbox.Text = "120.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Chicken Spaghetti Meal";
            pricetxtbox.Text = "150.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Text = "Zinger Burger";
            pricetxtbox.Text = "75.00";
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            itemnanetxtbox.Clear();
            pricetxtbox.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
