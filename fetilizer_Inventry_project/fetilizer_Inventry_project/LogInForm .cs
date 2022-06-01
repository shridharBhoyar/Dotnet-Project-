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
    public partial class LogInForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        
        public LogInForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SingUpForm su = new SingUpForm();
            su.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from SingUp where Email = @mail and Password = @pass";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("@mail", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);


           
            con.Open();

            SqlDataReader dr= cmd.ExecuteReader();

            if (dr.HasRows == true)
            {
                MessageBox.Show("Log In Succes");
                this.Hide();
                form1 fm = new form1();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Log In faild");
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
