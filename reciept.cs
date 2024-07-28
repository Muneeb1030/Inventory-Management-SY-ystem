using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace IMS
{
    public partial class reciept : Form
    {
        public string date;
        public reciept()
        {
            InitializeComponent();
            date = DateTime.Now.ToString("M/d/yyyy");
           
        }
        private void order_cash_Load(object sender, EventArgs e)
        {
          
            //    label1.Text = date;
            //    dataGridView2.Rows.Add("customer id", "");
            //    dataGridView2.Rows.Add("customer id", this.dataGridView1.Rows[0].Cells[1].Value.ToString());
            //    dataGridView2.Rows.Add("Customer Name ", this.dataGridView1.Rows[0].Cells[2].Value.ToString());
            //    dataGridView2.Rows.Add("phone number", this.dataGridView1.Rows[0].Cells[3].Value.ToString());
            //    dataGridView2.Rows.Add(" Customer address", this.dataGridView1.Rows[0].Cells[4].Value.ToString());
            //    dataGridView2.Rows.Add("product name", this.dataGridView1.Rows[0].Cells[8].Value.ToString());
            //    dataGridView2.Rows.Add("product code", this.dataGridView1.Rows[0].Cells[7].Value.ToString());
            //    dataGridView2.Rows.Add("description", this.dataGridView1.Rows[0].Cells[10].Value.ToString());
            //    dataGridView2.Rows.Add("category", this.dataGridView1.Rows[0].Cells[11].Value.ToString());
            //    dataGridView2.Rows.Add("quantity", this.dataGridView1.Rows[0].Cells[9].Value.ToString());
            //    dataGridView2.Rows.Add("unit price", this.dataGridView1.Rows[0].Cells[5].Value.ToString());
            //    dataGridView2.Rows.Add("total price", this.dataGridView1.Rows[0].Cells[6].Value.ToString());
            //    dataGridView2.Rows.Add("recieved amount", this.dataGridView1.Rows[0].Cells[12].Value.ToString());
            //    dataGridView2.Rows.Add("pending amount", this.dataGridView1.Rows[0].Cells[13].Value.ToString());
            //    dataGridView2.Rows[0].Visible = false;

            //    this.reportViewer1.RefreshReport();
            //    this.reportViewer2.RefreshReport();
            //    this.reportViewer3.RefreshReport();
            //    this.reportViewer4.RefreshReport();
            //    this.reportViewer1.RefreshReport();
            //    this.reportViewer1.RefreshReport();
            //    this.reportViewer2.RefreshReport();
            //   this.reportViewer2.RefreshReport();
        }



        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // Rectangle pagearea = e.PageBounds;
            //e.Graphics.DrawImage(mimg, pagearea.Width/6 , this.panel1.Location.X);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reciept_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[1].Value!=null)
            {


                System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
                ps.Landscape = true;
                ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
                ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;
                reportViewer1.SetPageSettings(ps);
                //////////////////////////
                ReportParameterCollection reportparameter = new ReportParameterCollection();
                //reportparameter.Add(new ReportParameter("ReportParameter1", "asd"));
                //reportparameter.Add(new ReportParameter("customername", Globalvariables.username.ToString()));
                //reportparameter.Add(new ReportParameter("customeraddress", Globalvariables.username.ToString()));
                //  this.reportViewer1.LocalReport.SetParameters(reportparameter);
                ReportParameter[] parameters = new ReportParameter[14];

                parameters[0] = new ReportParameter("cname", dataGridView1.Rows[0].Cells[2].Value.ToString(), true);
                parameters[1] = new ReportParameter("cphone", dataGridView1.Rows[0].Cells[3].Value.ToString(), true);
                parameters[2] = new ReportParameter("cid", dataGridView1.Rows[0].Cells[1].Value.ToString(), true);
                parameters[3] = new ReportParameter("caddress", dataGridView1.Rows[0].Cells[4].Value.ToString(), true);
                parameters[4] = new ReportParameter("pcode", dataGridView1.Rows[0].Cells[7].Value.ToString(), true);
                parameters[5] = new ReportParameter("pname", dataGridView1.Rows[0].Cells[8].Value.ToString(), true);
                parameters[6] = new ReportParameter("detail", dataGridView1.Rows[0].Cells[10].Value.ToString(), true);
                parameters[7] = new ReportParameter("quantity", dataGridView1.Rows[0].Cells[9].Value.ToString(), true);
                parameters[8] = new ReportParameter("price", dataGridView1.Rows[0].Cells[5].Value.ToString(), true);
                parameters[9] = new ReportParameter("tprice", dataGridView1.Rows[0].Cells[6].Value.ToString(), true);
                parameters[10] = new ReportParameter("pending", dataGridView1.Rows[0].Cells[13].Value.ToString(), true);
                parameters[11] = new ReportParameter("recieved", dataGridView1.Rows[0].Cells[12].Value.ToString(), true);
                parameters[12] = new ReportParameter("category", dataGridView1.Rows[0].Cells[11].Value.ToString(), true);
                parameters[13] = new ReportParameter("date", date, true);
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("no item selected");
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
