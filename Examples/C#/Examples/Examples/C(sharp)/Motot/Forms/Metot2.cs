using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples
{
    public partial class Metot2 : Form
    {
        public Metot2()
        {
            InitializeComponent();
        }
        int result;
        public void metot2(int kısa, int uzun)
        {

            result = kısa * uzun;

            lblResult.Text = $"Alan : {result}";

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            string uzunKenar = txtUzunKenar.Text;
            string kısaKenar = txtKısaKenar.Text;

            int kk = Convert.ToInt32(kısaKenar);
            int uk = Convert.ToInt32(uzunKenar);

            if (string.IsNullOrEmpty(uzunKenar) || string.IsNullOrEmpty(kısaKenar))
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz.");
            }

            metot2(kk,uk);
        }
    }
}
