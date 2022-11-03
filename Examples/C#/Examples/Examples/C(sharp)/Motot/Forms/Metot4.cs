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
    public partial class Metot4 : Form
    {
        public Metot4()
        {
            InitializeComponent();
        }

        int result;

        public int metot4(int uzunKenar, int kısaKenar)
        {
            result = uzunKenar * kısaKenar;
            lblResult.Text = $"Alan :{result}";
            return result;
           

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string kısa = txtKısaKenar.Text;
            string uzun = txtUzunKenar.Text;

            int uKenar = Convert.ToInt32(uzun);
            int kKenar = Convert.ToInt32(kısa);

            metot4(uKenar,kKenar);
        }
    }
}
