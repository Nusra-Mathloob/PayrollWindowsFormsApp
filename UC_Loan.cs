using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UC_Loan : UserControl
    {
        public UC_Loan()
        {
            InitializeComponent();
        }

        private void addBasicSalaryBtn_Click(object sender, EventArgs e)
        {
            using (add_applicant_form aaf = new add_applicant_form())
            {
                aaf.ShowDialog();
            }
        }

        private void issueSalaryBtn_Click(object sender, EventArgs e)
        {
            using (add_new_loan_form anlf = new add_new_loan_form())
            {
                anlf.ShowDialog();
            }
        }

        private void advanceSalarySchemeBtn_Click(object sender, EventArgs e)
        {
            using (add_loan_scheme_form alsf = new add_loan_scheme_form())
            {
                alsf.ShowDialog();
            }
        }

        private void issueAdvanceSalaryBtn_Click(object sender, EventArgs e)
        {
            using (add_installment_form vif = new add_installment_form())
            {
                vif.ShowDialog();
            }
        }
    }
}
