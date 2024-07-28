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
    public partial class main : Form
    {
        public main()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alogin ob = new alogin(1);
            ob.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            alogin ob = new alogin(4);
            this.Hide();
            ob.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            alogin ob = new alogin(3);
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alogin ob = new alogin(2);
            this.Close();
            ob.Show();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

    }
}
