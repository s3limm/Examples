using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examples
{
    public partial class Metot1 : Form
    {
        public Metot1()
        {
            InitializeComponent();
        }
        int result;
        public void metot1()
        {

            string kısaKenar = txtKısaKenar.Text;
            string uzunKenar = txtUzunKenar.Text;

            int kk = Convert.ToInt32(kısaKenar);
            int uk = Convert.ToInt32(uzunKenar);

            if (string.IsNullOrEmpty(uzunKenar) || string.IsNullOrEmpty(kısaKenar))
            {
                MessageBox.Show("Lütfen satırları boş bırakmayınız.");
            }

            result = kk * uk;
            MessageBox.Show($"ALan : {result}");

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            metot1();
        }
    }
}
