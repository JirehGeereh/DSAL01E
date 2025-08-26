using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVITY4
{
    public partial class Activity3 : Form
    {
        public Activity3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            // code for changing the form background color
            this.BackColor = Color.LightGoldenrodYellow;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // code for changing the form background color to light cyan
            this.BackColor = Color.LightCyan;

            // code for Food Bundle B not to be selected if Food Bundle A is selected
            FoodBRdbtn.Checked = false;

            // Inserting image inside the picture box
            DisplayPictureBox.Image = Properties.Resources.FoodBundlesA;

            // codes to check the checkboxes if Food Bundle A is selected
            A_FriedChickenCheckBox.Checked = true;
            A_FriedChickenCheckBox.Checked = true;
            A_SaltBreadCheckBox.Checked = true;
            A_LargeFriesCheckBox.Checked = true;   
            A_SaltBreadCheckBox.Checked = true;

            // codes to uncheck the checkboxes if Food Bundle A is selected
            B_IcedTeaCheckBox.Checked = false;
            B_JollyChickenCheckBox.Checked = false;
            B_PeachMangoPieCheckBox.Checked = false;
            B_PlainRiceCheckBox.Checked = false;
            B_RegularFriesCheckBox.Checked = false;

            // codes for displaying data isnde the textboxes
            pricetxtbox.Text = "₱ 1,000.00";
            discounttxtbox.Text = "(20% of the Price) ₱ 200.00";
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FoodBRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // code for changing the form background color to light cyan
            this.BackColor = Color.LightBlue;

            // code for Food Bundle B not to be selected if Food Bundle B is selected
            FoodARdbtn.Checked = false;

            // Inserting image inside the picture box
            DisplayPictureBox.Image = Properties.Resources.FoodBundlesB;

            // codes to check the checkboxes if Food Bundle B is selected
            B_IcedTeaCheckBox.Checked = true;
            B_JollyChickenCheckBox.Checked = true;
            B_PeachMangoPieCheckBox.Checked = true;
            B_PlainRiceCheckBox.Checked = true;
            B_RegularFriesCheckBox.Checked = true;

            // codes to uncheck the checkboxes if Food Bundle B is selected
            A_FriedChickenCheckBox.Checked = false;
            A_FriedChickenCheckBox.Checked = false;
            A_SaltBreadCheckBox.Checked = false;
            A_LargeFriesCheckBox.Checked = false;
            A_SaltBreadCheckBox.Checked = false;

            // codes for displaying data isnde the textboxes
            pricetxtbox.Text = "₱ 1,299.00";
            discounttxtbox.Text = "(15% of the Price) ₱ 194.85";
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
