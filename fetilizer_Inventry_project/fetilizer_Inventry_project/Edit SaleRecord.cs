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
    public partial class Edit_SaleRecord : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Edit_SaleRecord()
        {
            InitializeComponent();
            Edit_Sale_bindgridview();
        }
        void Edit_Sale_bindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from SaleTable";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "update SaleTable set customer_name=@cname , addresse=@address,mobile_no=@mobileno,price=@price where invoice_id=@id ";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@cname", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            cmd.Parameters.AddWithValue("@mobileno", textBox4.Text);
            cmd.Parameters.AddWithValue("@price", textBox5.Text);



            con.Open();
            int a = cmd.ExecuteNonQuery();
       
            if (a > 0)
            {
                MessageBox.Show("Updated");
                Edit_Sale_bindgridview();
                cleardata();

            }
            else
            {
                MessageBox.Show(" not Updated");
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "delete  from SaleTable where invoice_id=@id ";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("Deleted");
                Edit_Sale_bindgridview();
                cleardata();
            }
            else
            {
                MessageBox.Show(" Not Deleted");
            }
            con.Close();
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
