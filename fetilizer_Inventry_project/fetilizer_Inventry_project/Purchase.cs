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
    public partial class Purchase : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Purchase()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into Purchase values(@pname,@quantity,@price,@sellingprice)";
            string quary2 = "insert into Stock values(@pname,@quantity,@sellingprice)";
            SqlCommand cmd = new SqlCommand(quary, con);
            SqlCommand cmd2 = new SqlCommand(quary2, con);
            cmd.Parameters.AddWithValue("@pname",textBox1.Text);
            cmd.Parameters.AddWithValue("@quantity", textBox2.Text);
            cmd.Parameters.AddWithValue("@price", textBox3.Text);
            cmd.Parameters.AddWithValue("@sellingprice", textBox4.Text);

            cmd2.Parameters.AddWithValue("@pname", textBox1.Text);
            cmd2.Parameters.AddWithValue("@quantity", textBox2.Text);
          
            cmd2.Parameters.AddWithValue("@sellingprice", textBox4.Text);

            con.Open();
            int a=cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("insrted");
            }
            else
            {
                MessageBox.Show(" not insrted");
            }

            con.Close();

        }



        //void bindgridview()
        //{
        //    SqlConnection con = new SqlConnection(cs);
        //    string quary = "select * from Purchase";
        //    SqlDataAdapter sda = new SqlDataAdapter(quary,con);
        //    DataTable data = new DataTable();
        //    sda.Fill(data);
        //    DataGridView1
        //}
    }
}
