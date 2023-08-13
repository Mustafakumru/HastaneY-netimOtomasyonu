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
    public partial class frmHastaGiriş : Form
    {
        public frmHastaGiriş()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lnkÜye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayıt fr=new frmHastaKayıt(); 
            fr.Show();
        }
        sqlBağlantısı bgl=new sqlBağlantısı();
        private void button1_Click(object sender, EventArgs e)
        {
          SqlCommand cmd = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@p1 and HastaŞifre=@p2",bgl.bağlanti());
            cmd.Parameters.AddWithValue("@p1", MskTc.Text);
            cmd.Parameters.AddWithValue("@p2", txtŞifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr=new FrmHastaDetay();
                fr.tc=MskTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre");
            }
            bgl.bağlanti().Close();
        }

        private void frmHastaGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
