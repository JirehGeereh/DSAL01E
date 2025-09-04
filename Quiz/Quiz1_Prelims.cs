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
            totaltuitionandfeetxtbox_disp.Enabled = false;
            totalnumberofunitstxtbox_disp.Enabled = false;   
            totalotherschoolfeestxtbox_disp.Enabled = false; 
            exambooklettxtbox_disp.Enabled = false;  
            ciscolabtxtbox_disp.Enabled = false; 
            computerlabtxtbox_disp.Enabled = false;
            totalmiscellanousfeetxtbox_disp.Enabled = false;
            totaltuitionfeetxtbox_disp.Enabled = false;

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
            creditunitstxtbox.Clear();
            totalnumberofunitstxtbox.Clear();
            labfeetxtbox.Clear();
            totaltuitionfeetxtbox.Clear();
            totalmiscellanousfeetxtbox.Clear();
            ciscolabtxtbox.Clear();
            exambooklettxtbox.Clear();
            totaltuitionandfeetxtbox.Clear();

            totaltuitionfeetxtbox_disp.Clear();
            totalmiscellanousfeetxtbox_disp.Clear();
            ciscolabtxtbox_disp.Clear();
            computerlabtxtbox_disp.Clear();
            exambooklettxtbox_disp.Clear();
            totalotherschoolfeestxtbox_disp.Clear();
            totalnumberofunitstxtbox_disp.Clear();
            totaltuitionfeetxtbox_disp.Clear();
            totaltuitionandfeetxtbox_disp.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
            computerlabtxtbox_disp.Text = labfeetxtbox.Text;
            ciscolabtxtbox_disp.Text = ciscolabtxtbox.Text; 
            exambooklettxtbox_disp.Text = exambooklettxtbox.Text;   
            totalnumberofunitstxtbox_disp.Text = totalnumberofunitstxtbox.Text;
            totaltuitionandfeetxtbox_disp.Text = totaltuitionandfeetxtbox.Text;

        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void removefromlist_btn_Click(object sender, EventArgs e)
        {
            coursenumberlistbox.Items.RemoveAt(coursenumberlistbox.SelectedIndex);
            coursecodelistbox.Items.RemoveAt(coursecodelistbox.SelectedIndex);
            coursedesclistbox.Items.RemoveAt(coursedesclistbox.SelectedIndex);
            unitleclistbox.Items.RemoveAt(unitleclistbox.SelectedIndex);
            unitlablistbox.Items.RemoveAt(unitlablistbox.SelectedIndex);
            creditunitslistbox.Items.RemoveAt(creditunitslistbox.SelectedIndex);
            timelistbox.Items.RemoveAt(timelistbox.SelectedIndex);
            daylistbox.Items.RemoveAt(daylistbox.SelectedIndex);

        }
    }
}
