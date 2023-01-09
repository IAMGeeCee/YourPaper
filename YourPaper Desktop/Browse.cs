using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourPaper_Desktop
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        #region Database
        List<Image> imgListImages = new List<Image>();
        int CurrentImage;
        MemoryStream CurrentImageStream;

        private void Browse_Load(object sender, EventArgs e)
        {
            CurrentImage = 0;
            try
            {
                for (int i = 1; i < 50; i++)
                {
                    SqlConnection connection = new SqlConnection("Data Source=CLENCYHOME\\SQLEXPRESS;Initial Catalog=YourPaper;Integrated Security=True");
                    connection.Open();
                    SqlCommand binaryData = new SqlCommand("select Image from Wallpapers where ID=" + i + ";", connection);// use your code to retrive image from database and store it into 'object' data type
                    byte[] bytes = (byte[])binaryData.ExecuteScalar();
                    CurrentImageStream = new MemoryStream(bytes);

                    imgListImages.Add(Image.FromStream(CurrentImageStream));
                    if (i == 1)
                    {
                        picImage.Image = imgListImages[0];
                    }
                }
            }
            catch (ArgumentNullException)
            {
            }
        }
        #endregion

        #region TitleBar
        //Buttons
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
            Application.Exit();
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            (new Upload()).Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentImage++;
                picImage.Image = imgListImages[CurrentImage];
            }
            catch (ArgumentOutOfRangeException)
            {
                CurrentImage--;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentImage--;
                picImage.Image = imgListImages[CurrentImage];
            }
            catch (ArgumentOutOfRangeException)
            {
                CurrentImage++;
            }
        }


    }
}
