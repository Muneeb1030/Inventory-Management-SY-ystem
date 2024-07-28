using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class splash : Form
    {
        public splash()
        {
        
            InitializeComponent();
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            t += 2;
            if (t > 50)
            {
                main ob = new main();
                ob.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
