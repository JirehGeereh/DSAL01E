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
    public partial class Example_3 : Form
    {
        // codes for declaring variables that is accessible to the whole form and can be access from one object to another.
        private double total_amount = 0;
        private int total_qty = 0;
        public Example_3()
        {
            InitializeComponent();
        }
        private void Example_3_Load(object sender, EventArgs e)
        {
            // disabling textboxes
            price_txtbox.Enabled = false;
            discountamount_txtbox.Enabled = false;
            discountedamount_txtbox.Enabled = false;
            totalbills_txtbox.Enabled = false;
            totalqty_txtbox.Enabled = false;
            change_txtbox.Enabled = false;
        }
    }

}
