using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson_2_Activity
{
    public partial class Prelims_Quiz_1 : Form
    {
        public Prelims_Quiz_1()
        {
            InitializeComponent();
        }

        // Global Variables
        int total_units, credit_units;
        double exam_booklet, cisco_lab, computer_laboratory, total_miscellanous_fee;
        double computer_laboratory_accu, cisco_lab_accu, exam_booklet_accu;
        double tuitionfeeperunit;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable textboxes to prevent user-error inputs
            totaltuitionandfee_txtbox_disp.Enabled = false;
            totalunits_txtbox_disp.Enabled = false;
            totalotherschoolfees_txtbox_disp.Enabled = false;
            exambookletfee_txtbox_disp.Enabled = false;
            ciscolabfee_txtbox_disp.Enabled = false;
            computerlabfee_txtbox_disp.Enabled = false;
            totalmiscfee_txtbox_disp.Enabled = false;
            totaltuitionfee_txtbox_disp.Enabled = false;
            creditunits_txtbox.Enabled = false;
            totalunits_txtbox.Enabled = false;
            totalunits_txtbox.Enabled = false;
            totaltuitionfee_txtbox.Enabled = false;
            totalmiscfee_txtbox.Enabled = false;
            totaltuitionandfee_txtbox.Enabled = false;

            // Add Programs to Programs Combobox
            programs_combobox.Items.Add("Aeronautical Engineering");
            programs_combobox.Items.Add("Civil Engineering");
            programs_combobox.Items.Add("Computer Engineering");
            programs_combobox.Items.Add("Electronics Engineering");
            programs_combobox.Items.Add("Electrical Engineering");
            programs_combobox.Items.Add("Industrial Engineering");
            programs_combobox.Items.Add("Mechanical Engineering");

        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Clears the relevant textboxes
            studentname_txtbox.Clear();
            studentnumber_txtbox.Clear();
            yearlevel_txtbox.Clear();
            scholar_txtbox.Clear();
            coursenumber_txtbox.Clear();
            coursecode_txtbox.Clear();
            coursedesc_txtbox.Clear();
            unitlecture_txtbox.Clear();
            time_txtbox.Clear();
            unitlab_txtbox.Clear();
            day_txtbox.Clear();
            labfee_txtbox.Clear();
            ciscolabfee_txtbox.Clear();
            exambookletfee_txtbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Declaration of variables with data types for tuition fee calculation
            int lecture_units, lab_units;

            lecture_units = Convert.ToInt32(unitlecture_txtbox.Text);
            lab_units = Convert.ToInt32(unitlab_txtbox.Text);
            exam_booklet = Convert.ToDouble(exambookletfee_txtbox.Text);
            cisco_lab = Convert.ToDouble(ciscolabfee_txtbox.Text);
            computer_laboratory = Convert.ToDouble(labfee_txtbox.Text);

            // Codes to accumulate the value of the total number of units from one transaction to another.
            credit_units = lecture_units + lab_units;

            total_units += credit_units;

            total_miscellanous_fee += exam_booklet + cisco_lab + computer_laboratory;

            computer_laboratory_accu += computer_laboratory;
            cisco_lab_accu += cisco_lab;
            exam_booklet_accu += exam_booklet;

            // Converting string data form textboxes to numeric and place it as value of the variable
            creditunits_txtbox.Text = credit_units.ToString();
            totalunits_txtbox.Text = total_units.ToString();
            totalmiscfee_txtbox.Text = total_miscellanous_fee.ToString("n");

            totalmiscfee_txtbox_disp.Text = total_miscellanous_fee.ToString("n");

            computerlabfee_txtbox_disp.Text = computer_laboratory_accu.ToString("n");
            ciscolabfee_txtbox_disp.Text = cisco_lab_accu.ToString("n");
            exambookletfee_txtbox_disp.Text = exam_booklet_accu.ToString("n");

            // Add to listbox the entered data from textboxes
            coursenumber_listbox.Items.Add(coursenumber_txtbox.Text);
            coursecode_listbox.Items.Add(coursecode_txtbox.Text);
            coursedesc_listbox.Items.Add(coursedesc_txtbox.Text);
            unitlec_listbox.Items.Add(unitlecture_txtbox.Text);
            unitlab_listbox.Items.Add(unitlab_txtbox.Text);
            creditunits_listbox.Items.Add(creditunits_txtbox.Text);
            time_listbox.Items.Add(time_txtbox.Text);
            day_listbox.Items.Add(day_txtbox.Text);

            totaltuitionfee_txtbox_disp.Text = totaltuitionfee_txtbox.Text;
            totalmiscfee_txtbox_disp.Text = totalmiscfee_txtbox.Text;
            totalunits_txtbox_disp.Text = totalunits_txtbox.Text;
            totaltuitionandfee_txtbox_disp.Text = totaltuitionandfee_txtbox.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Opens file dialog to select picture to be uploaded
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                studimage.Image = Image.FromFile(dlg.FileName);

        }

        private void calculatetuitionfee_btn_Click(object sender, EventArgs e)
        {
            // Declaration of variables with data types for tuition fee calculation
            double total_number_of_units, total_tuition_fee, total_tuition_and_fee;

            tuitionfeeperunit = 1700.00;
            total_number_of_units = Convert.ToDouble(totalunits_txtbox.Text);

            // Formulas to calculate total tuition fee and total tuition and fee
            total_tuition_fee = tuitionfeeperunit * total_number_of_units;
            total_tuition_and_fee = total_tuition_fee + total_miscellanous_fee;

            // Converting string data form textboxes to numeric and place it as value of the variable
            totaltuitionfee_txtbox.Text = total_tuition_fee.ToString("n");
            totaltuitionfee_txtbox_disp.Text = total_tuition_fee.ToString("n");
            totaltuitionandfee_txtbox_disp.Text = total_tuition_and_fee.ToString("n");
            totaltuitionandfee_txtbox.Text = total_tuition_and_fee.ToString("n");
            totalotherschoolfees_txtbox_disp.Text = total_miscellanous_fee.ToString("n");
        }
    }
}
