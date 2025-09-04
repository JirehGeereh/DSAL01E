using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class Example_4 : Form
    {
        public Example_4()
        {
            InitializeComponent();
        }

        private void foodA_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // code for Food Bundle A not to be selected if Food Bundle A is selected
            foodB_rdbtn.Checked = false;

            // code for changing the form background color to light cyan
            this.BackColor = Color.LightCyan;

            // Inserting image inside the picture box
            display_picbox.Image = Properties.Resources.FoodBundlesA;

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
            price_txtbox.Text = "₱1,000.00";
            discount_txtbox.Text = "(20% of the Price) ₱200.00";
        }

        private void foodB_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            // code for Food Bundle B not to be selected if Food Bundle B is selected
            foodA_rdbtn.Checked = false;

            // code for changing the form background color to light cyan
            this.BackColor = Color.LightBlue;

            // Inserting image inside the picture box
            display_picbox.Image = Properties.Resources.FoodBundlesB;

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
            price_txtbox.Text = "₱1,299.00";
            discount_txtbox.Text = "(15% of the Price) ₱194.85";
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            // codes to uncheck all given checkboxes
            foodA_rdbtn.Checked = false;
            foodB_rdbtn.Checked = false;

            // code for changing the form background color to light goldenrod yellow
            this.BackColor = Color.LightGoldenrodYellow;

            // code for inserting default image inside the picture box
            display_picbox.Image = Properties.Resources.defaultimage;

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
            price_txtbox.Clear();
            discount_txtbox.Clear();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
