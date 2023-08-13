using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYönetimOtomasyonu
{
    public partial class FrmGirişler : Form
    {
        public FrmGirişler()
        {
            InitializeComponent();
        }

        private void BtnHastaGriş_Click(object sender, EventArgs e)
        {
            frmHastaGiriş fr = new frmHastaGiriş();
            fr.Show();
            this.Hide();
        }

        private void BtnDoktorGriş_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş fr=new FrmDoktorGiriş();
            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGriş_Click(object sender, EventArgs e)
        {
            frmSekreterGiriş ffr =new frmSekreterGiriş();
            ffr.Show();
            this.Hide();    
        }
    }
}
