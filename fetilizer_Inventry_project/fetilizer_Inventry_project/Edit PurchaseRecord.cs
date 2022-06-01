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
    public partial class Edit_PurchaseRecord : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Edit_PurchaseRecord()
        {
            InitializeComponent();
            Edit_bindgridview();
        }

        void Edit_bindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Purchase";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill;
        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "update Purchase set Product_Name=@pname , Product_Quantity=@quantity,Product_Price=@price,Product_SellingPrice=@selling_price where Product_id=@id ";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@pname", textBox2.Text);
            cmd.Parameters.AddWithValue("@quantity", textBox3.Text);
            cmd.Parameters.AddWithValue("@price", textBox4.Text);
            cmd.Parameters.AddWithValue("@selling_price", textBox5.Text);
          
            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Updated");
                Edit_bindgridview();
                cleardata();

            }
            else
            {
                MessageBox.Show(" not Updated ");
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "delete  from Purchase where Product_id=@id ";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted");
                Edit_bindgridview();
                cleardata();
            }
            else
            {
                MessageBox.Show(" Not Deleted");
            }
            con.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
       
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           
        
        }



        void cleardata()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            

        }
    }
}
