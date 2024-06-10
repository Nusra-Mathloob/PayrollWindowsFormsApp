using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

      

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            UC_Employee_Register UCEmployee = new UC_Employee_Register();
            addUserControl(UCEmployee);
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            UC_setting UCSetting = new UC_setting();
            addUserControl(UCSetting);
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            UC_Salary UC_Salary = new UC_Salary();
            addUserControl(UC_Salary);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            UC_Loan UC_Loan = new UC_Loan();
            addUserControl(UC_Loan);
              
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            UC_DashBoard UC_Dash = new UC_DashBoard();
            addUserControl(UC_Dash);
        }
    }
}
