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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string Tc;
        sqlBağlantısı bgl=new sqlBağlantısı();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = Tc;
        //Doktor Ad Soyad
            SqlCommand komut = new SqlCommand("Select DokorAd,DoktorSoyad from Tbl_Doktor where DoktorTc=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text); 
            SqlDataReader dr=       komut.ExecuteReader();  
            if (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.bağlanti().Close();
            // Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+LblAdSoyad.Text+"'",bgl.bağlanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;    
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
               DoktorBilgiDüzenle fr=new DoktorBilgiDüzenle();
            fr.Tc=lblTc.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[seçilen].Cells[7].Value.ToString();
        }
    }
}
