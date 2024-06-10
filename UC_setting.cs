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
    public partial class UC_setting : UserControl
    {
        public UC_setting()
        {
            InitializeComponent();
        }

        private void designationBtn_Click(object sender, EventArgs e)
        {
            using (add_designation_form ds = new add_designation_form())
            {
                ds.ShowDialog();
            }
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            using (add_branch_form bf = new add_branch_form())
            {
                bf.ShowDialog();
            }
        }

        private void bonusBtn_Click(object sender, EventArgs e)
        {
            using (add_bonus_form abf  = new add_bonus_form())
            {
                abf.ShowDialog();
            }
        }

        private void allowenceBtn_Click(object sender, EventArgs e)
        {
            using (add_allowence_form alf= new add_allowence_form())
            {
                alf.ShowDialog();
            }
        }
    }
}
