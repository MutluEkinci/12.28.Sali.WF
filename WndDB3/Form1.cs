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

namespace WndDB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSp1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = DESKTOP-TUMHS1A\MS_SQL_2019; Initial Catalog = Calısma; Integrated Security = True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("gp_AdvUrunlerListe", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = cmd.ExecuteReader();
            string strkayit = "";
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    strkayit += dr.GetValue(i) + " ";
                }
                listBox1.Items.Add(strkayit);
                strkayit = "";
            }

            conn.Close();
        }

        private void btnSP2_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = DESKTOP-TUMHS1A\MS_SQL_2019; Initial Catalog = Calısma; Integrated Security = True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("gp_AdvUrunUpdate", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@urunıd", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@kod", txtNo.Text);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@renk", txtRenk.Text);
            cmd.Parameters.AddWithValue("@fiyat", int.Parse(txtFiyat.Text));

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void btnSP3_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = DESKTOP-TUMHS1A\MS_SQL_2019; Initial Catalog = Calısma; Integrated Security = True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("sp_AdvUrunlerBul", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@urunıd",int.Parse(txtID.Text));
            cmd.Parameters.Add("@urunadi",SqlDbType.VarChar,50);
            cmd.Parameters.Add("@fiyat",SqlDbType.Money);

            cmd.Parameters[1].Direction = ParameterDirection.Output;
            cmd.Parameters[2].Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show(cmd.Parameters[0].Value + " " + cmd.Parameters[1].Value + " " + cmd.Parameters[2].Value);
        }

        private void btnSP4_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source = DESKTOP-TUMHS1A\MS_SQL_2019; Initial Catalog = Calısma; Integrated Security = True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("gp_AdvUrunEkleID", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            
            cmd.Parameters.AddWithValue("@kod", txtNo.Text);
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@renk", txtRenk.Text);
            cmd.Parameters.AddWithValue("@fiyat", int.Parse(txtFiyat.Text));

            cmd.Parameters.Add("@YeniID",SqlDbType.Int);

            cmd.Parameters[4].Direction = ParameterDirection.ReturnValue;


            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show(cmd.Parameters[4].Value.ToString());
        }

        private void btnSP5scalar_Click(object sender, EventArgs e)
        {
            //Execute Scalar Kullanımı
            string strConn = @"Data Source = DESKTOP-TUMHS1A\MS_SQL_2019; Initial Catalog = Calısma; Integrated Security = True";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from musteri ", conn);

            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //MessageBox.Show(dr[0].ToString());


            int kayitsayisi=Convert.ToInt32( cmd.ExecuteScalar());
            conn.Close();
            MessageBox.Show(kayitsayisi.ToString());

        }
    }
}
