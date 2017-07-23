using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayMusic_app.Controls;
using PlayMusic_app.Logic;
namespace PlayMusic_app.Forms
{
    public partial class SplashScreen : Form
    {

        public SplashScreen()
        {          
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Increment(100);
            
                Library.loadLibraryDB();                //Load library from database in order to get initial binding 
            


            MainUI main = new MainUI();
            main.Show();
            this.Hide();


        }
    }
}
