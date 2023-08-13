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
    public partial class frmBilgiDüzenle : Form
    {
        public frmBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlBağlantısı bgl=new sqlBağlantısı();
        public string TCno;

        private void frmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = TCno;
            SqlCommand komut=new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@p1",bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();  
                TxtSoyad.Text = dr[2].ToString();   
                maskedTextBox1.Text = dr[3].ToString(); 
                txtŞifre.Text= dr[4].ToString();
                comboBox1.Text = dr[5].ToString();
                
            }
            bgl.bağlanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaŞifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6 ", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);    
            komut.Parameters.AddWithValue("@p2",TxtSoyad.Text); 
            komut.Parameters.AddWithValue("@p3",maskedTextBox1.Text); 
            komut.Parameters.AddWithValue("@p4",txtŞifre.Text); 
            komut.Parameters.AddWithValue("@p5",comboBox1.Text); 
            komut.Parameters.AddWithValue("@p6",MskTc.Text);
            komut.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
    }
}
