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
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace IMS
{
    public partial class jf1 : Form
    {
        public jf1()
        {
            InitializeComponent();

        }
        public string loc;
        public string pic_name = "pic1";
        public string fn;
        public string f = "F:\\file";
        public int pic_count = 0;
        public static string con_function()
        {
            return "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = orcl))); User Id = system; Password = Oracle@123;";
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

                //   MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                // MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
//                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
  //              MyAdapter.SelectCommand = MyCommand2;
    //            DataTable dTable = new DataTable();
      //          MyAdapter.Fill(dTable);

        //        dTable.Columns.Add("img", Type.GetType("System.Byte[]"));

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

        private void GetLastRow()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int nRowIndex = dataGridView1.Rows.Count - 2; //last row index
                object newID = dataGridView1.Rows[nRowIndex].Cells[0].Value;
                int ID = Convert.ToInt32(newID);
                ID++;
                pic_count = ID;
            }
            else
            {
                dataGridView1.Text = "1";
                dataGridView1.ReadOnly = true;
            }

        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int id = 1;
        bool check_img = true;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void jf1_Load(object sender, EventArgs e)
        {
            dataGridView1.TabStop = true;
         ///   TabStop = true;
            Control ctl;
            ctl = (Control)sender;
            ctl.SelectNextControl(ActiveControl, true, true, true, true);
            label5.Hide();
            numericUpDown1.Hide();
            bunifuThinButton24.Hide();
            numericUpDown1.Maximum = 9999999;
            numericUpDown1.Minimum = 0;
            get_data();
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
            //    {
            //        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            //        break;
            //    }
  //          dataGridView1.Columns[9].Visible = false;
    //        dataGridView1.Columns[10].Visible = false;
        //    dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_pg1 ob = new admin_pg1();
            ob.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuTextbox2.text != "" && bunifuTextbox3.text != "" && bunifuTextbox4.text != "" && bunifuTextbox5.text != "" && bunifuTextbox6.text != "" && bunifuTextbox7.text != "")
            {
                string ne = bunifuTextbox2.text;
                
               int i;
                if (int.TryParse(ne, out i) == true)
                {
                    ne = bunifuTextbox3.text.ToString();
            //        label2.Text = ne;
                    if ( ne!= "")
                    {
                        int n;
                        if (!int.TryParse(ne, out n) == true)
                        {

                            int p;
                            ne = bunifuTextbox6.text;
                            if (int.TryParse(ne, out p) == true)
                            {
                                int k;
                                ne = bunifuTextbox7.text;
                                if (int.TryParse(ne, out k) == true)
                                {
                                      //connection closed
                                  //  if (check_img == false)
                                    //{

                                        string connetionString = con_function();
//                                        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
                                        //connection open
  //                                      conn.Open();
                                        try
                                        {
                                        
                                            //string sql = "insert into inventory(product_code,name,quantity,sale_price,purchase_price,description,category,date,image,status) values('"+ this.bunifuTextbox2.Text +"','" +this.bunifuTextbox3.Text+ "','" + this.numericUpDown1.Value + "',''" + this.bunifuTextbox6.text + "'',''" + this.bunifuTextbox7.text + "'','" + this.bunifuTextbox4.text + "','" + this.bunifuTextbox5.text + "',' "+this.bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + fn + "','false')";
                                            string sql = "insert into inventory(product_code,name,quantity,sale_price,purchase_price,description,category,pdate) values('" + Int32.Parse(this.bunifuTextbox2.text.ToString()) + "','" + this.bunifuTextbox3.text.ToString() + "','" + this.numericUpDown1.Value + "','" + this.bunifuTextbox6.text + "','" + this.bunifuTextbox7.text + "','" + this.bunifuTextbox4.text + "','" + this.bunifuTextbox5.text + "','" + this.bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "')";
                                            OracleConnection MyConn2 = new OracleConnection(connetionString);
                                            OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                                            DataTable dTable = new DataTable();
                                            MyAdapter.Fill(dTable);

                                            //                                            MySqlCommand cmd = new MySqlCommand(sql, conn);
                                            //                                          cmd.ExecuteNonQuery();
                                            MessageBox.Show("Data Entered Successfully");
    //                                        conn.Close();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Database Connection Error!");
                                        }

                                        //MemoryStream mmst = new MemoryStream();
                                        //pictureBox1.Image.Save(mmst, pictureBox1.Image.RawFormat);
                                        //byte[] img = mmst.ToArray();
                                        ////dataGridView1.Rows.Add(id, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, img);
                                        get_data();
                                        // dataGridView1.Rows.Add(img);
                                      //  check_img = true;

//                                    }
//                                    else
//                                    {
//                                        // dataGridView1.Rows.Add(id, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
//                                        // pic_count++;
////                                        fn = "nim" + ".jpg";
//  //                                      loc = System.IO.Path.Combine(f, fn);


//                                        string connetionString = con_function();
////                                        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
//                                        //connection open
//  //                                      conn.Open();
//                                        try
//                                        {
//                                            //   string sql = "insert into inventory(product_code,name,quantity,sale_price,purchase_price,description,category,date,image,status) values('" + this.bunifuMaterialTextbox1.Text + "','" + this.bunifuMaterialTextbox2.Text + "','" + this.numericUpDown1.Value + "','" + this.numericUpDown2.Value + "','" + this.numericUpDown3.Value + "','" + this.bunifuMaterialTextbox5.Text + "','" + this.bunifuMaterialTextbox6.Text + "','" + this.dateTimePicker1.Text + "','" + fn + "','false')";
//                                                string sql = "insert into inventory(product_code,name,quantity,sale_price,purchase_price,description,category,date,image,status) values('" + Int32.Parse(this.bunifuTextbox2.text.ToString()) + "','"+this.bunifuTextbox3.text.ToString() + "','" + this.numericUpDown1.Value + "','" +this.bunifuTextbox6.text + "','" +this.bunifuTextbox7.text + "','" + this.bunifuTextbox4.text + "','" + this.bunifuTextbox5.text + "','" + this.bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + fn + "','false')";
//                                            OracleConnection MyConn2 = new OracleConnection(connetionString);
//                                            OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
//                                            DataTable dTable = new DataTable();
//                                            MyAdapter.Fill(dTable);

//                                            //                                        MySqlCommand cmd = new MySqlCommand(sql, conn);
//                                            //                                          cmd.ExecuteNonQuery();
//                                            MessageBox.Show("Data Entered Successfully");
////                                            conn.Close();
                                       
//                                        }
//                                        catch
//                                        {
//                                            MessageBox.Show("Database Connection Error!");
//                                        }

//                                        get_data();

//                                    }
                                    bunifuTextbox2.text = "";
                                    bunifuTextbox3.text = "";
                                    bunifuTextbox4.text = "";
                                    bunifuTextbox5.text = "";
                                    bunifuTextbox6.text = "";
                                    bunifuTextbox7.text = "";
                                    id++;
                                }
                                else
                                {
                                    MessageBox.Show("purchase price can contain numeric value ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("sale price can contain numeric value ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("name  can,t contain number ");
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("plz enter name ");
                    }
                }
                else
                {
                    MessageBox.Show("product code can contain number only");
                    return;
                }
            }
            else
            {
                MessageBox.Show("plz fill all empty fields ");
            }
        }
        int cr = 0;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           
            cr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string connetionString = con_function();
  //          MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
            //connection open
  //          conn.Open();
            try
            {
                string sql = "delete from inventory where id=" + this.cr + "";
                OracleConnection MyConn2 = new OracleConnection(connetionString);
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
            get_data();
        }
        ///////////////////////////
        
        /////////////////////////
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            cr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (bunifuTextbox2.text != "" && bunifuTextbox3.text != "" && bunifuTextbox4.text != "" && bunifuTextbox5.text != "" && bunifuTextbox6.text != "" && bunifuTextbox7.text != "")
            {
                string ne = bunifuTextbox2.text;

                int i;
                if (int.TryParse(ne, out i) == true)
                {
                    ne = bunifuTextbox3.text.ToString();
                    //        label2.Text = ne;
                    if (ne != "")
                    {
                        int n;
                        if (!int.TryParse(ne, out n) == true)
                        {

                            int p;
                            ne = bunifuTextbox6.text;
                            if (int.TryParse(ne, out p) == true)
                            {
                                int k;
                                ne = bunifuTextbox7.text;
                                if (int.TryParse(ne, out k) == true)
                                {
                                    //connection closed
                                    //if (check_img == false)
                                    //{

                                        string connetionString = con_function();

//                                        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
                                        //connection open
  //                                      conn.Open();
                                        try
                                        {

                                            //string sql = "insert into inventory(product_code,name,quantity,sale_price,purchase_price,description,category,date,image,status) values('"+ this.bunifuTextbox2.Text +"','" +this.bunifuTextbox3.Text+ "','" + this.numericUpDown1.Value + "',''" + this.bunifuTextbox6.text + "'',''" + this.bunifuTextbox7.text + "'','" + this.bunifuTextbox4.text + "','" + this.bunifuTextbox5.text + "',' "+this.bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + fn + "','false')";
                                            string sql = "update inventory set product_code = '" + Int32.Parse(this.bunifuTextbox2.text.ToString()) + "', name= '" + this.bunifuTextbox3.text.ToString() + "', sale_price= '" + this.bunifuTextbox6.text + "', purchase_price= '" + this.bunifuTextbox7.text + "', description= '" + this.bunifuTextbox4.text + "', category= '" + this.bunifuTextbox5.text + "', pdate= '" + this.bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "' where id=" + this.cr + "";
                                            OracleConnection MyConn2 = new OracleConnection(connetionString);
                                            OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
                                            DataTable dTable = new DataTable();
                                            MyAdapter.Fill(dTable);
                                            //quantity,sale_price,purchase_price,description,category,date,image,status)                                           
                                            //string sql = "insert into inventory(product_code,name,quantity,sale_price,purchase_price,description,category,date,image,status) values('" + Int32.Parse(this.bunifuTextbox2.text.ToString()) + "','" + this.bunifuTextbox3.text.ToString() + "','" + this.numericUpDown1.Value + "','" + this.bunifuTextbox6.text + "','" + this.bunifuTextbox7.text + "','" + this.bunifuTextbox4.text + "','" + this.bunifuTextbox5.text + "','" + this.bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + fn + "','false')";

                                            //   MySqlCommand cmd = new MySqlCommand(sql, conn);
                                            // cmd.ExecuteNonQuery();
                                            MessageBox.Show("Data Entered Successfully");
                                           // conn.Close();
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Database Connection Error!");
                                        }

                                        //MemoryStream mmst = new MemoryStream();
                                        //pictureBox1.Image.Save(mmst, pictureBox1.Image.RawFormat);
                                        //byte[] img = mmst.ToArray();
                                        //dataGridView1.Rows.Add(id, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, img);
                                        get_data();
                                        // dataGridView1.Rows.Add(img);
                                        check_img = true;

//                                    }
//                                    else
//                                    {
//                                        // dataGridView1.Rows.Add(id, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
//                                        // pic_count++;
//                                        //fn = "nim" + ".jpg";
//                                        //loc = System.IO.Path.Combine(f, fn);


//                                        string connetionString = con_function();
////                                        MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection(connetionString);
//                                        //connection open
//  //                                      conn.Open();
//                                        try
//                                        {
//                                            //   string sql = "insert into inventory(product_code,name,quantity,sale_price,purchase_price,description,category,date,image,status) values('" + this.bunifuMaterialTextbox1.Text + "','" + this.bunifuMaterialTextbox2.Text + "','" + this.numericUpDown1.Value + "','" + this.numericUpDown2.Value + "','" + this.numericUpDown3.Value + "','" + this.bunifuMaterialTextbox5.Text + "','" + this.bunifuMaterialTextbox6.Text + "','" + this.dateTimePicker1.Text + "','" + fn + "','false')";
//                                            //                                    string sql = "insert into inventory(product_code,name,quantity,sale_price,purchase_price,description,category,date,image,status) values('" + Int32.Parse(this.bunifuTextbox2.text.ToString()) + "','" + this.bunifuTextbox3.text.ToString() + "','" + this.numericUpDown1.Value + "','" + this.bunifuTextbox6.text + "','" + this.bunifuTextbox7.text + "','" + this.bunifuTextbox4.text + "','" + this.bunifuTextbox5.text + "','" + this.bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + fn + "','false')";
//                                            string sql = "update inventory set product_code = '" + Int32.Parse(this.bunifuTextbox2.text.ToString()) + "', name= '" + this.bunifuTextbox3.text.ToString() + "', quantity= '" + this.numericUpDown1.Value + "', sale_price= '" + this.bunifuTextbox6.text + "', purchase_price= '" + this.bunifuTextbox7.text + "', description= '" + this.bunifuTextbox4.text + "', category= '" + this.bunifuTextbox5.text + "', date= '" + this.bunifuDatepicker1.Value.Date.ToString("yyyy-MM-dd") + "' where id=" + this.cr + "";
//                                            OracleConnection MyConn2 = new OracleConnection(connetionString);
//                                            OracleDataAdapter MyAdapter = new OracleDataAdapter(sql, MyConn2);
//                                            DataTable dTable = new DataTable();
//                                            MyAdapter.Fill(dTable);

//                                            //                                            MySqlCommand cmd = new MySqlCommand(sql, conn);
//                                            //                                          cmd.ExecuteNonQuery();
//                                            MessageBox.Show("Data Entered Successfully");
//    //                                        conn.Close();

//                                        }
//                                        catch
//                                        {
//                                            MessageBox.Show("Database Connection Error!");
//                                        }

//                                        get_data();

//                                    }
                                    bunifuTextbox2.text = "";
                                    bunifuTextbox3.text = "";
                                    bunifuTextbox4.text = "";
                                    bunifuTextbox5.text = "";
                                    bunifuTextbox6.text = "";
                                    bunifuTextbox7.text = "";
                                    id++;
                                }
                                else
                                {
                                    MessageBox.Show("purchase price can contain numeric value ");
                                }
                            }
                            else
                            {
                                MessageBox.Show("sale price can contain numeric value ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("name  can,t contain number ");

                        }
                    }
                    else
                    {
                        MessageBox.Show("plz enter name ");
                    }
                }
                else
                {
                    MessageBox.Show("product code can contain number only");
                    return;
                }
            }
            else
            {
                MessageBox.Show("plz fill all empty fields ");
            }
        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ////////////////////////////img////////////////////////////
            // open file dialog   
         //   OpenFileDialog open = new OpenFileDialog();
            // image filters  
           // open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
           // if (open.ShowDialog() == DialogResult.OK)
            //{
            //    // display image in picture box  
            //  //  pictureBox1.Image = new Bitmap(open.FileName);
            //    // image file path  
            //    //    loc = open.FileName;
            //    Image a = pictureBox1.Image;
            //    //    pic_count++;
            //    GetLastRow();
            //    pic_name = pic_name.Remove(pic_name.Length - 1, 1);
            //    pic_name += pic_count;
            //    fn = pic_name + ".jpg";
            //    loc = System.IO.Path.Combine(f, fn);
            //    a.Save(loc);
            //}
            ////dataGridView1.Rows.Add(img);
            //check_img = false;
            ////////////////////imgend/////////////////////////////

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            search_data();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            get_data();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox6_KeyPress(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            bunifuDatepicker1.FormatCustom= "yyyy,MM,dd";
            label2.Text = bunifuDatepicker1.Value.ToString();
        }

        private void bunifuTextbox7_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox6_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox3_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox4_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox5_OnTextChange(object sender, EventArgs e)
        {

        }
       
        private void bunifuTextbox2_KeyPress(object sender,EventArgs e)
        {
        }
        public string csd;
        private bool ValidateName2()
        {
            csd= bunifuTextbox2.text;
            bool bStatus = true;
            int ne;
            if (!int.TryParse(csd, out ne) == true)
            {

                errorProvider2.SetError(bunifuTextbox2, "Code must be numeric");
                bStatus = false;
            }
            else
                errorProvider2.SetError(bunifuTextbox2, "");
            return bStatus;
        }
        private bool ValidateName6()
        {
            csd = bunifuTextbox6.text;
            bool bStatus = true;
            int ne;
            if (!int.TryParse(csd, out ne) == true)
            {

                errorProvider2.SetError(bunifuTextbox6, "Sale Price must be numeric");
                bStatus = false;
            }
            else
                errorProvider2.SetError(bunifuTextbox6, "");
            return bStatus;
        }
        private bool ValidateName7()
        {
            csd = bunifuTextbox7.text;
            bool bStatus = true;
            int ne;
            if (!int.TryParse(csd, out ne) == true)
            {

                errorProvider2.SetError(bunifuTextbox7, "Purchase Price must be numeric");
                bStatus = false;
            }
            else
                errorProvider2.SetError(bunifuTextbox7, "");
            return bStatus;
        }
        private bool ValidateName3()
        {
            csd = bunifuTextbox3.text;
            bool bStatus = true;
            int ne;
            if (int.TryParse(csd, out ne) == true)
            {

                errorProvider2.SetError(bunifuTextbox3, "Name must be alphabetic");
                bStatus = false;
            }
            else
                errorProvider2.SetError(bunifuTextbox3, "");
            return bStatus;
        }
        private void bunifuTextbox2_Validating(object sender, CancelEventArgs e)
        {
            ValidateName2();
        }
        
        private void bunifuTextbox3_Validating(object sender, CancelEventArgs e)
        {
            ValidateName3();
        }

        private void bunifuTextbox6_Validating_1(object sender, CancelEventArgs e)
        {
            ValidateName6();
        }

        private void bunifuTextbox7_Validating_1(object sender, CancelEventArgs e)
        {
            ValidateName7();
        }

        private void bunifuTextbox2_KeyDown(object sender, EventArgs e)
        {
            
            //if (e.KeyCode.Equals(Keys.Enter))
            //{
            //    SendKeys.Send("{TAB}");
            //    e.SuppressKeyPress = true;
            //}
        }

        private void bunifuTextbox2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void bunifuTextbox2_KeyUp(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuTextbox3.Select();
        }

        private void bunifuTextox2_KeyPress(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox3_Enter(object sender, EventArgs e)
        {
            bunifuTextbox2.Select();
        }
        protected override bool ProcessKeyPreview(ref System.Windows.Forms.Message m)
        {
            int _ENTER = 13;

            if (m.Msg == _ENTER)
            {
                //Do nothing
            }
            return base.ProcessKeyPreview(ref m);
        }
        private void jf1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
        }
    }
}
