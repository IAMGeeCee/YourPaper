using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace YourPaper_Desktop
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        #region Titlebar
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TitleButton_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(53, 53, 53);
        }

        private void TitleButton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Transparent;
        }

        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        string ImagePath = null;

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            //Opens a file select dialog to choose file to upload
            ofdFileSelect.Multiselect = false;
            if (ofdFileSelect.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofdFileSelect.FileName);
                string filePath = ofdFileSelect.FileName;
           
                imgImage.Image = Image.FromStream(ofdFileSelect.OpenFile());
                ImagePath = filePath;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Upload image
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=CLENCYHOME\\SQLEXPRESS;Initial Catalog=YourPaper;Integrated Security=True");
                connection.Open();

                byte[] imgData = File.ReadAllBytes(ImagePath);
                SqlCommand Upload = new SqlCommand("INSERT INTO [dbo].[Wallpapers]([Image],[Title],[Description]) VALUES(@Image,'"+txtTitle.Text+"','"+txtDescription.Text+"')",connection);
                SqlParameter sqlParam = Upload.Parameters.AddWithValue("@Image", imgData);
                sqlParam.DbType = DbType.Binary;
                Upload.ExecuteNonQuery();

                connection.Close();

                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error : " + ex.Message);
            }
        }
    }
}
