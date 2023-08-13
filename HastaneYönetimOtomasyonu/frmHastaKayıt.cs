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
    public partial class frmHastaKayıt : Form
    {
        public frmHastaKayıt()
        {
            InitializeComponent();
        }
        sqlBağlantısı bgl=new sqlBağlantısı();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaŞifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.bağlanti());
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", MskTc.Text);
            cmd.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p5", txtŞifre.Text);
            cmd.Parameters.AddWithValue("@p6", comboBox1.Text);
            cmd.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Kaydınız Gerçekleştirilmiştir Şifreiz: " + txtŞifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
