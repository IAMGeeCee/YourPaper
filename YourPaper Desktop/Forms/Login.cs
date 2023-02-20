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
using YourPaper_Desktop.Properties;

namespace YourPaper_Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void SignUp(object sender, EventArgs e)
        {
            (new SignUp()).Show();
            Hide();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=CLENCYHOME\\SQLEXPRESS;Initial Catalog=YourPaper;Integrated Security=True");
                connection.Open();

                SqlCommand SelectCommand = new SqlCommand("Select count(*) from Users where Email='" + txtEmail.Text + "' and Password='" + txtPasswords.Text + "'", connection);//Create the query
                int NumOfCorrect = Convert.ToInt32(SelectCommand.ExecuteScalar().ToString());//Count Correct Users
                if (NumOfCorrect == 1)
                {
                    Settings.Default.IsFirstUse = false;
                    Settings.Default.Email = txtEmail.Text;
                    (new Splash()).Show();
                    Hide();
                }
                else if (NumOfCorrect < 1)
                {
                    MessageBox.Show("Incorrenct Password");
                }
                else
                {
                    MessageBox.Show("Duplicate account");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}