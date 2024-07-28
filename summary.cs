using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace IMS
{
    public partial class summary : Form
    {
        bool ch;
        public summary(bool che)
        {
            ch = che;
            InitializeComponent();
        }
        public static string con_function()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = system; Password = Oracle@123;";
        }
        private void sum_invest()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(purchase_price) as Investment FROM inventory";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                label9.Text = dTable.Rows[0].ItemArray[0].ToString();
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sum_earn()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(recieved_amount) as earning FROM product";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                label8.Text = dTable.Rows[0].ItemArray[0].ToString();
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sum_invest2()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(purchase_price) as Investment FROM inventory2;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                label9.Text = dTable.Rows[0].ItemArray[0].ToString();
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void sum_earn2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(recieved_amount) as earning FROM product2;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                label8.Text = dTable.Rows[0].ItemArray[0].ToString();
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int year = 2021;
        private void recieved_amount()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(recieved_amount) AS 'Cash in hand',date FROM `product` WHERE year(date)= " + this.year + " && month(date) = " + this.bunifuDatepicker1.Value.Month.ToString() + " GROUP by day(date)";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTabl = new DataTable();
                //MyAdapter.Fill(dTabl);

                dataGridView3.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                  // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void recieved_amount2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(recieved_amount) AS 'Cash in hand',date FROM `product2` WHERE year(date)= " + this.year + " && month(date) = " + this.bunifuDatepicker1.Value.Month.ToString() + " GROUP by day(date);";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTabl = new DataTable();
                MyAdapter.Fill(dTabl);

                dataGridView3.DataSource = dTabl; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                  // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pending_amount()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(pending) AS 'Pending Amount',date FROM `product` WHERE year(date)= " + this.year + " && month(date) = " + this.bunifuDatepicker1.Value.Month.ToString() + " GROUP by day(date)";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTabl = new DataTable();
                //MyAdapter.Fill(dTabl);

                dataGridView4.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void pending_amount2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(pending) AS 'Pending Amount',date FROM `product2` WHERE year(date)= " + this.year + " && month(date) = " + this.bunifuDatepicker1.Value.Month.ToString() + " GROUP by day(date);";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTabl = new DataTable();
                MyAdapter.Fill(dTabl);

                dataGridView4.DataSource = dTabl; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                  // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sale_amount()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(total_price) AS 'Sales Amount',date FROM `product` WHERE year(date)= " + this.year + " && month(date) = " + this.bunifuDatepicker1.Value.Month.ToString() + " GROUP by day(date)";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTabl = new DataTable();
                //MyAdapter.Fill(dTabl);

                dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void sale_amount2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(total_price) AS 'Sales Amount',date FROM `product2` WHERE year(date)= " + this.year + " && month(date) = " + this.bunifuDatepicker1.Value.Month.ToString() + " GROUP by day(date);";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTabl = new DataTable();
                MyAdapter.Fill(dTabl);

                dataGridView2.DataSource = dTabl; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                  // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int stoc_pro_qty = 0;
        private void sto_pro()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT COUNT(*) FROM inventory";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                label4.Text = dTable.Rows[0].ItemArray[0].ToString();
                                     // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void sto_pro2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT COUNT(*) FROM inventory2;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                label4.Text = dTable.Rows[0].ItemArray[0].ToString();
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sale_pro()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT COUNT(*) FROM product";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                label5.Text = dTable.Rows[0].ItemArray[0].ToString();
                                               // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void sale_pro2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT COUNT(*) FROM product2;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                label5.Text = dTable.Rows[0].ItemArray[0].ToString();
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void get_investment()
        {

            year = Int32.Parse(bunifuDatepicker1.Value.Year.ToString());
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                 string Query=" SELECT SUM(purchase_price) AS 'Investment ',date FROM `inventory` WHERE year(date)= "+this.year + " && month(date) = " + this.bunifuDatepicker1.Value.Month.ToString() + " GROUP by day(date)";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);
                    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void get_investment2()
        {
           // dateTimePicker1.Text = bunifuDatepicker1.Value;
            year = Int32.Parse(bunifuDatepicker1.Value.Year.ToString());
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";
                string Query = " SELECT SUM(purchase_price) AS 'Investment ',date FROM `inventory2` WHERE year(date)= " + this.year + " && month(date) = " + this.bunifuDatepicker1.Value.Month.ToString() + " GROUP by day(date);";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                 // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void summary_Load(object sender, EventArgs e)
        {
            if(ch==true)
            {
                sum_invest();
                sum_earn();
                sto_pro();
                sale_pro();
            }
            else
            {
                sum_invest2();
                sum_earn2();
                sto_pro2();
                sale_pro2();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin_pg1 ob = new admin_pg1();
            ob.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            if (ch == true)
            {
                get_investment();
                sale_amount();
                recieved_amount();
                pending_amount();
            }
            else
            {
                get_investment2();
                sale_amount2();
                recieved_amount2();
                pending_amount2();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
