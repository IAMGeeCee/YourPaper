using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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

        List<Image> imgListImages = new List<Image>();
        int CurrentImage;

        private void btnUpload_Click(object sender, EventArgs e)
        {
            (new Upload()).Show();
            this.Hide();
        }

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
                    MemoryStream ms = new MemoryStream(bytes);

                    imgListImages.Add(Image.FromStream(ms));
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
