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
    public partial class Lesson_3_Example_2_Prelims_Exam : Form
    {
        public Lesson_3_Example_2_Prelims_Exam()
        {
            InitializeComponent();
        }

        private void Example_2_Prelims_Exam_Load(object sender, EventArgs e)
        {
            itemname_txtbox.Enabled = false;
            qty_txtbox.Enabled = false;
            price_txtbox.Enabled = false;
            discountamount_txtbox.Enabled = false;
            discountedamount_txtbox.Enabled = false;
            totalqty_txtbox.Enabled = false;
            totaldiscountgiven_txtbox.Enabled = false;
            totaldiscountedamount_txtbox.Enabled = false;
            change_txtbox.Enabled = false;  
        }
    }
}
