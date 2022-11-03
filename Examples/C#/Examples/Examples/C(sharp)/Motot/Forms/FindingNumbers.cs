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
    public partial class FindingNumbers : Form
    {
        public FindingNumbers()
        {
            InitializeComponent();
        }
        int sayac = 5;

        public int GuessNumber(int number1)
        {
            Random rnd = new Random();
            int cpuNumber = rnd.Next(0, 50);

            if (cpuNumber == number1)
            {
                lblResult.Text = $"Kalan hakkınız : {sayac} Doğru cevap";
            }
            else
            {
                sayac--;
                lblResult.Text = $"Kalan hakınız : {sayac} Yanlış cevap ";
            }

            if (sayac == 0)
            {
                MessageBox.Show($"Kalan hakkınız : {sayac} Hakkınız kalmamıştır.");
                Application.Restart();
            }
            return cpuNumber;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string number = txtNumbers.Text;
            int n1 = Convert.ToInt32(number);
            GuessNumber(n1);
        }
    }
}
