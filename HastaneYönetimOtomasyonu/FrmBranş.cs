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
    public partial class FrmBranş : Form
    {
        public FrmBranş()
        {
            InitializeComponent();
        }
        sqlBağlantısı bgl=new sqlBağlantısı();
        private void FrmBranş_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da=new SqlDataAdapter("Select*From Tbl_Branş",bgl.bağlanti());

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branş (Branşad)values(@b1)", bgl.bağlanti());
            cmd.Parameters.AddWithValue("@b1",TxtBranşAd);
            cmd.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Branş Eklendi ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;   
            txtid.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();   
             
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete From Tbl_branş where Branşid=@b1", bgl.bağlanti());
            cmd.Parameters.AddWithValue("@b1", txtid.Text);
            cmd.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Tbl_branş set branşad=@p1 where branşid=@p2", bgl.bağlanti());
            cmd.Parameters.AddWithValue("@p1",TxtBranşAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtid.Text);
            cmd.ExecuteNonQuery();
            bgl.bağlanti().Close();
            MessageBox.Show("Branş Güncellendi");
        }
    }
}
