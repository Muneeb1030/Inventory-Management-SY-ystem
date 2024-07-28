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
    public partial class alogin : Form
    {
        int ch;
        public alogin(int tmp)
        {
            ch = tmp;
            InitializeComponent();
         //   bunifuTextbox2.PasswordChar = '*';
           // textBox2.MaxLength = 14;

        }
        public string id,pass;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id = bunifuTextbox1.text;
        }
        public static string con_function()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = system; Password = Oracle@123;";
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void alogin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void check_login1()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                //string Query = "update inventory2 set quantity = '" + this.numericUpDown1.Value + "' where id=" + this.cr + ";";
                string Query = "SELECT * FROM admin_login WHERE user_name = '"+this.bunifuTextbox2.text+ "' AND password = '"+this.bunifuTextbox1.text+"'";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);


                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                ////MySqlDataReader MyReader2;
                //MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();
                //  MessageBox.Show("Request has been sent successfully");
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    admin_pg1 ob = new admin_pg1();
                    this.Hide();
                    ob.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect user-name and password");
                }
                MyConn2.Close();//Connection closed here  

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }
        private void check_login2()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                //string Query = "update inventory2 set quantity = '" + this.numericUpDown1.Value + "' where id=" + this.cr + ";";
                string Query = "SELECT * FROM main_login WHERE user_name = '" + this.bunifuTextbox2.text + "' AND password = '" + this.bunifuTextbox1.text + "'";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                ////MySqlDataReader MyReader2;
                //MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();
                //  MessageBox.Show("Request has been sent successfully");
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    main_page ob = new main_page();
                    this.Hide();
                    ob.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect user-name and password");
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void check_login3()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                //string Query = "update inventory2 set quantity = '" + this.numericUpDown1.Value + "' where id=" + this.cr + ";";
                string Query = "SELECT * FROM senior_login WHERE user_name = '" + this.bunifuTextbox2.text + "' AND password = '" + this.bunifuTextbox1.text + "'";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                ////MySqlDataReader MyReader2;
                //MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();
                //  MessageBox.Show("Request has been sent successfully");
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    senior_page ob = new senior_page();
                    this.Hide();
                    ob.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect user-name and password");
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void check_login4()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  

                //string Query = "update inventory2 set quantity = '" + this.numericUpDown1.Value + "' where id=" + this.cr + ";";
                string Query = "SELECT * FROM junior_login WHERE user_name = '" + this.bunifuTextbox2.text + "' AND password = '" + this.bunifuTextbox1.text + "'";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                ////MySqlDataReader MyReader2;
                //MyConn2.Open();
                //MyReader2 = MyCommand2.ExecuteReader();
                //  MessageBox.Show("Request has been sent successfully");
                //MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                //MyAdapter.SelectCommand = MyCommand2;
                //DataTable dTable = new DataTable();
                //MyAdapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    cmp ob = new cmp();
                    this.Hide();
                    ob.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect user-name and password");
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (ch==1)
            {
                check_login1();
            
            }
            else if(ch == 2)
            {
                check_login2();
            }
            else if (ch == 3)
            {
                check_login3();
            }
            else if (ch == 4)
            {
                check_login4();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            main ob = new main();
            ob.Show();
            this.Hide();
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {
            id = bunifuTextbox2.text;
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            pass = bunifuTextbox1.text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //id = bunifuTextbox2.text;
        }
    }
}
