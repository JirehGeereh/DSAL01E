using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable textboxes to prevent user-error inputs
            totaltuitionandfeetxtbox_disp.Enabled = false;
            totalnumberofunitstxtbox_disp.Enabled = false;   
            totalotherschoolfeestxtbox_disp.Enabled = false; 
            exambooklettxtbox_disp.Enabled = false;  
            ciscolabtxtbox_disp.Enabled = false; 
            computerlabtxtbox_disp.Enabled = false;
            totalmiscellanousfeetxtbox_disp.Enabled = false;
            totaltuitionfeetxtbox_disp.Enabled = false;
            creditunitstxtbox.Enabled = false;
            totalnumberofunitstxtbox.Enabled = false;
            totalnumberofunitstxtbox.Enabled = false;
            totaltuitionfeetxtbox.Enabled = false;
            totalmiscellanousfeetxtbox.Enabled = false;
            totaltuitionandfeetxtbox.Enabled = false;

            // Add Programs to Programs Combobox
            programscombobox.Items.Add("Aeronautical Engineering");
            programscombobox.Items.Add("Civil Engineering");
            programscombobox.Items.Add("Computer Engineering");
            programscombobox.Items.Add("Electronics Engineering");
            programscombobox.Items.Add("Electrical Engineering");
            programscombobox.Items.Add("Industrial Engineering");
            programscombobox.Items.Add("Mechanical Engineering");

        }

        private void totaltuitonandfeetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clears the relevant textboxes
            studentnametxtbox.Clear();
            studentnumbertxtbox.Clear();
            yearleveltxtbox.Clear();
            scholartxtbox.Clear();
            coursenumbertxtbox.Clear();
            coursecodetxtbox.Clear();
            coursedesctxtbox.Clear();
            unitlecturetxtbox.Clear();
            unitlabtxtbox.Clear();
            timetxtbox.Clear();
            daytxtbox.Clear();
            labfeetxtbox.Clear();
            ciscolabtxtbox.Clear();
            exambooklettxtbox.Clear();
        }

        // Global Variables
        int total_units, credit_units;
        double exam_booklet, cisco_lab, computer_laboratory, total_miscellanous_fee, computer_laboratory_accu, cisco_lab_accu, exam_booklet_accu;
        private void button3_Click(object sender, EventArgs e)
        {
            // Declaration of variables with data types for tuition fee calculation
            int lecture_units, lab_units;

            lecture_units = Convert.ToInt32(unitlecturetxtbox.Text);
            lab_units = Convert.ToInt32(unitlabtxtbox.Text);
            exam_booklet = Convert.ToDouble(exambooklettxtbox.Text);
            cisco_lab = Convert.ToDouble(ciscolabtxtbox.Text);
            computer_laboratory = Convert.ToDouble(labfeetxtbox.Text);

            // Codes to accumulate the value of the total number of units from one transaction to another.
            credit_units = lecture_units + lab_units;

            total_units += credit_units;

            total_miscellanous_fee += exam_booklet + cisco_lab + computer_laboratory;

            computer_laboratory_accu += computer_laboratory;
            cisco_lab_accu += cisco_lab;
            exam_booklet_accu += exam_booklet;

            // Converting string data form textboxes to numeric and place it as value of the variable
            creditunitstxtbox.Text = credit_units.ToString();
            totalnumberofunitstxtbox.Text = total_units.ToString();
            totalmiscellanousfeetxtbox.Text = total_miscellanous_fee.ToString();
            
            totalmiscellanousfeetxtbox_disp.Text = total_miscellanous_fee.ToString("n");

            computerlabtxtbox_disp.Text = computer_laboratory_accu.ToString("n");
            ciscolabtxtbox_disp.Text = cisco_lab_accu.ToString("n");
            exambooklettxtbox_disp.Text = exam_booklet_accu.ToString("n");

            // Add to listbox the entered data from textboxes
            coursenumberlistbox.Items.Add(coursenumbertxtbox.Text);
            coursecodelistbox.Items.Add(coursecodetxtbox.Text);
            coursedesclistbox.Items.Add(coursedesctxtbox.Text);
            unitleclistbox.Items.Add(unitlecturetxtbox.Text);
            unitlablistbox.Items.Add(unitlabtxtbox.Text);
            creditunitslistbox.Items.Add(creditunitstxtbox.Text);   
            timelistbox.Items.Add(timetxtbox.Text);
            daylistbox.Items.Add(daytxtbox.Text);

            totaltuitionfeetxtbox_disp.Text = totaltuitionfeetxtbox.Text;
            totalmiscellanousfeetxtbox_disp.Text = totalmiscellanousfeetxtbox.Text; 
            totalnumberofunitstxtbox_disp.Text = totalnumberofunitstxtbox.Text;
            totaltuitionandfeetxtbox_disp.Text = totaltuitionandfeetxtbox.Text;
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Opens file dialog to select picture to be uploaded
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                studimage.Image = Image.FromFile(dlg.FileName);

        }

        private void totalmiscellanousfeetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalmiscellanousfeetxtbox_disp_TextChanged(object sender, EventArgs e)
        {

        }
        // Global Variable
        double tuitionfeeperunit;
        private void calculatetuitionfee_btn_Click(object sender, EventArgs e)
        {
            // Declaration of variables with data types for tuition fee calculation
            double total_number_of_units, total_tuition_fee, total_tuition_and_fee;

            tuitionfeeperunit = 1700.00;
            total_number_of_units = Convert.ToDouble(totalnumberofunitstxtbox.Text);

            // Formulas to calculate total tuition fee and total tuition and fee
            total_tuition_fee = tuitionfeeperunit * total_number_of_units;
            total_tuition_and_fee = total_tuition_fee + total_miscellanous_fee;

            // Converting string data form textboxes to numeric and place it as value of the variable
            totaltuitionfeetxtbox.Text = total_tuition_fee.ToString("n");
            totaltuitionfeetxtbox_disp.Text = total_tuition_fee.ToString("n");
            totaltuitionandfeetxtbox_disp.Text = total_tuition_and_fee.ToString("n");
            totaltuitionandfeetxtbox.Text = total_tuition_and_fee.ToString("n");
            totalotherschoolfeestxtbox_disp.Text = total_miscellanous_fee.ToString("n");
        }
    }
}
