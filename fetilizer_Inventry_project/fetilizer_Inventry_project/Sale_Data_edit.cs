using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace fetilizer_Inventry_project
{
    public partial class Sale_Data_edit : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Sale_Data_edit()
        {
            InitializeComponent();
            gridview();
        }

        void gridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from SaleDetails";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "update SaleDetails set invoice_no=@invoice_no,product_id=@product_id,customer_name=@customer_name , addresses=@addresses,mobile_no=@mobile_no,produt_name=@produt_name,sale_quantity=@sale_quantity,sale_price=@sale_price where sale_id=@sale_id ";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@sale_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@invoice_no", textBox2.Text);
            cmd.Parameters.AddWithValue("@product_id", textBox3.Text);
            cmd.Parameters.AddWithValue("@customer_name", textBox4.Text);
            cmd.Parameters.AddWithValue("@addresses", textBox5.Text);
            cmd.Parameters.AddWithValue("@mobile_no", textBox6.Text);
            cmd.Parameters.AddWithValue("@produt_name", textBox7.Text);
            cmd.Parameters.AddWithValue("@sale_quantity", textBox8.Text);
            cmd.Parameters.AddWithValue("@sale_price", textBox9.Text);
        


            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Updated");
                gridview();
                cleardata();

            }
            else
            {
                MessageBox.Show(" not Updated");
            }

            con.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        
        }

        void cleardata()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "delete  from SaleDetails where sale_id=@id ";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted");
                gridview();
                cleardata();
            }
            else
            {
                MessageBox.Show(" Not Deleted");
            }
            con.Close();
        }

    }
}
