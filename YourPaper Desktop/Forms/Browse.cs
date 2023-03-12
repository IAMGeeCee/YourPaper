using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace YourPaper_Desktop
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
            //Stops it going over the taskbar
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }

        #region Database
        readonly List<Image> imgListImages = new List<Image>();
        MemoryStream CurrentImageStream;

        public void LoadImages()
        {
            flpWallpapers.Controls.Clear();
            //Loads first 50 images
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


                    PictureBox pictureBox = new PictureBox()
                    {
                        Image = imgListImages[i - 1],
                        Height = 200,
                        Width = 400,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Tag = (new SqlCommand("SELECT Title FROM Wallpapers WHERE ID='" + i + "';", connection)).ExecuteScalar().ToString() + "|" + (new SqlCommand("SELECT Description FROM Wallpapers WHERE ID='" + i + "';", connection)).ExecuteScalar().ToString(),

                    };
                    pictureBox.MouseEnter += PictureHover;
                    pictureBox.MouseLeave += PictureMouseLeave;
                    pictureBox.Click += PictureClick;
                    flpWallpapers.Controls.Add(pictureBox);
                    connection.Close();

                }
            }
            catch (ArgumentNullException)
            {

            }
        }

        private void Browse_Load(object sender, EventArgs e)
        {
            LoadImages();
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
            //Shows the upload form
            Upload upload = new Upload()
            {
                Location = Location,
                StartPosition = FormStartPosition.CenterScreen,
                WindowState = FormWindowState.Normal
            };
            upload.Show();
        }

        //These methods control the pictureboxes
        public void PictureHover(object sender, EventArgs e)
        {
            //Gives it a border on hover
            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
        }

        public void PictureMouseLeave(object sender, EventArgs e)
        {
            //hides the border when hover is stopped
            ((PictureBox)sender).BorderStyle = BorderStyle.None;
        }

        public void PictureClick(object sender, EventArgs e)
        {
            //Opens a save dialog and saves the image currently in the picture box
            //SaveFileDialog saveFile = new SaveFileDialog();
            //saveFile.Title = "Save";
            //saveFile.Filter = "Jpeg image(*.jpeg)|*.jpeg";
            //if (saveFile.ShowDialog() == DialogResult.OK)
            //{
            //    ((PictureBox)sender).Image.Save(saveFile.FileName, ImageFormat.Jpeg);
            //}

            picImage.Image = ((PictureBox)sender).Image;
            lblImgTitle.Text = ((PictureBox)sender).Tag.ToString().Split('|')[0];
            lblDescription.Text = ((PictureBox)sender).Tag.ToString().Split('|')[1];
            pnlImage.Visible = true;
            pnlImage.BringToFront();
        }

        //Search
        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pnlImage.Visible = false;
                pnlImage.SendToBack();

                List<Image> DiscoveredImages = new List<Image>();

                SqlConnection connection = new SqlConnection("Data Source=CLENCYHOME\\SQLEXPRESS;Initial Catalog=YourPaper;Integrated Security=True");
                connection.Open();

                //Counts rows in database
                SqlCommand GetNumOfRows = new SqlCommand("SELECT COUNT(*) FROM Wallpapers;", connection);
                int intNumOfRows = (int)GetNumOfRows.ExecuteScalar();

                for (int i = 1; i <= intNumOfRows; i++)
                {
                    //Checks if it has the search query in the title
                    SqlCommand SearchCommand = new SqlCommand("Select Title From Wallpapers Where ID='" + i + "';", connection);
                    if (SearchCommand.ExecuteScalar().ToString().Contains(Search.Text))
                    {
                        //if it is then it adds it
                        SqlCommand binaryData = new SqlCommand("select Image from Wallpapers where ID=" + i + ";", connection);// use your code to retrive image from database and store it into 'object' data type
                        byte[] bytes = (byte[])binaryData.ExecuteScalar();

                        CurrentImageStream = new MemoryStream(bytes);

                        DiscoveredImages.Add(Image.FromStream(CurrentImageStream));
                    }
                }

                flpWallpapers.Controls.Clear();

                foreach (Image imgWallpaper in DiscoveredImages)
                {

                    PictureBox pictureBox = new PictureBox()
                    {
                        Image = imgWallpaper,
                        Height = 200,
                        Width = 400,
                        SizeMode = PictureBoxSizeMode.StretchImage,

                    };
                    pictureBox.MouseEnter += PictureHover;
                    pictureBox.MouseLeave += PictureMouseLeave;
                    pictureBox.Click += PictureClick;
                    flpWallpapers.Controls.Add(pictureBox);
                }

                connection.Close();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadImages();
            Search.Text = "Type to search";
        }


        //Image selected
        private void btnSave_Click(object sender, EventArgs e)
        {

            //Opens a save dialog and saves the image currently in the picture box
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save";
            saveFile.Filter = "Jpeg image(*.jpeg)|*.jpeg";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                picImage.Image.Save(saveFile.FileName, ImageFormat.Jpeg);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlImage.Visible = false;
            pnlImage.SendToBack();
        }
    }
}
