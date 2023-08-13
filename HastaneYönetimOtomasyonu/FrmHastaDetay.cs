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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlBağlantısı bgl = new sqlBağlantısı();
        private void label6_Click(object sender, EventArgs e){ }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
           DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBranş='" + cmbbranş.Text + "'" + " and RandevuDoktor='"+cmbdoktor.Text+"' and RandevuDurum=0", bgl.bağlanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
       
        //Ad Soyad Çekme
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
           lblTc.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar Where HastaTc=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);    
            SqlDataReader dataReader = komut.ExecuteReader();
            while(dataReader.Read())
            {
                LblAdSoyad.Text = dataReader[0] +" "+ dataReader[1];
            }
            bgl.bağlanti().Close(); 
            //Randevu Geçmiş
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc= "+tc,bgl.bağlanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            // Branşları Çekme 
            SqlCommand komut2 = new SqlCommand("Select BranşAd From Tbl_Branş",bgl.bağlanti());
            SqlDataReader dr2 = komut2.ExecuteReader(); 
            while (dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.bağlanti().Close();
        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();    
            SqlCommand komut = new SqlCommand("Select DokorAd,DoktorSoyad From Tbl_Doktor where DoktorBranş=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1",cmbbranş.Text);
            SqlDataReader dr3= komut.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.bağlanti().Close();
        }

        private void lnkbilgidüzen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgiDüzenle fr =new frmBilgiDüzenle();
            fr.TCno = lblTc.Text;
            fr.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular set RandevuDurum=1,HastaTc=@p1,HastaŞikayet=@p2 where Randevuid=@p3", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1",lblTc.Text);
            komut.Parameters.AddWithValue("@p2",rtbşikayet.Text);
            komut.Parameters.AddWithValue("@p3",txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Randevu Alındı","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular", bgl.bağlanti());
            dataAdapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[seçilen].Cells[0].Value.ToString(); 

        }
    }
}
