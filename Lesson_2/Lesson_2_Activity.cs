using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class Lesson_2_Activity : Form
    {
        public Lesson_2_Activity()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            // Add to listbox the entered data from textboxes
            coursenumber_listbox.Items.Add(coursenumber_txtbox.Text);
            coursecode_listbox.Items.Add(coursecode_txtbox.Text);
            coursedesc_listbox.Items.Add(coursedesc_txtbox.Text);
            unitlec_listbox.Items.Add(unitlecture_txtbox.Text);
            unitlab_listbox.Items.Add(time_txtbox.Text);
            creditunits_listbox.Items.Add(creditunits_txtbox.Text);
            time_listbox.Items.Add(unitlab_txtbox.Text);
            day_listbox.Items.Add(day_txtbox.Text);

            // Add to output textboxes the entered data from input textboxes
            totaltuitionfee_txtbox_disp.Text = totaltuitionfee_txtbox.Text;
            totalmiscfee_txtbox_disp.Text = ciscolabfee_txtbox.Text;
            totalunits_txtbox_disp.Text = totalunits_txtbox.Text;
            totaltuitionandfee_txtbox_disp.Text = totaltuitionandfee_txtbox.Text;
            computerlab_txtbox_disp.Text = labfee_txtbox.Text;
            ciscolabfee_txtbox_disp.Text = totalmiscfee_txtbox.Text;
            exambookletfee_txtbox_disp.Text = exambookletfee_txtbox.Text;
        }

        private void studentname_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_cancel_btn_Click(object sender, EventArgs e)
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
            unitlab_txtbox.Clear();
            time_txtbox.Clear();
            day_txtbox.Clear();
            labfee_txtbox.Clear();
            ciscolabfee_txtbox.Clear();
            exambookletfee_txtbox.Clear();
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            // Opens file dialog to select picture to be uploaded
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                studentimage_picbox.Image = Image.FromFile(dlg.FileName);
        }
    }
}
