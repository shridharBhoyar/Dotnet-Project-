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
    public partial class form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        Purchase p = new Purchase();
        Sale s = new Sale();
        SaleList sl = new SaleList();
        Customer c = new Customer();
        Stock st = new Stock();
        PurchaseList pl = new PurchaseList();
        Edit_PurchaseRecord pr = new Edit_PurchaseRecord();
        Edit_SaleRecord sr = new Edit_SaleRecord();
        Edit_StockRecord str = new Edit_StockRecord();
        Edit_CustomerRecord cr = new Edit_CustomerRecord();
        SaleDetailsRecord sd = new SaleDetailsRecord();
        Purchase_Record prd = new Purchase_Record();
        Sale_Data_edit se = new Sale_Data_edit();
        UserList us = new UserList();

        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (p.IsDisposed == true)
            {
                p = new Purchase();
            }
            p.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (s.IsDisposed == true)
            {
                s = new Sale();
            }
            s.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (c.IsDisposed == true)
            {
                c = new Customer();
            }
            c.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (sl.IsDisposed == true)
            {
                sl = new SaleList();
            }
            sl.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            if (st.IsDisposed == true)
            {
                st = new Stock();
            }
            st.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pl.IsDisposed == true)
            {
                pl = new PurchaseList();
            }
            pl.Show();
        }

        private void purchaseRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sr.IsDisposed == true)
            {
                sr = new Edit_SaleRecord();
            }
            sr.Show();
        }

        private void saleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pr.IsDisposed == true)
            {
                pr = new Edit_PurchaseRecord();
            }
            pr.Show();
        }

        private void stockRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (str.IsDisposed == true)
            {
                str = new Edit_StockRecord();
            }
            str.Show();
        }

        private void cCustomerRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cr.IsDisposed == true)
            {
                cr = new Edit_CustomerRecord();
            }
            cr.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saleRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sd.IsDisposed == true)
            {
                sd = new SaleDetailsRecord();
            }
            sd.Show();
        }

        private void purchaseRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (prd.IsDisposed == true)
            {
                prd = new Purchase_Record();
            }
            prd.Show();
        }

        private void saleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (se.IsDisposed == true)
            {
                se = new Sale_Data_edit();
            }
            se.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (se.IsDisposed == true)
            {
                se = new Sale_Data_edit();
            }
            se.Show();
        }

        private void userListDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (us.IsDisposed == true)
            {
                us = new UserList();
            }
            us.Show();
        }
    }
}
