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
using System.Configuration;

namespace fetilizer_Inventry_project
{
    public partial class Sale : Form
    {
        int srno=0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Sale()
        {
            InitializeComponent();
            getinvoice_id();
            getitem();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns [0].Name = "Sr No";
            dataGridView1.Columns[1].Name = "Product Id";
            dataGridView1.Columns[2].Name = "Product Name";
            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[4].Name = "Price";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            addatagridview((++srno).ToString(),textBox6.Text,comboBox1.SelectedItem.ToString(),textBox4.Text,textBox5.Text);
            
            reset();
            final_cost();
        }

       


        void getitem()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Purchase";
            SqlCommand cmd = new SqlCommand(quary, con);
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string itm_nam = dr.GetString(1);
                comboBox1.Items.Add(itm_nam);
            }

            con.Close();
        }


        void getPrice()
        {
            if (comboBox1.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                string quary = "select Product_Price from Purchase where Product_Name=@pdnam";
                SqlDataAdapter sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.Parameters.AddWithValue("@pdnam", comboBox1.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    price = Convert.ToInt32(data.Rows[0]["Product_Price"]);
                    textBox5.Text = price.ToString();
                }


            }
        }


        void getId()
        {
            if (comboBox1.SelectedItem == null)
            {

            }
            else
            {


                int id = 0;
                SqlConnection con = new SqlConnection(cs);
                string quary = "select id from Stock where Product_Name=@pdnam";
                SqlDataAdapter sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.Parameters.AddWithValue("@pdnam", comboBox1.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    id = Convert.ToInt32(data.Rows[0]["id"]);
                    textBox6.Text = id.ToString();
                }

            }

        }


        void getquantity()
        {
            if (comboBox1.SelectedItem == null)
            {

            }
            else
            {
                int price = 0;
                SqlConnection con = new SqlConnection(cs);
                string quary = "select Product_Quantity from Purchase where Product_Name=@pdnam";
                SqlDataAdapter sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.Parameters.AddWithValue("@pdnam", comboBox1.SelectedItem.ToString());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    price = Convert.ToInt32(data.Rows[0]["Product_Quantity"]);
                    textBox5.Text = price.ToString();
                }


            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPrice();
            getId();
            getquantity();

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox4.Text)==true)
            {

            }
            else
            {
                int price = Convert.ToInt32(textBox5.Text);
                int dis = Convert.ToInt32(textBox4.Text);
                int totalPrice = price * dis;
                textBox5.Text = totalPrice.ToString();
            }
            
        }

        //show print page
        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }


        //printing bill page
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.images;
            Image img = bmp;
            e.Graphics.DrawImage(img, 50, 5,800,250);
            e.Graphics.DrawString("Invoice Id"+textBox6.Text,new Font("Arial",14,FontStyle.Bold),Brushes.Black,new Point(30,300));
            e.Graphics.DrawString("Customer name " + textBox1.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 330));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 360));
            e.Graphics.DrawString("Time: " +DateTime.Now.ToLongDateString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 390));
            e.Graphics.DrawString("================================================================== " , new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 410));
            e.Graphics.DrawString("Product Name",new Font("Arial",14,FontStyle.Bold),Brushes.Black,new Point(50,440));
            e.Graphics.DrawString("quantity ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(280, 440));
            e.Graphics.DrawString("Price", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(480, 440));
            e.Graphics.DrawString("================================================================== ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 470));


            //product name
            int gap = 510;
            if(dataGridView1.Rows.Count>0)
            {
                for(int i=0;i<dataGridView1.Rows.Count;i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(50, gap));
                        gap = gap + 30;

                    }
                    catch
                    {

                    }

                }
            }

            //quantity
            int gap2 = 510;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(280, gap2));
                        gap2 = gap2 + 30;

                    }
                    catch
                    {

                    }

                }
            }


            //price
            int gap3 = 510;
            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    try
                    {
                        e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(480, gap3));
                        gap3 = gap3 + 30;

                    }
                    catch
                    {

                    }

                }
            }


            e.Graphics.DrawString("================================================================== ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(30, 910));
          
            int total = 0;
            for(int i=0;i < dataGridView1.Rows.Count;i++)
            {
                total = total + Convert.ToInt32( dataGridView1.Rows[i].Cells[3].Value);
            }

            e.Graphics.DrawString("Total :-   "+total.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(400, 940));
         
        
            e.Graphics.DrawString("Signature ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(600, 1050));

        }



        //Insert Button
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            //int @id = 0;
            string quary = "insert into SaleTable values(@invoice_id,@cname,@address,@mobileno,@totalprice)";
            string quary2 = "insert into Customer values(@cname,@address,@mobileno)";
           // string quary3 = "update Stock set Quantity=(Quantity-@quantity) where id like '" + textBox6.Text + "'";
            SqlCommand cmd = new SqlCommand(quary, con);
            SqlCommand cmd2 = new SqlCommand(quary2, con);
           // SqlCommand cmd3 = new SqlCommand(quary3, con);
            cmd.Parameters.AddWithValue("@invoice_id",textBox8.Text );
            cmd.Parameters.AddWithValue("@cname", textBox1.Text);
            cmd.Parameters.AddWithValue("@address", textBox2.Text);
            cmd.Parameters.AddWithValue("@mobileno", textBox3.Text);
            cmd.Parameters.AddWithValue("@totalprice", textBox7.Text);

            cmd2.Parameters.AddWithValue("@cname", textBox1.Text);
            cmd2.Parameters.AddWithValue("@address", textBox2.Text);
            cmd2.Parameters.AddWithValue("@mobileno", textBox3.Text);

           // cmd3.Parameters.AddWithValue("@quantity", textBox4.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
         //   cmd3.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("insrted");
                getinvoice_id();
                reset();
            }
            else
            {
                MessageBox.Show(" not insrted");
            }

            con.Close();

            insert_sale_details();

        }



        void addatagridview(String sr_no,string product_Id,string product_name,string quantity,string price)
        {
            string[] row = { sr_no, product_Id, product_name, quantity, price };
            dataGridView1.Rows.Add(row);
            
        }

       void reset()
        {
            textBox4.Clear();
            comboBox1.SelectedItem = null;
            textBox5.Clear();
           
        }

        void final_cost()
        {
            int fc = 0;
            for(int i=0;i < dataGridView1.Rows.Count;i++)
            {
                fc = fc + Convert.ToInt32( dataGridView1.Rows[i].Cells[4].Value);
            }
            textBox7.Text = fc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox7.Clear();
            srno = 0;
        }

       void getinvoice_id()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select invoice_id from SaleTable";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
           if(data.Rows.Count<1)
           {
               textBox8.Text = "1";
           }
           else
           {
               string quary2 = "select max(invoice_id) from SaleTable";
               SqlCommand cmd2 = new SqlCommand(quary2,con);
               
               con.Open();
               int a = Convert.ToInt32(cmd2.ExecuteScalar());
               a = a + 1;
               textBox8.Text = a.ToString();

               con.Close();

           }
        }


       int getlastInvoiceNo()
       {
           SqlConnection con = new SqlConnection(cs);
           string quary = "select max(invoice_id) from SaleTable";
           SqlCommand cmd = new SqlCommand(quary, con);
           con.Open();

           int maxidno = Convert.ToInt32(cmd.ExecuteScalar());
           con.Close();
           return maxidno;
       }

        

        void insert_sale_details()
       {
           int a = 0;
           SqlConnection con = new SqlConnection(cs);

           try { 

               for (int i = 0; i < dataGridView1.Rows.Count; i++)
               {
                   string quary2 = "update Stock set Quantity=(Quantity-@quantity) where id like '" + dataGridView1.Rows[i].Cells[1].Value + "'";
                   string quary = "insert into SaleDetails values(@invoce_no,@product_id,@customer_name,@customer_Address,@mobile_no,@product_name,@quantity,@price )";
                   SqlCommand cmd2 = new SqlCommand(quary2, con);
                   SqlCommand cmd = new SqlCommand(quary, con);

                   cmd.Parameters.AddWithValue("@invoce_no", getlastInvoiceNo());
                   cmd.Parameters.AddWithValue("@product_id",dataGridView1.Rows[i].Cells[1].Value.ToString() );
                   cmd.Parameters.AddWithValue("@customer_name", textBox1.Text);
                   cmd.Parameters.AddWithValue("@customer_Address", textBox2.Text);
                   cmd.Parameters.AddWithValue("@mobile_no", textBox3.Text);
                   cmd.Parameters.AddWithValue("@product_name", dataGridView1.Rows[i].Cells[2].Value.ToString());
                   cmd.Parameters.AddWithValue("@quantity", dataGridView1.Rows[i].Cells[3].Value.ToString());
                   cmd.Parameters.AddWithValue("@price", dataGridView1.Rows[i].Cells[4].Value.ToString());

                  //cmd3.Parameters.AddWithValue("@product_id", dataGridView1.Rows[i].Cells[1].Value.ToString());
                   cmd2.Parameters.AddWithValue("@quantity",dataGridView1.Rows[i].Cells[3].Value.ToString());
                   con.Open();


                   a = a + cmd.ExecuteNonQuery();
                   cmd2.ExecuteNonQuery();

                   con.Close();
               }

           }
            catch
           {

           }

               if(a>0)
               {
                   MessageBox.Show("data added in details Table");
               }
               else
               {
                   MessageBox.Show("data not added in detais Table");
               }
           
          
         
       }

    

        

    }
}
