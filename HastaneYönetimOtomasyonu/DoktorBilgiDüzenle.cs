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
namespace HastaneYönetimOtomasyonu
{
    public partial class DoktorBilgiDüzenle : Form
    {
        public DoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlBağlantısı  bgl=new sqlBağlantısı();
        public string Tc;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_Doktor set DokorAd=@p1,DoktorSoyad=@p2,DoktorBranş=@p3,DoktorŞifre=@p4 where DoktorTc=@p5", bgl.bağlanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBranş.Text);
            cmd.Parameters.AddWithValue("@p4", txtŞifre.Text);
            cmd.Parameters.AddWithValue("@p5", MskTc.Text);
            cmd.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Kayıt Güncellendi");

        }

        private void DoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = Tc;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktor Where DoktorTc=@p1", bgl.bağlanti());
            SqlDataReader
                dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                cmbBranş.Text = dr[3].ToString();
                txtŞifre.Text = dr[5].ToString();
            }
            bgl.bağlanti().Close();
        }
    }
}
