using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5
{
    public partial class Lesson_5_Activity_Print_Form : Form
    {
        public Lesson_5_Activity_Print_Form()
        {
            InitializeComponent();
        }

        private void Lesson_5_Activity_Print_Form_Load(object sender, EventArgs e)
        {
            company_txtbox.BorderStyle = BorderStyle.None;
            company_txtbox.BackColor = this.BackColor; 

            emp_code_txtbox.BorderStyle = BorderStyle.None;
            emp_code_txtbox.BackColor = this.BackColor;

            emp_name_txtbox.BorderStyle = BorderStyle.None;
            emp_name_txtbox.BackColor = this.BackColor;

            department_txtbox.BorderStyle = BorderStyle.None;
            department_txtbox.BackColor = this.BackColor;

            cutoff_txtbox.BorderStyle = BorderStyle.None;
            cutoff_txtbox.BackColor = this.BackColor;

            payperiod_txtbox.BorderStyle = BorderStyle.None;
            payperiod_txtbox.BackColor = this.BackColor;

            basicpay_txtbox.BorderStyle = BorderStyle.None;
            basicpay_txtbox.BackColor = this.BackColor;

            overtime_txtbox.BorderStyle = BorderStyle.None;
            overtime_txtbox.BackColor = this.BackColor;

            honorarium_txtbox.BorderStyle = BorderStyle.None;
            honorarium_txtbox.BackColor = this.BackColor;

            honorariumadjustment_txtbox.BorderStyle = BorderStyle.None;
            honorariumadjustment_txtbox.BackColor = this.BackColor;
            
            substitution_txtbox.BorderStyle = BorderStyle.None;
            substitution_txtbox.BackColor = this.BackColor;

            tardy_txtbox.BorderStyle = BorderStyle.None;
            tardy_txtbox.BackColor = this.BackColor;

            earnings_txtbox.BorderStyle = BorderStyle.None;
            earnings_txtbox.BackColor = this.BackColor;

            withholdingtax_txtbox.BorderStyle = BorderStyle.None;
            withholdingtax_txtbox.BackColor = this.BackColor;

            sss_contrib_txtbox.BorderStyle = BorderStyle.None;
            sss_contrib_txtbox.BackColor = this.BackColor;

            hdmf_contrib_txtbox.BorderStyle = BorderStyle.None;
            hdmf_contrib_txtbox.BackColor = this.BackColor;

            philhealth_contrib_txtbox.BorderStyle = BorderStyle.None;
            philhealth_contrib_txtbox.BackColor = this.BackColor;

            ssswisp_contrib_txtbox.BorderStyle = BorderStyle.None;
            ssswisp_contrib_txtbox.BackColor = this.BackColor;

            grossearnings_txtbox.BorderStyle = BorderStyle.None;
            grossearnings_txtbox.BackColor = this.BackColor;

            deductions_txtbox.BorderStyle = BorderStyle.None;
            deductions_txtbox.BackColor = this.BackColor;

            deductions1_txtbox.BorderStyle = BorderStyle.None;
            deductions1_txtbox.BackColor = this.BackColor;

            netpay_txtbox.BorderStyle = BorderStyle.None;
            netpay_txtbox.BackColor = this.BackColor;
        }

        private void grossearnings_txtbox_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
