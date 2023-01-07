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

namespace YourPaper_Desktop
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {

            ofdFileSelect.Multiselect = false;
            if (ofdFileSelect.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(ofdFileSelect.FileName);
                string filePath = ofdFileSelect.FileName;
           
                imgImage.Image = Image.FromStream(ofdFileSelect.OpenFile());
            }
        }
    }
}
