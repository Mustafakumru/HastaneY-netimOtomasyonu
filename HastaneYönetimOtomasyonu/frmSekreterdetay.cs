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
    public partial class frmSekreterdetay : Form
    {
        public frmSekreterdetay()
        {
            InitializeComponent();
        }
        public string TcNumara;
        sqlBağlantısı bgl=new sqlBağlantısı();

        private void frmSekreterdetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TcNumara;
            //Ad Soyad
            SqlCommand cmd = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter Where SekreterTC=@p1;", bgl.bağlanti());
            cmd.Parameters.AddWithValue("@p1",lblTc.Text);
            SqlDataReader dr1= cmd.ExecuteReader(); 
            while (dr1.Read()) {
                LblAdSoyad.Text = dr1[0].ToString();
             }
            bgl.bağlanti().Close();

            //BrANŞLARI DATAGRİDE AKTAARMA
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BranşAd From Tbl_Branş", bgl.bağlanti());
            da.Fill(dt1);   
            dataGridView1.DataSource = dt1;
            bgl.bağlanti().Close();
            //Doktorları Listeye Aktarma
            DataTable dt2= new DataTable();
            SqlDataAdapter dv = new SqlDataAdapter("Select (DokorAd+''+DoktorSoyad)as 'Doktorlar',DoktorBranş From Tbl_Doktor ", bgl.bağlanti());
            dv.Fill(dt2);   
            dataGridView2.DataSource = dt2; 
            bgl.bağlanti().Close();
            //Branşı combobaxa aktarma
            SqlCommand cmd2 = new SqlCommand("Select Branşad From Tbl_Branş",bgl.bağlanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranş.Items.Add(dr2[0].ToString());      
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBranş,RandevuDoktor)values (@p1,@p2,@p3,@p4)", bgl.bağlanti());
            cmd.Parameters.AddWithValue("@p1", maskTarih.Text);
            cmd.Parameters.AddWithValue("@p2", mskSaat.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBranş.Text);
            cmd.Parameters.AddWithValue("@p4",cmbDoktor.Text);
            cmd.ExecuteNonQuery();
            bgl.bağlanti().Close() ;
            MessageBox.Show("Randevu Oluşturuldu::");
        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select  DokorAd,DoktorSoyad From Tbl_Doktor where DoktorBranş=@p1", bgl.bağlanti());
            komut.Parameters.AddWithValue("@p1",cmbBranş.Text); 
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read()) {
                cmbDoktor.Items.Add(dataReader[0]+" " + dataReader[1]);
            }
            bgl.bağlanti().Close() ;
        }

        private void BtnDuyuruPaylaş_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Duyuru (duyuru) values (@d1)", bgl.bağlanti());
            komut.Parameters.AddWithValue("@d1",RtbDuyuruList.Text);
            komut.ExecuteNonQuery() ;
            bgl.bağlanti().Close() ;
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp= new FrmDoktorPaneli();
            drp.Show();
            
        }

        private void BtnBranşpanel_Click(object sender, EventArgs e)
        {
            FrmBranş frb=new FrmBranş();
            frb.Show();
        }

        private void btnRandevulist_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl=new FrmRandevuListesi();
            frl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();  
        }
    }
}
