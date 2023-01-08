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
        }

        string ImagePath = null;

        private void btnSelectImage_Click(object sender, EventArgs e)
        {

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

                (new Browse()).Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error : " + ex.Message);
            }
        }
    }
}
