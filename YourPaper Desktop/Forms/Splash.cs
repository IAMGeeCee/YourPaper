using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourPaper_Desktop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }

        private  void Splash_Shown(object sender, EventArgs e)
        {
            //Starts wait method on new thread
            Thread thr = new Thread(new ThreadStart(wait));
            thr.Start();
        }

        public void wait()
        {
            //counts three seconds then closes this
            Thread.Sleep(3000);
            this.Invoke(new Action(delegate () { this.Hide(); }));
            this.Invoke(new Action(delegate () { (new Browse()).Show(); }));
        }
    }
}
