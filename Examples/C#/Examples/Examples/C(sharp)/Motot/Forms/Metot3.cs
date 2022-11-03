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
    public partial class Metot3 : Form
    {
        public Metot3()
        {
            InitializeComponent();
        }

        int result;

        public int metot3()
        {
            string kısaKenar = txtKısaKenar.Text;
            string uzunKenar = txtUzunKenar.Text;

            int kk = Convert.ToInt32(kısaKenar);
            int uk = Convert.ToInt32(uzunKenar);

            result = uk * kk;
            return result;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sonuc = metot3();
            lblresult.Text = $"Alan : {sonuc}";
        }
    }
}
