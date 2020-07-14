using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tckimlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            TCKimlikNoDogrulama.KPSPublic kPS = new TCKimlikNoDogrulama.KPSPublic();
            bool kontrol = kPS.TCKimlikNoDogrula(long.Parse(txtTCKimlikNo.Text), txtIsim.Text.ToUpper(), txtSoyisim.Text.ToUpper(), int.Parse(txtDYili.Text));
            if (kontrol)
            {
                MessageBox.Show("Bilgileriniz doğrulandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgileriniz doğrulanamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
