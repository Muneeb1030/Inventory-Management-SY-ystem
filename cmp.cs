using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace IMS
{
    public partial class cmp : Form
    {
        public cmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comp_pro = true;
            view_stock ob = new view_stock(comp_pro);
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jf1 ob = new jf1();
            this.Hide();
            ob.Show();

        }

        private void cmp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            jf1 ob = new jf1();
            this.Hide();
            ob.Show();
        }
       public  bool comp_pro = true;
        private void button3_Click(object sender, EventArgs e)
        {
            comp_pro = true;
            this.Hide();
            porder ob = new porder(comp_pro);
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //comp_pro = false;
            
            //this.Hide();
            //porder ob = new porder(comp_pro);
            //ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            //comp_pro = false;
            //view_stock ob = new view_stock(comp_pro);
            //ob.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            main ob = new main();
            ob.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
