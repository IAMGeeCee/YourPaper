using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourPaper_Desktop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}
