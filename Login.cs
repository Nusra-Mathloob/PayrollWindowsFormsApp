using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["payrollConnection"].ConnectionString;

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                if (usernametxt.Text == "" || passwordtxt.Text == "")
                {
                    MessageBox.Show("Please enter user name and password");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter param1 = new SqlParameter("@uname", SqlDbType.VarChar);
                    cmd.Parameters.Add(param1).Value = usernametxt.Text;

                    SqlParameter param2 = new SqlParameter("@pwd", SqlDbType.VarChar);
                    cmd.Parameters.Add(param2).Value = passwordtxt.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int count = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());

                    if (count > 0)
                    {
                        MessageBox.Show("You have successfully Logged In");

                        Main p = new Main();
                        //p.Name1 = usernametxt.Text;
                        p.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please check your user name and password");
                    }

                    con.Close();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
