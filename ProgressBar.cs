using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechArmy
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
           

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(5);
            if (progressBar.Value == 100)
            {
                timer.Enabled = false;
                Login form = new Login();
                form.Show();
                this.Hide();
            }
        }
    }
}
