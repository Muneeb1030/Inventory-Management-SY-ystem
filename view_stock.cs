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
using System.IO;
using System.Data.OleDb;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace IMS
{
    public partial class view_stock : Form
    {
        bool check = true;
        public view_stock(bool ch)
        {
            check = ch;
            InitializeComponent();
        }
        public static string con_function()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = system; Password = Oracle@123;";
        }
        private void search_data()
        {
            try
            {
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select * from Inventory where name='" + this.bunifuTextbox1.text + "'";
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

                //dTable.Columns.Add("img", Type.GetType("System.Byte[]"));

                //foreach (DataRow drow in dTable.Rows)
                //{


                //    drow["img"] = File.ReadAllBytes("F:\\file\\" + drow["image"].ToString());
                //}

                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

        }
        
        private void search_data2()
        {
            try
            {
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select * from Inventory2 where name='" + this.bunifuTextbox1.text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                dTable.Columns.Add("img", Type.GetType("System.Byte[]"));

                foreach (DataRow drow in dTable.Rows)
                {


                    drow["img"] = File.ReadAllBytes("F:\\file\\" + drow["image"].ToString());
                }

                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void get_data2()
        {
            try
            {
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";
                //Display query  
                string Query = "select * from Inventory2;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                dTable.Columns.Add("img", Type.GetType("System.Byte[]"));

                foreach (DataRow drow in dTable.Rows)
                {


                    drow["img"] = File.ReadAllBytes("F:\\file\\" + drow["image"].ToString());
                }

                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void get_data()
        {
            try
            {
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select * from Inventory";
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

                //dTable.Columns.Add("img", Type.GetType("System.Byte[]"));

                //foreach (DataRow drow in dTable.Rows)
                //{


                //    drow["img"] = File.ReadAllBytes("F:\\file\\" + drow["image"].ToString());
                //}

                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void view_stock_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 9999999;
            numericUpDown1.Minimum = 0;

            if (check == false)
            {
                get_data2();
            }
            else
            {
                get_data();
            }

            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
            //    {
            //        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            //        break;
            //    }
            //dataGridView1.Columns[9].Visible = false;
            //dataGridView1.Columns[10].Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
           
        }

        private void send_qty()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function(); 
                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                //    string Query = "update inventory set quantity = '" + this.numericUpDown1.Value + "' where id=" + this.cr + ";";
                string Query = "insert into qty_req(pid,Product_Name,quantity) values('" + this.cr + "','" + this.cr_name + "','" + this.numericUpDown1.Value + "')";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //    MySqlDataReader MyReader2;
                //    MyConn2.Open();
                //    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Request has been sent successfully");
                //    while (MyReader2.Read())
                //    {
                //    }
                //    MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void send_qty2()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=localhost;Database=inventory;User Id=root;PASSWORD= ;SslMode=none";

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                //string Query = "update inventory2 set quantity = '" + this.numericUpDown1.Value + "' where id=" + this.cr + ";";
                string Query = "insert into qty_req2(id,Product_Name,quantity) values('" + this.cr + "','" + this.cr_name + "','" + this.numericUpDown1.Value + "')";

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Request has been sent successfully");
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

        string cr_name;
        int cr = 0;
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            cr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cr_name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //if (check == false)
            //{

            //    send_qty2();
            //    get_data2();
            //}
            //else
            
                send_qty();
                get_data();
            

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //if (check == false)
            //{
            //    get_data2();
            //}
            //else
            //{
                get_data();
            //}

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            //if (check == false)
            //{
            //    search_data2();
            //}
            //else
            //{
                search_data();
           // }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmp ob = new cmp();
            this.Hide();
            ob.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
