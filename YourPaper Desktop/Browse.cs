using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            (new Upload()).Show();
            this.Hide();            
        }

        private void Browse_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=CLENCYHOME\\SQLEXPRESS;Initial Catalog=YourPaper;Integrated Security=True");
            connection.Open();
            SqlCommand binaryData = new SqlCommand("select Image from Wallpapers where Title='Test'",connection);// use your code to retrive image from database and store it into 'object' data type
            byte[] bytes = (byte[])binaryData.ExecuteScalar();
            MemoryStream ms = new MemoryStream(bytes);
            picWallpaper.Image = Image.FromStream(ms);
        }
    }
}
