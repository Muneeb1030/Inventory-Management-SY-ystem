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
using System.Data.OleDb;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
namespace IMS
{
    public partial class senior_page : Form
    {
        public senior_page()
        {
            InitializeComponent();
        }
        alogin se = new alogin(1);
        public static string con_function()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = system; Password = Oracle@123;";
        }
        void del_req()
        {
            try
            {
                string MyConnection2 =  con_function();

                //Display query  
                //        string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
                //                string Query = "select * from qty_req ;";
                string  Query = "delete from qty_req where id=" + this.cr + "";
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
        //    try
        //    {
        //      //  string MyConnection2 =  se.function();

        //        //Display query  
        //        //        string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
        //        //                string Query = "select * from qty_req ;";
        //        string Query = "delete from qty_req2 where id=" + this.cr + "";

        //        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

        //        //  MyConn2.Open();  
        //        //For offline connection we weill use  MySqlDataAdapter class.  
        //        MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        //        MyAdapter.SelectCommand = MyCommand2;
        //        DataTable dTable = new DataTable();
        //        MyAdapter.Fill(dTable);
        //        // MyConn2.Close();  

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        }
        public void get_req()
        {
            try
            {
                string MyConnection2 =  con_function();

                //Display query  
                //        string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
                string Query = "select * from qty_req order by Status asc";
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
            //try
            //{
            //  //  string MyConnection2 =  se.function();

            //    //Display query  
            //    //        string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
            //    string Query = "select * from qty_req2 order by Status asc;";

            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            //    //  MyConn2.Open();  
            //    //For offline connection we weill use  MySqlDataAdapter class.  
            //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;
            //    DataTable dTable = new DataTable();
            //    MyAdapter.Fill(dTable);
            //    // MyConn2.Close();  
            //    dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            //    dataGridView2.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
        public void pending_0 ()
        {
            try
            {
                string MyConnection2 =  con_function();

                //Display query  
                string Query = "update product set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + "";
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void pending2_0()
        {
            try
            {
              //  string MyConnection2 =  se.function();

                ////Display query  
                //string Query = "update product2 set recieved_amount=recieved_amount + pending,pending=0 where id=" + this.p_code + ";";
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
        int year = 2021;
       // int month = 05;
        
        public void get_data_order_pending_monthly()
        {

            year =Int32.Parse(bunifuDatepicker1.Value.Year.ToString());
            try
            {
                string MyConnection2 =  con_function();
                
                //Display query  
               string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) AS 'Month' FROM `product` WHERE year(date)=" + this.year +"  GROUP by month(date)";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                ///  string Query=" SELECT SUM(pending) AS 'Pending Amount ',date FROM `product` WHERE year(date)= "+this.year + " && month(date) = " + this.dateTimePicker1.Text.Substring(5, 2) + " GROUP by day(date);";
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                ////  MyConn2.Open();  
                ////For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);
                dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void get_data_order_pending_monthly2()
        {

            //year = Int32.Parse(bunifuDatepicker1.Value.Year.ToString());
            //try
            //{
            //    string MyConnection2 =  se.function();

            //    //Display query  
            //    string Query = "SELECT SUM(recieved_amount) AS 'Cash In Hand',SUM(pending) AS 'Pending Amount ', MonthName(date) AS 'Month' FROM `product2` WHERE year(date)=" + this.year + "  GROUP by month(date);";

            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            //    //  MyConn2.Open();  
            //    //For offline connection we weill use  MySqlDataAdapter class.  
            //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;
            //    DataTable dTable = new DataTable();
            //    MyAdapter.Fill(dTable);
            //        dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
        
        public void get_data_order_pending()
        {

            try
            {
                string MyConnection2 =  con_function();
                //Display query  
                string Query = "select * from product where pending>0";
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
        public void get_data_order_pending2()
        {

            //try
            //{
            //    string MyConnection2 =  se.function();
            //    //Display query  
            //    string Query = "select * from product2 where pending>0;";
            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    //  MyConn2.Open();  
            //    //For offline connection we weill use  MySqlDataAdapter class.  
            //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;
            //    DataTable dTable = new DataTable();
            //    MyAdapter.Fill(dTable);
            //    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            //                                       // MyConn2.Close();  
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }
        private void senior_page_Load(object sender, EventArgs e)
        {
            
            label3.Hide();
            label1.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton25.Hide();
            label1.Hide();
            clearToolStripMenuItem.Enabled = false;
            dataGridView1.Hide();
            dataGridView2.Hide();
            bunifuDatepicker1.Hide();
            label2.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        int p_code=0;

        bool ch_sen_main;
        private void company1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Pending Customers";
            label1.Show();
            dataGridView2.Hide();
            label3.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton25.Hide();
            pictureBox1.Hide();
            clearToolStripMenuItem.Enabled = true;
                get_data_order_pending();
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
        bool che = true;
        private void company1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "Reports";
            label1.Show();
            dataGridView2.Hide();
            label3.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton25.Hide();
            pictureBox1.Show();
            label1.Show();
            che = true;
            dataGridView1.ClearSelection();
            dataGridView1.Hide();
            label2.Show();
            bunifuDatepicker1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p_code = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (test == true)
            {
                pending_0();
                MessageBox.Show("successfully cleared ");
                get_data_order_pending();

            }
            else
            {
                pending2_0();
                MessageBox.Show("successfully cleared ");
                get_data_order_pending2();

            }

            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearToolStripMenuItem.Enabled = false;

        }
        bool test;
        private void company2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Pending Customers";
            label1.Show();
            dataGridView2.Hide();
            label3.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton25.Hide();
            pictureBox1.Hide();
            clearToolStripMenuItem.Enabled = true;
                get_data_order_pending2();
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

        private void company2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "Reports";
            label1.Show();
            dataGridView2.Hide();
            label3.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton25.Hide();
            pictureBox1.Show();
            label1.Show();
            che =false;
            dataGridView1.ClearSelection();
            dataGridView1.Hide();
            label2.Show();
            bunifuDatepicker1.Show();

        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            main ob = new main();
            ob.Show();
        }

        private void pendingCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            if (che == true)
            {

                dataGridView2.Columns.Clear();
                get_data_order_pending_monthly();
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("no data exits for given year");
                }
                else
                {
                    dataGridView2.Show();
                }

            }
            else
            {

                dataGridView2.Columns.Clear();
                get_data_order_pending_monthly2();
                if (dataGridView2.Rows.Count == 0)
                {
                    MessageBox.Show("no data exits for given year");
                }
                else
                {
                    dataGridView2.Show();
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label1.Hide();
            bunifuDatepicker1.Hide();
            label3.Show();
            bunifuThinButton25.Show();
            bunifuThinButton21.Show();
        
            dataGridView1.Hide();
            bunifuThinButton21.Show();
            bunifuThinButton25.Show();
            che = true;
            pictureBox1.Hide();
            get_req();
        
        }

        private void company2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Hide();
            bunifuDatepicker1.Hide();
            label2.Hide();
            label3.Show();
            bunifuThinButton25.Show();
            bunifuThinButton21.Show();
            dataGridView1.Hide();
            bunifuThinButton21.Show();
            bunifuThinButton25.Show();
            che = false;
            pictureBox1.Hide();
            get_req2();
        
        }
        //private void update_qty_status2()
        //{
        //    try
        //    {
        //        //This is my connection string i have assigned the database file address path  
        //        string MyConnection2 =  se.function();

        //        //This is my update query in which i am taking input from the user through windows forms and update the record.  

        //        string Query = "update qty_req2 set status = '1' where id=" + this.cr + ";";

        //        //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
        //        //This is  MySqlConnection here i have created the object and pass my connection string.  
        //        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();
        //        MessageBox.Show("Successfully Approved");
        //        while (MyReader2.Read())
        //        {
        //        }
        //        MyConn2.Close();//Connection closed here  
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
        private void update_qty_status()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 =  con_function();

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
        int st;
        private void chech_status()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string sql = "select status from qty_req where id=" + this.cr + "";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                MyConn2.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MySqlConnection MyConnn = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommandd = new MySqlCommand(sql, MyConnn);
                ////MySqlDataReader MyReaderr;
                //MyConnn.Open();
                OracleCommand ob = new OracleCommand(sql, MyConn2);
                var tmp = ob.ExecuteReader();
                if (tmp.HasRows)
                {
                    tmp.Read();// Get first record.
                    st = int.Parse(tmp.GetString(0));
                }
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
                string MyConnection2 =  con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string sql = "select quantity from Inventory where id=" + this.p_id + "";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                MyConn2.Open();
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MySqlConnection MyConnn = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommandd = new MySqlCommand(sql, MyConnn);
                ////MySqlDataReader MyReaderr;
                //MyConnn.Open();
                OracleCommand ob = new OracleCommand(sql,MyConn2);
                var tmp = ob.ExecuteReader();
                if (tmp.HasRows)
                {
                    tmp.Read();// Get first record.
                    x = int.Parse(tmp.GetString(0));
                }
                int tquan = x + this.qty;
                string My2 = con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                // , status = 'Approved'
                string Query = "update Inventory set quantity = '" + tquan + "' where id=" + this.p_id + "";
                OracleConnection MyCon2 = new OracleConnection(My2);
                MyCon2.Open();
                OracleDataAdapter MAdapter = new OracleDataAdapter(Query, MyCon2);
                DataTable dTble = new DataTable();
                MAdapter.Fill(dTble);

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MySqlDataReader MyReader2;
                //MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();
                //MessageBox.Show("Quantity Successfully Updated in Inventory");
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
        int x;
//        private void update2()
//        {
//            try
//            {
//                //This is my connection string i have assigned the database file address path  
////                string MyConnection2 =  se.function();

//                //This is my update query in which i am taking input from the user through windows forms and update the record.
//                string sql = "select quantity from Inventory2 where id=" + this.p_id + ";";

//                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
//                MySqlConnection MyConnn = new MySqlConnection(MyConnection2);
//                MySqlCommand MyCommandd = new MySqlCommand(sql, MyConnn);
//                //MySqlDataReader MyReaderr;
//                MyConnn.Open();

//                var tmp = MyCommandd.ExecuteReader();
//                if (tmp.HasRows)
//                {
//                    tmp.Read();// Get first record.
//                    x = int.Parse(tmp.GetString(0));
//                }
//                int tquan = x + this.qty;

//                //This is my update query in which i am taking input from the user through windows forms and update the record.  
//                //set recieved_amount = recieved_amount + pending, pending = 0

//                string Query = "update inventory2 set quantity = '" + tquan + "', status = 'Approved' where id=" + this.p_id + ";";

//                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
//                //This is  MySqlConnection here i have created the object and pass my connection string.  
//                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
//                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
//                MySqlDataReader MyReader2;
//                MyConn2.Open();
//                MyReader2 = MyCommand2.ExecuteReader();
//                MessageBox.Show("Quantity Successfully Updated in Inventory");
//                while (MyReader2.Read())
//                {
//                }
//                MyConn2.Close();//Connection closed here  
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }

//        }
        int cr=0,qty=0;
        int p_id;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cr = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            p_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            qty = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow.Cells[0].Value!=null)
            {

                cr = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                p_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
                qty = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                chech_status();
                if (st == 1)
                {
                    MessageBox.Show("product is already aproved");
                }
                else
                {
                    if (che == true)
                    {
                        update();
                        update_qty_status();
                        get_req();
                    }
                    else
                    {
                        //  update2();
                        //update_qty_status2();
                        get_req2();
                    }
                }
            }
            else
            {
                MessageBox.Show(" not selected ");
            }
        }
    }
}
