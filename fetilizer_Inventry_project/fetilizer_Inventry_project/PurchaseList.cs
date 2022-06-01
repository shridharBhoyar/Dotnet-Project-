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
    public partial class PurchaseList : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public PurchaseList()
        {
            InitializeComponent();
            bindgridview();
        }

        void bindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Purchase";
            SqlDataAdapter sda = new SqlDataAdapter(quary,con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource=data;
        }

        //search button
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Purchase where product_name like @product_name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            sda.SelectCommand.Parameters.AddWithValue("@product_name",textBox1.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            if(data.Rows.Count>0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Rows Found");
                dataGridView1.DataSource = null;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Purchase where product_name like @product_name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            sda.SelectCommand.Parameters.AddWithValue("@product_name", textBox1.Text.Trim());
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Rows Found");
                dataGridView1.DataSource = null;
            }
           
        }
    }
}
