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
    public partial class admin_pg1 : Form
    {
        public admin_pg1()
        {
            InitializeComponent();
        }
        public static string con_function()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = system; Password = Oracle@123;";
        }
        private void get_data_junior()
        {

            try
            {
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select * from junior_login";
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

                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void get_data_senior()
        {

            try
            {
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select * from senior_login";
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
        private void get_data_main()
        {

            try
            {
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select * from main_login";
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
        private void get_data_admin()
        {

            try
            {
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select * from admin_login";
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
        private void admin_pg1_Load(object sender, EventArgs e)
        {
            label5.Hide();
            label2.Hide();
            label1.Hide();
            label6.Hide();
            bunifuThinButton21.Hide();
            bunifuThinButton22.Hide();
            bunifuThinButton23.Hide();
            bunifuTextbox1.Hide();
            bunifuTextbox2.Hide();
            dataGridView1.Hide();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        string tp, tps;
        void add_admin()
        {

            string connetionString =con_function();
            OracleConnection MyConn2 = new OracleConnection(connetionString);
           

            //MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
//            conn.Open();
            try
            {
                tp = bunifuTextbox1.text;
                tps = bunifuTextbox2.text;
                string sql = "insert into admin_login(user_name,password) values('" + this.tp + "','" + this.tps + "')";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Data Entered Successfully");
                //conn.Close();
                get_data_admin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("user name already entered ");
            }
        }
        void add_main()
        {
            tp = bunifuTextbox1.text;
            tps = bunifuTextbox2.text;

            string connetionString =con_function();
            OracleConnection MyConn2 = new OracleConnection(connetionString);

            //MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
            //  conn.Open();
            try
            {

                string sql = "insert into main_login(user_name,password) values('" + this.tp + "','" + this.tps + "')";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Data Entered Successfully");
             //   conn.Close();
                get_data_main();
            }
            catch (Exception ex)
            {
                MessageBox.Show("user name already entered ");
            }
        }
        void add_senior()
        {

            string connetionString = con_function();
            //            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
            //          conn.Open();
            OracleConnection MyConn2 = new OracleConnection(connetionString);

            try
            {
                tp = bunifuTextbox1.text;
                tps = bunifuTextbox2.text;

                string sql = "insert into senior_login(user_name,password) values('" + this.tp + "','" + this.tps + "')";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Data Entered Successfully");
                //            conn.Close();
                get_data_senior();
            }
            catch (Exception ex)
            {
                MessageBox.Show("user name already entered ");
            }
        }
        void add_junior()
        {

            string connetionString = con_function();
            OracleConnection MyConn2 = new OracleConnection(connetionString);

            //            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
//            conn.Open();
            try
            {
                tp = bunifuTextbox1.text;
                tps = bunifuTextbox2.text;

                string sql = "insert into junior_login(user_name,password) values('" + this.tp + "','" + this.tps + "')";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Data Entered Successfully");
                //conn.Close();
                get_data_junior();
            }
            catch (Exception ex)
            {
                MessageBox.Show("user name already entered ");
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int db_id = 0;
     void del_junior()
        {
            db_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string connetionString = con_function();
            OracleConnection MyConn2 = new OracleConnection(connetionString);

            //       MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
            //          conn.Open();
            try
            {
                string sql = "delete from junior_login where id=" + this.db_id + "";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //            MySqlCommand cmd = new MySqlCommand(sql, conn);
                //              cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted row Successfully");
//                conn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Error!");
            }
            get_data_junior();
        }
        void del_senior()
        {
            db_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string connetionString = con_function();
            OracleConnection MyConn2 = new OracleConnection(connetionString);

            //        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
            //            conn.Open();
            try
            {
                string sql = "delete from senior_login where id=" + this.db_id + "";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //            MySqlCommand cmd = new MySqlCommand(sql, conn);
                //              cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted row Successfully");
//                conn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Error!");
            }
            get_data_senior();
        }
        void del_main()
        {
            db_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string connetionString = con_function();
            OracleConnection MyConn2 = new OracleConnection(connetionString);

            //            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
            //          conn.Open();
            try
            {
                string sql = "delete from main_login where id=" + this.db_id + "";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                //              MySqlCommand cmd = new MySqlCommand(sql, conn);
                //                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted row Successfully");
                //conn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Error!");
            }
            get_data_main();
        }
        void del_admin()
        {
            db_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string connetionString = con_function();
            OracleConnection MyConn2 = new OracleConnection(connetionString);

            //  MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
//            conn.Open();
            try
            {
                string sql = "delete from admin_login where id=" + this.db_id + "";
                OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

//                MySqlCommand cmd = new MySqlCommand(sql, conn);
  //              cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted row Successfully");
    //            conn.Close();
            }
            catch
            {
                MessageBox.Show("Database Connection Error!");
            }
            get_data_admin();
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        void update_junior()
        {
            db_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            try
            {
                tp = bunifuTextbox1.text;
                tps = bunifuTextbox2.text;

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update junior_login set user_name = '" + this.tp + "', password= '" + this.tps + "' where id=" + this.db_id + "";
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
                MessageBox.Show("Data Updated");
                //while (MyReader2.Read())
                //{
                //}
               // MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            get_data_junior();
        }
        void update_senior()
        {
            db_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            try
            {
                tp = bunifuTextbox1.text;
                tps = bunifuTextbox2.text;

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update senior_login set user_name= '" + this.tp + "', password= '" + tps + "' where id=" + this.db_id + "";
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
                //MessageBox.Show("Data Updated");
                //while (MyReader2.Read())
                //{
                //}
                //MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            get_data_senior();
        }
        void update_main()
        {
            db_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            try
            {
                tp = bunifuTextbox1.text;
                tps = bunifuTextbox2.text;

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update main_login set user_name= '" + this.tp + "', password= '" + this.tps + "' where id=" + this.db_id + "";
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
                //MessageBox.Show("Data Updated");
                //while (MyReader2.Read())
                //{
                //}
                //MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            get_data_main();
        }
        void update_admin()
        {
            db_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            try
            {
                tp = bunifuTextbox1.text;
                tps = bunifuTextbox2.text;

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update admin_login set user_name= '" + this.tp + "', password= '" + this.tps + "' where id=" + this.db_id + "";
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
                //MessageBox.Show("Data Updated");
                //while (MyReader2.Read())
                //{
                //}
                //MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            get_data_admin();
        }
        private void button4_Click(object sender, EventArgs e)
        {
             }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void seniorAccouhntToolStripMenuItem_Click(object sender, EventArgs e)
        {
 }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main ob = new main();
            ob.Show();
            this.Hide();
        }

        private void juniorAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int check_accout = 0;
        private void adminAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void mainAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
 }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void adminAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label5.Show();
            label2.Text = "Admin Account";
            label2.Show();
            check_accout = 1;
            get_data_admin();
            dataGridView1.Show();
            label1.Show();
            label1.Show();
            label6.Show();
            bunifuTextbox1.Show();
            bunifuTextbox2.Show();
            bunifuThinButton21.Show();
            bunifuThinButton22.Show();
            bunifuThinButton23.Show();

        }

        private void juniorAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label5.Show();
            label2.Text = "junior Account";
            label2.Show();
            check_accout = 2;
            get_data_junior();
            dataGridView1.Show();
            label1.Show();
            label1.Show();
            label6.Show();
            bunifuTextbox1.Show();
            bunifuTextbox2.Show();
            bunifuThinButton21.Show();
            bunifuThinButton22.Show();
            bunifuThinButton23.Show();

        }

        private void seniorAcccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Show();
            label2.Text = "Senior Account";
            label2.Show();
            check_accout = 3;
            get_data_senior();
            dataGridView1.Show();
            label1.Show();
            label1.Show();
            label6.Show();
            bunifuTextbox1.Show();
            bunifuTextbox2.Show();
            bunifuThinButton21.Show();
            bunifuThinButton22.Show();
            bunifuThinButton23.Show();

        }

        private void mainAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label5.Show();
            label2.Text = "Main Account";
            label2.Show();
            check_accout = 4;
            get_data_main();
            dataGridView1.Show();
            label1.Show();
            label1.Show();
            label6.Show();
            bunifuTextbox1.Show();
            bunifuTextbox2.Show();
            bunifuThinButton21.Show();
            bunifuThinButton22.Show();
            bunifuThinButton23.Show();

        }

        private void company1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            jf1 ob = new jf1();
            this.Hide();
            ob.Show();

        }

        private void company2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //jf2 ob = new jf2();
            //this.Hide();
            //ob.Show();

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void company1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            summary ob = new summary(true);
            ob.Show();
            this.Close();
        }

        private void company2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        //    summary ob = new summary(false);
        //    ob.Show();
        //    this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            if (check_accout == 1)
                del_admin();
            else if (check_accout == 2)
                del_junior();
            else if (check_accout == 3)
                del_senior();
            else if (check_accout == 4)
                del_main();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (check_accout == 1)
                add_admin();
            else if (check_accout == 2)
                add_junior();
            else if (check_accout == 3)
                add_senior();
            else if (check_accout == 4)
                add_main();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (check_accout == 1)
                update_admin();
            else if (check_accout == 2)
                update_junior();
            else if (check_accout == 3)
                update_senior();
            else if (check_accout == 4)
                update_main();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

