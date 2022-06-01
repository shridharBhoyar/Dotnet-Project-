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
    public partial class SingUpForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public SingUpForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into SingUp values(@fname,@lname,@age,@gender,@mail,@pass)";
            SqlCommand cmd = new SqlCommand(quary,con);
            cmd.Parameters.AddWithValue("@fname",textBox1.Text);
            cmd.Parameters.AddWithValue("@lname", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@mail", textBox4.Text);
            cmd.Parameters.AddWithValue("@pass", textBox5.Text);

            con.Open();

            int a=cmd.ExecuteNonQuery();

            if(a>0)
            {
                MessageBox.Show("Sing In Succes");
                this.Hide();
                LogInForm fm = new LogInForm();
                fm.Show();
                
            }
            else
            {
                MessageBox.Show("Sing In faild");
            }
            con.Close();


        }
    }
}
