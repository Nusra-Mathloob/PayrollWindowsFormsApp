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
    public partial class UC_Salary : UserControl
    {
        public UC_Salary()
        {
            InitializeComponent();
        }

        private void addBasicSalaryBtn_Click(object sender, EventArgs e)
        {
            using (add_basic_salary_form absf = new add_basic_salary_form())
            {
                absf.ShowDialog();
            }
        }

        private void issueSalaryBtn_Click(object sender, EventArgs e)
        {
            using (issue_salary_form isf = new issue_salary_form())
            {
                isf.ShowDialog();
            }
        }

        private void advanceSalarySchemeBtn_Click(object sender, EventArgs e)
        {
            using (advance_salary_scheme_form asf = new advance_salary_scheme_form())
            {
                asf.ShowDialog();
            }
        }

        private void issueAdvanceSalaryBtn_Click(object sender, EventArgs e)
        {
            using (issue_advance_salary_form iasf = new issue_advance_salary_form())
            {
                iasf.ShowDialog();
            }
        }
    }
}
