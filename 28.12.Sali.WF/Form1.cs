using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._12.Sali.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            
            dt.DefaultView.RowFilter = "Renk='"+ textBox1.Text+"'";
            dataGridView1.DataSource = dt.DefaultView.ToTable();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string strConn = @"Data Source=DESKTOP-TUMHS1A\MS_SQL_2019;Initial Catalog=Calısma;Integrated Security=True";

            SqlDataAdapter da = new SqlDataAdapter("select*from advurunler", strConn);

            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "";
            dataGridView1.DataSource = dt.DefaultView.ToTable();            
        }
        int sayac = 0;
        private void btnFiyataGore_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {
                dt.DefaultView.Sort = "Fiyat desc";
                dataGridView1.DataSource = dt.DefaultView.ToTable();
            }
            else if (sayac == 2)
            {
                dt.DefaultView.Sort = "Fiyat";
                dataGridView1.DataSource = dt.DefaultView.ToTable();
                sayac = 0;
            }
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=DESKTOP-TUMHS1A\MS_SQL_2019;Initial Catalog=Calısma;Integrated Security=True";

            SqlDataAdapter da = new SqlDataAdapter("select*from advperson;select*from musteri", strConn);

            DataSet ds = new DataSet();
            

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
