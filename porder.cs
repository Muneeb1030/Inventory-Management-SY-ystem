using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace IMS
{
    public partial class porder : Form
    {
        bool check = true;
        public porder(bool ch)
        {
            check = ch;
            InitializeComponent();
        }
        public static string con_function()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = system; Password = Oracle@123;";
        }
        public bool flag = true;
        public   int uprice = 0,tprice=0,qty=0,stock_quantity=0,product_sto_id=0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       public string alph = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";


        alogin se = new alogin(1);
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView3.Hide();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        
           
            if(check==false)
            {
                get_data2();
                get_data_order2();
                dataGridView2.Columns[5].Visible = false;
            }
            else
            {

                get_data();
                get_data_order();
                dataGridView2.Columns[5].Visible = false;
            }
         //   dataGridView2.Columns[9].Visible = false;
           // dataGridView2.Columns[10].Visible = false;
        
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        
        private void get_data()
        {

            try
            {
                string MyConnection2 =  con_function();
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
                dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }
        private void get_data2()
        {

            //try
            //{
            //    string MyConnection2 =  se.function();
            //    //Display query  
            //    string Query = "select * from Inventory2;";
            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    //  MyConn2.Open();  
            //    //For offline connection we weill use  MySqlDataAdapter class.  
            //    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            //    MyAdapter.SelectCommand = MyCommand2;
            //    DataTable dTable = new DataTable();
            //    MyAdapter.Fill(dTable);
            //    dataGridView2.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            //                                       // MyConn2.Close();  
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }

        public void get_data_order()
        {

            try
            {
                string MyConnection2 =  con_function();
                //Display query  
                string Query = "select * from product order by id DESC";
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
        public void get_data_order2()
        {

            //try
            //{
            //    string MyConnection2 =  se.function();
            //    //Display query  
            //    string Query = "select * from product2 order by id desc";
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        string tps;
        public void enter_data()
        {
            string cString =  con_function();
            Oracle.ManagedDataAccess.Client.OracleConnection conn = new OracleConnection(cString);
//                       Oracle.Data.OracleClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
                      conn.Open();
           // OracleConnection MyCn2 = new OracleConnection(cString);

            try
            {


                //          string code = numericUpDown1.Value.ToString();
                ////////////
                tp = bunifuTextbox2.text;
                tps = bunifuTextbox3.text;
                DateTime now = DateTime.Now;
                p_code = add_item;
                //  qty = add_quantity;
               sprice= sprice.Remove(sprice.Length - 1, 1);
                   string qry = "insert into PRODUCT(customer_id,name,phone,address,unit_price,total_price,product_code,product_name,quantity,recieved_amount,pending,pdate) values('" + this.bunifuTextbox1.text + "','" + this.tp + "','" + this.maskedTextBox1.Text + "','" + this.tps + "','" + sprice + "','" + tprice + "','" + p_code + "','" + pro_name + "','" + add_quantity + "','" + rec_amount + "','" + pending_amount+ "','" + now.ToString("yyyy-MM-dd") + "')";
//                string qry = "SELECT * FROM junior_login WHERE user_name = 'shukr' AND password = '" + 5 + "'";
               // string qry = "insert into main_login(user_name,password) values('" + 66 + "','" + 55 + "')";

                //OracleDataAdapter MyApter = new OracleDataAdapter(qry, MyCn2);
                //DataTable dTle = new DataTable();
                //MyApter.Fill(dTle);
                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                OracleCommand cmd = new OracleCommand(qry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Entered Successfully");
                //conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void enter_data2()
        {
            //string connetionString =  se.function();
            //MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            ////connection open
            //conn.Open();
            //if (conn.State == ConnectionState.Open)
            //{
            //    DateTime now = DateTime.Now;
            //    tp = bunifuTextbox2.text;
            //    tps = bunifuTextbox3.text;
            //    //      string code = numericUpDown1.Value.ToString();
            //    ////////////
            //    p_code = add_item;
            //    //  qty = add_quantity;
            //    string sql = "insert into product2(customer_id	,name	,phone	,address	,unit_price	,total_price	,product_code	,product_name,	quantity	,recieved_amount	,pending,date	) values('" + this.bunifuTextbox1.text + "','" + this.tp + "','" + this.maskedTextBox1.Text + "','" + this.tps + "','" + sprice + "','" + tprice + "','" + p_code + "','" + pro_name + "','" + add_quantity + "','" + rec_amount + "','" + pending_amount + "','" + now.ToString("yyyy-MM-dd") + "')";

            //    // string sql = "insert into product2(customer_id	,name	,phone	,address	,unit_price	,total_price	,product_code	,product_name,	quantity,	description	,category	,recieved_amount	,pending,date	) values('" + this.bunifuTextbox1.text + "','" + this.tp + "','" + this.maskedTextBox1.Text + "','" + this.tps + "','" + uprice + "','" + tprice + "','" + p_code + "','" + p_name + "','" + add_quantity + "','" + p_des + "','" + p_catg + "','" + rec_amount + "','" + pending_amount + "','" + now.ToString("yyyy-MM-dd") + "')";

            //    //                string sql = "insert into product2(customer_id	,name	,phone	,address	,unit_price	,total_price	,product_code	,product_name,	quantity,	description	,category	,recieved_amount	,pending,date	) values('" + this.bunifuTextbox1.text + "','" + this.tp + "','" + this.maskedTextBox1.Text + "','" + this.tps + "','" + uprice + "','" + tprice + "','" + p_code + "','" + p_name + "','" + qty + "','" + p_des + "','" + p_catg + "','" + rec_amount + "','" + pending_amount + "','" + now.ToString("yyyy-MM-dd") + "')";

            //    //         string sql = "insert into product2(customer_id	,name	,phone	,address	,unit_price	,total_price	,product_code	,product_name,	quantity,	description	,category	,recieved_amount	,pending,date	) values('" + this.bunifuMaterialTextbox1.Text + "','" + this.bunifuMaterialTextbox2.Text + "','" + this.maskedTextBox1.Text + "','" + this.bunifuMaterialTextbox3.Text + "','" + uprice + "','" + tprice + "','" + p_code + "','" + p_name + "','" + qty + "','" + p_des + "','" + p_catg + "','" + rec_amount + "','" + pending_amount + "','" + this.dateTimePicker1.Text + "')";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Data Entered Successfully");
            //    conn.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Database Connection Error!");
            //}

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        void add_data2()
        {
            //try
            //{
            //    //This is my connection string i have assigned the database file address path  
            //    string MyConnection2 =  se.function();

            //    //This is my update query in which i am taking input from the user through windows forms and update the record.  
            //    string Query = "update Inventory2 set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + ";";
            //    //This is  MySqlConnection here i have created the object and pass my connection string.  
            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();
            //    MessageBox.Show("Data Updated");
            //    get_data2();
            //    while (MyReader2.Read())
            //    {
            //    }
            //    MyConn2.Close();//Connection closed here  
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //            dataGridView1.Rows.Add(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, uprice, tprice, p_code, p_name, qty, p_des, p_catg, rec_amount, pending_amount);
            enter_data2();
            get_data_order2();

        }

        void add_data()
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 =  con_function();

                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update Inventory set quantity= " + this.stock_quantity + " where id=" + this.product_sto_id + "";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                OracleCommand MyCommand2 = new OracleCommand(Query, MyConn2);
                OracleDataReader MyReader2;
              //  MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
              //  get_data();
                //while (MyReader2.Read())
                //{
                //}
                //MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //            dataGridView1.Rows.Add(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, uprice, tprice, p_code, p_name, qty, p_des, p_catg, rec_amount, pending_amount);
          
            enter_data();
            get_data_order();

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmp ob = new cmp();
            ob.Show();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
         
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            reciept obj = new reciept();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                object[] rowData = new object[row.Cells.Count];
                for (int i = 0; i < rowData.Length; ++i)
                {
                    rowData[i] = row.Cells[i].Value;
                }
                obj.dataGridView1.Rows.Add(rowData);
            }
            if (dataGridView1.Rows[0].Cells[1].Value != null)
            {
                obj.Show();
            }
            else
            {
                MessageBox.Show("no item selected");
            }
        }
        string tp;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bt_ch = true;
            tp = bunifuTextbox1.text;

            if (tp != "")
            {

                int i;
                if (int.TryParse(tp, out i) == true)
                {
                    tp = bunifuTextbox2.text;

                    if (tp != "")
                    {
                        int n;
                        if (!int.TryParse(tp, out n))
                        {
                            if (maskedTextBox1.Text != "")
                            {
                                tp = bunifuTextbox3.text;

                                if (tp != "")
                                {
                                    if (order_flag == false)
                                    {
                                        tp = bunifuTextbox4.text;

                                        if (tp != "")
                                        {
                                            int y;
                                            if (int.TryParse(tp, out y) == true)
                                            {

                                                /////update//////////

                                                rec_amount = Convert.ToInt32(tp);
                                                if (rec_amount > tprice)
                                                {
                                                    pending_amount = 0;
                                                }
                                                else
                                                {
                                                    pending_amount = tprice - rec_amount;
                                                }

                                                ////////////////////////////////
                                                //        if (check == false)
                                                //        {
                                                //            for (int a = 0; a < data_item.Length; a++)
                                                //            {
                                                //                if (data_item[a] != null)
                                                //                {
                                                //                    stock_quantity = int.Parse(data_qty[a]);
                                                //                    stock_quantity -= int.Parse(data_qty[a]);
                                                //                    product_sto_id = int.Parse(data_item[a]);

                                                //                }
                                                //            }
                                                //            add_data2();
                                                //        }
                                                //        else
                                                //        {
                                                for (int a = 0; a < data_item.Length; a++)
                                                {
                                                    if (data_item[a] != null)
                                                    {
                                                        stock_quantity = qty_CAL(data_item[a]);
                                                        stock_quantity -= int.Parse(data_qty[a]);
                                                        product_sto_id = int.Parse(data_item[a]);

                                                    }
                                                }
                                                add_data();

                                                //}
                                                bunifuTextbox4.text = "";
                                                bunifuTextbox5.text = "";
                                                //numericUpDown1.Value = 0;
                                                //numericUpDown2.Value = 0;
                                                bunifuTextbox2.Text = "";
                                                maskedTextBox1.Text = "";
                                                bunifuTextbox3.Text = "";
                                                label10.Text = "____";
                                            }
                                            else
                                            {
                                                MessageBox.Show("cash can contain numeric value");
                                                return;

                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("plz enter cash");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("plz select quantity");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("plz enter address");
                                }


                            }
                            else
                            {
                                MessageBox.Show("plz enter phone  number");
                            }
                        }
                        else
                        {
                            MessageBox.Show("name  can,t contain number ");
                            return;

                        }
                    }
                    else
                    {
                        MessageBox.Show("plz enter name");
                    }
                }
                else
                {
                    MessageBox.Show("customer id can contain number only");
                    return;

                }
            }
            else
            {
                MessageBox.Show("plz enter customer id");
            }
            //   add_quantity = null;
            // add_item = null;
            //data_item = null;
            //data_qty = null;
            label1.Text = null;
            label2.Text = null;
            che = true;
            bunifuTextbox1.text = "";
            bunifuTextbox2.text = "";
            bunifuTextbox3.text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
          
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void bunifuTextbox5_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox3_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox4_OnTextChange(object sender, EventArgs e)
        {

        }
        public string p_code, p_name, p_des, p_catg, add_item, add_quantity;

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {
        }
        string ch_id;
        int purchase_cal(string id)
        {
            ch_id = id;
            try
            {
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select purchase_price from Inventory where id='" + this.ch_id + "'";
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
                dataGridView3.DataSource = dTable;
                //   label4.Text = dataGridView3.Rows[1].Cells[1].ToString();
                return int.Parse(dataGridView3.Rows[0].Cells[0].Value.ToString());
                //dTable.Columns.Add("img", Type.GetType("System.Byte[]"));

                //foreach (DataRow drow in dTable.Rows)
                //{


                //    drow["img"] = File.ReadAllBytes("F:\\file\\" + drow["image"].ToString());
                //}

                //    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

            return int.Parse(dataGridView3.Rows[0].Cells[0].Value.ToString());
        }
        int qty_CAL(string id)
        {
            ch_id = id;
            try
            {
                dataGridView3.DataSource = null;
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select quantity from Inventory where id='" + this.ch_id + "'";
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
                dataGridView3.DataSource = dTable;
                //                label4.Text = dataGridView3.Rows[1].Cells[1].ToString();
                return int.Parse(dataGridView3.Rows[0].Cells[0].Value.ToString());
                //dTable.Columns.Add("img", Type.GetType("System.Byte[]"));

                //foreach (DataRow drow in dTable.Rows)
                //{


                //    drow["img"] = File.ReadAllBytes("F:\\file\\" + drow["image"].ToString());
                //}

                //    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

            return int.Parse(dataGridView3.Rows[0].Cells[0].Value.ToString());
        }
        int sale_pp;
        int SALE_CAL(string id)
            {
            ch_id = id;
            try
            {
                dataGridView3.DataSource = null;
                string MyConnection2 = con_function();
                //Display query  
                string Query = "select sale_price from Inventory where id='" + this.ch_id + "'";
                OracleConnection MyConn2 = new OracleConnection(MyConnection2);
                OracleDataAdapter MyAdapter = new OracleDataAdapter(Query, MyConn2);
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                // MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                //MySqlDataReader MyReaderr;
                //MyConn2.Open();
                OracleCommand m2 = new OracleCommand(Query, MyConn2);
                var tmp = m2.ExecuteReader();
                if (tmp.HasRows)
                {
                    tmp.Read();// Get first record.
                    sale_pp= int.Parse(tmp.GetString(0));
                }
                MyConn2.Close();
                //                label4.Text = dataGridView3.Rows[1].Cells[1].ToString();
                return sale_pp;
                //dTable.Columns.Add("img", Type.GetType("System.Byte[]"));

                //foreach (DataRow drow in dTable.Rows)
                //{


               //    drow["img"] = File.ReadAllBytes("F:\\file\\" + drow["image"].ToString());
                //}

            //    dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

            return int.Parse(dataGridView3.Rows[0].Cells[0].Value.ToString());
            }

        private void dataGridView3_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        int sale_sum = 0,price_sum=0;
        int tmp = 0;
        string n = "",sprice="";

        void total_sale()
        {
           // label3.Text= data_item[0].ToString();
            for (int i = 0; i < data_item.Length; i++)
            {
                if(data_item[i]!=null)
                {
                 //   label3.Text = data_item[i];
                 sprice+= SALE_CAL(data_item[i].ToString()).ToString()+",";
                    tmp = SALE_CAL(data_item[i].ToString());
                     sale_sum += tmp;
                }
            }

            //label3.Text = sprice.ToString();
        }
        void total_price()
        {
        for (int i = 0; i < data_item.Length; i++)
           {
              if (data_qty[i] != null)
              {
               price_sum += SALE_CAL(data_item[i].ToString()) * int.Parse(data_qty[i].ToString());
              }
            }
           // label3.Text = price_sum.ToString();
            //label4.Text = sale_sum.ToString();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
          //  SALE_CAL("140");
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        bool next = true;
        //  int qty_data[]

        String[] data_qty;
        String[] data_item;
       

        int x = 0;
        bool che = true,bt_ch=true;
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (bt_ch == true)
            {
                data_qty = new String[50];
                data_item = new String[50];
                bt_ch = false;
                if (next == false)
                {
                    if (che == true)
                    {

                        add_item = add_item.Remove(add_item.Length - 1, 1);
                        add_quantity = add_quantity.Remove(add_quantity.Length - 1, 1);
                        che = false;
                    }
                    x = 0;
                    for (int i = 0; i < add_quantity.Length; i++)
                    {
                        if (add_quantity[i] == ',')
                        {
                            x++;
                        }
                        else
                        {
                            data_qty[x] += add_quantity[i];
                        }

                    }
                    x = 0;
                    for (int i = 0; i < add_item.Length; i++)
                    {
                        if (add_item[i] == ',')
                        {
                            x++;
                        }
                        else
                        {
                            data_item[x] += add_item[i];
                        }

                    }
                    //  label3.Text = data_item[1] ;

                    price_sum = 0;
                    total_sale();
                    total_price();

                    order_flag = false;
                    p_code = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    p_name = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    p_des = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                    p_catg = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                    stock_quantity = stock_quantity - qty;

                    ////////////////////////
                    flag = false;

                    // tprice = uprice * qty;
                    tprice = price_sum;
                    label10.Text = price_sum.ToString();
                }
                else
                {
                    MessageBox.Show("plz select quantity");
                }
             //   add_item = null;
               // add_quantity = null;
                bt_ch = false;
            }
        }
        public int rec_amount = 0, pending_amount = 0;
        public bool order_flag = true;
        string pro_name;
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bt_ch = true;
            tp = bunifuTextbox5.text;
            if (tp != "")
            {

                int i;
                if (int.TryParse(tp, out i) == true)
                {

                    uprice = Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value.ToString());
            stock_quantity = Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
            product_sto_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());

            qty = Convert.ToInt32(bunifuTextbox5.text);
            if (qty <= stock_quantity)
            {
                        add_item += dataGridView2.CurrentRow.Cells[0].Value.ToString() + ",";
                        add_quantity += qty.ToString() + ",";
                       pro_name+= dataGridView2.CurrentRow.Cells[2].Value.ToString() + ",";
                        label1.Text = add_item;
                        label2.Text = add_quantity;
                        next = false;
            }
            else
            {
                MessageBox.Show("no enough stock is available");
            }
                }
                else
                {
                    MessageBox.Show("quantity can contain numeric value only");
                    return;
 
                }
            }
            else
            {
                MessageBox.Show("plz enter quantity");
            }
            bunifuTextbox5.text = "";
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
             


        }
    }
}
