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
    public partial class Edit_StockRecord : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Edit_StockRecord()
        {
            InitializeComponent();
            Edit_StockRecord_bindgridview();
        }

        void Edit_StockRecord_bindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Stock";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "delete  from Stock where id=@id ";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted");
                
                Edit_StockRecord_bindgridview();
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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "update Stock set Product_Name=@pname , Quantity=@quantity,Price=@price where id=@id ";
            SqlCommand cmd = new SqlCommand(quary, con);

            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@pname", textBox2.Text);
            cmd.Parameters.AddWithValue("@quantity", textBox3.Text);
            cmd.Parameters.AddWithValue("@price", textBox4.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Updated");
                Edit_StockRecord_bindgridview();
                cleardata();

            }
            else
            {
                MessageBox.Show(" not Updated");
            }

            con.Close();
        }


        void cleardata()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
