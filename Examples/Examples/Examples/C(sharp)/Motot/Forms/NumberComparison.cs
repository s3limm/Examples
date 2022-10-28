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
    public partial class NumberComparison : Form
    {
        public NumberComparison()
        {
            InitializeComponent();
        }
        int büyük;
        int result;

        public int Compare(int number1, int number2)
        {
            if (number1 > number2)
            {
                büyük = number1;
                lblResult.Text = $"Büyük sayı = {büyük}";
                return büyük;
            }
            else if (number1 < number2)
            {
                büyük = number2;
                lblResult.Text = $"Büyük sayı = {büyük}";
                return büyük;
            }
            else
            {
                lblResult.Text = "Sayılar bir birine eşittir.";
                return result;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string number1 = txtFirstNumber.Text;
            string number2 = txtSecondNumber.Text;

            int n1 = Convert.ToInt32(number1);
            int n2 = Convert.ToInt32(number2);

            Compare(n1, n2);

        }
    }
}
