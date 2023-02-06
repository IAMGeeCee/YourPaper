using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace YourPaper_Desktop
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Login()).Show();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=CLENCYHOME\\SQLEXPRESS;Initial Catalog=YourPaper;Integrated Security=True");
                connection.Open();

                SqlCommand SignUpCommand = new SqlCommand("INSERT INTO [dbo].[Users] ([Email],[Password],[FirstName],[LastName]) VALUES ('" + txtEmail.Text + "','" + txtPassword.Text + "','" + txtName.Text.Split(' ')[0] + "','" + txtName.Text.Split(' ')[1] + "');",connection);
                SignUpCommand.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Succsess!");
                this.Hide();
                (new Login()).Show();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
