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
    public partial class FrmDoktorGiriş : Form
    {
        public FrmDoktorGiriş()
        {
            InitializeComponent();
        }
        sqlBağlantısı bgl=new sqlBağlantısı();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select * from Tbl_Doktor where DoktorTc=@p1 and DoktorŞifre=@p2 ",bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtŞifre.Text);
            SqlDataReader dr= komut.ExecuteReader();    
            if (dr.Read()) { 
              FrmDoktorDetay frm=new FrmDoktorDetay();
                frm.Tc=MskTc.Text;  
                frm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veye Şifre");
            }
            bgl.bağlanti().Close();
        }
    }
}
