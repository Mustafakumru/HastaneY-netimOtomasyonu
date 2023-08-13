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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlBağlantısı bgl=new sqlBağlantısı();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter dv = new SqlDataAdapter("Select  * From Tbl_Doktor ", bgl.bağlanti());
            dv.Fill(dt2);
            dataGridView1.DataSource = dt2;
            // Branşları Comboboxa Aktarma //
            SqlCommand cmd2 = new SqlCommand("Select Branşad From Tbl_Branş", bgl.bağlanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranş.Items.Add(dr2[0].ToString());
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into tbl_doktor(DokorAd,DoktorSoyad,DoktorBranş,DoktorTc,DoktorŞifre)values (@d1,@d2,@d3,@d4,@d5)",bgl.bağlanti());
            cmd.Parameters.AddWithValue("@d1", txtAd.Text);
            cmd.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@d3", cmbBranş.Text);
            cmd.Parameters.AddWithValue("@d4", MskTc.Text);
            cmd.Parameters.AddWithValue("@d5", txtŞifre.Text);
            cmd.ExecuteNonQuery();  
            bgl.bağlanti().Close();
            MessageBox.Show("Doktor Eklendi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secılen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secılen].Cells[1].Value.ToString(); 
            TxtSoyad.Text = dataGridView1.Rows[secılen].Cells[2].Value.ToString(); 
            cmbBranş.Text = dataGridView1.Rows[secılen].Cells[3].Value.ToString(); 
           MskTc.Text = dataGridView1.Rows[secılen].Cells[4].Value.ToString(); 
            txtŞifre.Text = dataGridView1.Rows[secılen].Cells[5].Value.ToString(); 
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Tbl_doktor where DoktorTc=@p1", bgl.bağlanti());
            cmd.Parameters.AddWithValue("@p1", MskTc.Text);
            cmd.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Kayıt Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doktor Set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBranş=@d3,DoktorŞifre=@d5,DoktorTc=@d4", bgl.bağlanti());
            cmd.Parameters.AddWithValue("@d1", txtAd.Text);
            cmd.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@d3", cmbBranş.Text);
            cmd.Parameters.AddWithValue("@d4", MskTc.Text);
            cmd.Parameters.AddWithValue("@d5", txtŞifre.Text);
            cmd.ExecuteNonQuery ();
            bgl.bağlanti().Close();
            MessageBox.Show("Kayıt Güncellendi" ," Uyarı ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
