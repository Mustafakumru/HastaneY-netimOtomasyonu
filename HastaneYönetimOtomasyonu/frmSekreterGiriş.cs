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
    public partial class frmSekreterGiriş : Form
    {
        public frmSekreterGiriş()
        {
            InitializeComponent();
        }
        sqlBağlantısı bgl=new sqlBağlantısı();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select * From Tbl_Sekreter where sekreterTC=@p1 and SekreterŞifre=@p2",bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            komut.Parameters.AddWithValue("@p2",txtŞifre.Text);
           
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read()) {
               frmSekreterdetay frs=new frmSekreterdetay();
                frs.TcNumara = MskTc.Text;
                frs.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Şifre & Tc");
            }
            bgl.bağlanti().Close();
        }
    }
}
