using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace IMS
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }
        public static string con_function()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = system; Password = Oracle@123;";
        }
        private void company1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            get_data_order_comp();
            test = true;
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("no data currently exist");
            }
            else
            {
                bunifuDatepicker1.Hide();
                label2.Hide();

                dataGridView1.Show();

            }


        }

        private void company2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            get_data_order_comp2();
            test = false;
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("no data currently exist");
            }
            else
            {
               bunifuDatepicker1.Hide();
                label2.Hide();

                dataGridView1.Show();

            }

        }
        public void get_data_order_comp()
        {

            try
            {
                string MyConnection2 =con_function();
                //Display query  
                string Query = "select * from product where pending=0";
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

        public void get_data_order_comp2()
        {

            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";
                //Display query  
                string Query = "select * from product2 where pending=0;";
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
        public void get_data_order_pending_monthly()
        {

            year = Int32.Parse(bunifuDatepicker1.Value.Year.ToString());
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) AS 'Month' FROM `product` WHERE year(date)=" + this.year + "  GROUP by month(date);";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void get_data_order_pending_monthly2()
        {

            year = Int32.Parse(bunifuDatepicker1.Value.Year.ToString());
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) AS 'Month' FROM `product2` WHERE year(date)=" + this.year + "  GROUP by month(date);";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int year = 2021;

        bool che;
        private void main_page_Load(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            label1.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton25.Hide();
            label2.Hide();
            dataGridView1.Hide();
            bunifuDatepicker1.Hide();
        }
        public void delete2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                string Query = "delete from product2 where id=" + this.p_code + ";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void delete()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                string Query = "delete from product where id=" + this.p_code + ";";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void company1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
      
            pictureBox1.Hide();
            che = true;
            dataGridView1.ClearSelection();
            dataGridView1.Hide();
            label2.Show();
            bunifuDatepicker1.Show();
        }

        private void company2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            che = false;
            dataGridView1.ClearSelection();
            dataGridView1.Hide();
            label2.Show();
            bunifuDatepicker1.Show();

        }

        int p_code;
        bool test;
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Hide();
            dataGridView2.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton25.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main ob = new main();
            ob.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            if (che == true)
            {

                dataGridView1.Columns.Clear();
                get_data_order_pending_monthly();
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("no data exits for given year");
                }
                else
                {
                    dataGridView1.Show();
                }

            }
            else
            {

                dataGridView1.Columns.Clear();
                get_data_order_pending_monthly2();
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("no data exits for given year");
                }
                else
                {
                    dataGridView1.Show();
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void get_req()
        {
            try
            {
                string MyConnection2 = con_function();

                //Display query  
                //        string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
                string Query = "select * from qty_req ";
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
                //// MyConn2.Close();  
                dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                dataGridView2.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void get_req2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //        string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
                string Query = "select * from qty_req2 ;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                // MyConn2.Close();  
                dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                dataGridView2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void company1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            get_req();
            che = true;
            label1.Show();
            bunifuThinButton21.Show();
            bunifuThinButton25.Show();
            dataGridView2.Show();
            pictureBox1.Hide();
            dataGridView1.Hide();
        }
        private void update_qty_status2()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                string Query = "update qty_req2 set status = '1' where id=" + this.cr + ";";

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Successfully Approved");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void update_qty_status()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                string Query = "update qty_req set status = '1'  where id=" + this.cr + "";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MySqlDataReader MyReader2;
                //MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();
                //MessageBox.Show("Successfully Approved");
                //while (MyReader2.Read())
                //{
                //}
                //MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void update()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 =con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                string Query = "update inventory set quantity = '" + this.qty + "' where id=" + this.cr + "";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MySqlDataReader MyReader2;
                //MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();
                //MessageBox.Show("Quantity Successfully Updated in inventory");
                //while (MyReader2.Read())
                //{
                //}
                //MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void update2()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                string Query = "update inventory2 set quantity = '" + this.qty + "' where id=" + this.cr + ";";

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Quantity Successfully Updated in inventory");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int cr = 0, qty = 0;

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            cr = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            qty = Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            if (che == true)
            {
                update();
                update_qty_status();
                get_req();
            }
            else
            {
                update2();
                update_qty_status2();
                get_req2();
            }
        }
        void del_req()
        {
            try
            {
                string MyConnection2 =con_function();

                //Display query  
                //        string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
                //                string Query = "select * from qty_req ;";
                string Query = "delete from qty_req where id=" + this.cr + "";
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
                // MyConn2.Close();  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void del_req2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //Display query  
                //        string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
                //                string Query = "select * from qty_req ;";
                string Query = "delete from qty_req2 where id=" + this.cr + "";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                // MyConn2.Close();  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cr = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            if (che == true)
            {
                del_req();
                get_req();
            }
            else
            {
                del_req2();
                get_req2();
            }
        }

        private void pendingCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Hide();
            dataGridView2.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton25.Hide();

        }

        private void company2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            get_req2();
            che = false;
            label1.Show();
            bunifuThinButton21.Show();
            bunifuThinButton25.Show();
            dataGridView2.Show();
            dataGridView1.Hide();
            pictureBox1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
