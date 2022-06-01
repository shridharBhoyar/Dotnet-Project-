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
    public partial class Stock : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Stock()
        {
            InitializeComponent();
            Stock_bindgridview();
        }

        void Stock_bindgridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Stock";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Stock where Product_Name like @Product_Name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            sda.SelectCommand.Parameters.AddWithValue("@Product_Name", textBox1.Text.Trim());
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from Stock where customer_name like @Product_Name + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            sda.SelectCommand.Parameters.AddWithValue("@Product_Name", textBox1.Text.Trim());
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
