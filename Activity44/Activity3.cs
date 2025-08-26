using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity44
{
    public partial class Activity3 : Form
    {
        public Activity3()
        {
            InitializeComponent();
        }
        private void Activity3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
        }
        private void A_FriedChickenCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FoodARdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // code for changing the form background color to light cyan
            this.BackColor = Color.LightCyan;

            // code for Food Bundle A not to be selected if Food Bundle A is selected
            FoodBRdbtn.Checked = false;

            // Inserting image inside the picture box
            DisplayPictureBox.Image = Properties.Resources.FoodBundlesA;

            // codes to check the checkboxes if Food Bundle A is selected
            A_FriedChickenCheckBox.Checked = true;
            A_KFCSpecialRiceCheckBox.Checked = true;
            A_SaltBreadCheckBox.Checked = true;
            A_LargeFriesCheckBox.Checked = true;
            A_SweetCornCheckBox.Checked = true;

            // codes to uncheck the checkboxes if Food Bundle A is selected
            B_IcedTeaCheckBox.Checked = false;
            B_JollyChickenCheckBox.Checked = false;
            B_PeachMangoPieCheckBox.Checked = false;
            B_PlainRiceCheckBox.Checked = false;
            B_RegularFriesCheckBox.Checked = false;

            // codes for displaying data isnde the textboxes
            pricetxtbox.Text = "₱1,000.00";
            discounttxtbox.Text = "(20% of the Price) ₱200.00";
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
            A_FriedChickenCheckBox.Checked = false;
            A_KFCSpecialRiceCheckBox.Checked = false;
            A_SaltBreadCheckBox.Checked = false;
            A_LargeFriesCheckBox.Checked = false;
            A_SweetCornCheckBox.Checked = false;

            // codes to uncheck the checkboxes if Food Bundle B is selected
            B_IcedTeaCheckBox.Checked = true;
            B_JollyChickenCheckBox.Checked = true;
            B_PeachMangoPieCheckBox.Checked = true;
            B_PlainRiceCheckBox.Checked = true;
            B_RegularFriesCheckBox.Checked = true;

            // codes for displaying data isnde the textboxes
            pricetxtbox.Text = "₱1,299.00";
            discounttxtbox.Text = "(15% of the Price) ₱194.85";
        }

        private void A_KFCSpecialRiceCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
            // codes to uncheck all given checkboxes
            FoodARdbtn.Checked = false; 
            FoodBRdbtn.Checked = false;

            // code for inserting default image inside the picture box
            DisplayPictureBox.Image = Properties.Resources.defaultfood;

            // codes for clearing the checkboxes and textboxes
            A_FriedChickenCheckBox.Checked = false;
            A_KFCSpecialRiceCheckBox.Checked = false;
            A_SaltBreadCheckBox.Checked = false;
            A_LargeFriesCheckBox.Checked = false;
            A_SweetCornCheckBox.Checked = false;
            B_IcedTeaCheckBox.Checked = false;
            B_JollyChickenCheckBox.Checked = false;
            B_PeachMangoPieCheckBox.Checked = false;
            B_PlainRiceCheckBox.Checked = false;
            B_RegularFriesCheckBox.Checked = false;

            // codes for clearing the textboxes
            pricetxtbox.Clear();
            discounttxtbox.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
